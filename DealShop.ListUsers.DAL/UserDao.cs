using DealShop.ListUser.Dao.Interfaces;
using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.DAL
{
    public class UserDao : IUserDao
    {

        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DealShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private List<User> _users = new List<User>();

        User IUserDao.Add(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddUser";

                var loginEmailParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@LoginEmail",
                    Value = user.LoginEmail,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(loginEmailParametr);

                var passwordParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Password",
                    Value = user.Password,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(passwordParametr);

                var firstNameParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@FirstName",
                    Value = user.FirstName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(firstNameParametr);

                var lastNameParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@LastName",
                    Value = user.LastName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(lastNameParametr);

                var dateOfBirthdayParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@DateOfBirthday",
                    Value = user.DateOfBirthday,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(dateOfBirthdayParametr);

                var addressParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Address",
                    Value = user.Address,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(addressParametr);

                var ageParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Age",
                    Value = user.Age,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ageParametr);

                var moneyParametr = new SqlParameter()
                {
                    DbType = DbType.Decimal,
                    ParameterName = "@Money",
                    Value = user.Money,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(moneyParametr);

                var creditsCardNumberParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@CreditsCardNumber",
                    Value = user.CreditsCardNumber,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(creditsCardNumberParametr);

                var userLogoParametr = new SqlParameter()
                {
                    DbType = DbType.Binary,
                    ParameterName = "@UserLogo",
                    Value = user.userLogo,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(userLogoParametr);

                var userRightsParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@UserRights",
                    Value = user.UserRights,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(userRightsParametr);

                var idParametr = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = user.Id,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }

            return user;
        }

        string IUserDao.DeletedById(int id)
        {
            return "Only ban user";
        }

        IEnumerable<User> IUserDao.GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllUser";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!_users.Exists(x => x.Id == (int)reader["Id"]))
                    {
                        if (reader["UserLogo"] == DBNull.Value)
                        {
                            _users.Add(new User
                            {
                                Id = (int)reader["Id"],
                                LoginEmail = reader["LoginEmail"].ToString(),
                                Password = reader["Password"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                DateOfBirthday = DateTime.Parse(reader["DateOfBirthday"].ToString()),
                                Address = reader["Address"].ToString(),
                                Money = (decimal)reader["Money"],
                                CreditsCardNumber = (int)reader["CreditsCardNumber"],
                                UserRights = reader["UserRights"].ToString()
                            });
                        }
                        else
                        {
                            _users.Add(new User
                            {
                                Id = (int)reader["Id"],
                                LoginEmail = reader["LoginEmail"].ToString(),
                                Password = reader["Password"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                DateOfBirthday = DateTime.Parse(reader["DateOfBirthday"].ToString()),
                                Address = reader["Address"].ToString(),
                                Money = (decimal)reader["Money"],
                                CreditsCardNumber = (int)reader["CreditsCardNumber"],
                                userLogo = (byte[])reader["UserLogo"],
                                UserRights = reader["UserRights"].ToString()
                            });
                        }
                    }
                }
            }

            return _users;
        }

        User IUserDao.GetById(int id)
        {
            User user = new User();
            user = _users.Find(x => x.Id == id);

            if (user.Id == id)
            {
                return user;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    var command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetByIdUser";

                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        user.Id = (int)reader["Id"];
                        user.LoginEmail = reader["LoginEmail"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.FirstName = reader["FirstName"].ToString();
                        user.LastName = reader["LastName"].ToString();
                        user.DateOfBirthday = DateTime.Parse(reader["DateOfBirthday"].ToString());
                        user.Address = reader["Address"].ToString();
                        user.Money = (decimal)reader["Money"];
                        user.CreditsCardNumber = (int)reader["CreditsCardNumber"];
                        user.userLogo = (byte[])reader["UserLogo"];
                        user.UserRights = reader["UserRights"].ToString();
                    }
                }
                return user;
            }   
        }

        string IUserDao.Update(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateUser";

                var loginEmailParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@LoginEmail",
                    Value = user.LoginEmail,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(loginEmailParametr);

                var firstNameParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@FirstName",
                    Value = user.FirstName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(firstNameParametr);

                var passwordParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Password",
                    Value = user.Password,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(passwordParametr);

                var lastNameParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@LastName",
                    Value = user.LastName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(lastNameParametr);

                var dateOfBirthdayParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@DateOfBirthday",
                    Value = user.DateOfBirthday,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(dateOfBirthdayParametr);

                var addressParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Address",
                    Value = user.Address,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(addressParametr);

                var ageParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Age",
                    Value = user.Age,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ageParametr);

                var moneyParametr = new SqlParameter()
                {
                    DbType = DbType.Decimal,
                    ParameterName = "@Money",
                    Value = user.Money,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(moneyParametr);

                var creditsCardNumberParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@CreditsCardNumber",
                    Value = user.CreditsCardNumber,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(creditsCardNumberParametr);

                if (user.userLogo != null)
                {
                    var userLogoParametr = new SqlParameter()
                    {
                        DbType = DbType.Binary,
                        ParameterName = "@UserLogo",
                        Value = user.userLogo,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(userLogoParametr);
                }
               
                var userRightsParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@UserRights",
                    Value = user.UserRights,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(userRightsParametr);

                var idParametr = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = user.Id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }

            return "Update user OK";
        }
    }
}
