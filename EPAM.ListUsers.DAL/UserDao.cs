using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.ListUsers.DAL
{

    public class UserDao : IUserDao
    {

        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserAward;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        List<User> _userList = new List<User>();

        User IUserDao.Add(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddUser";

                var nameParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Name",
                    Value = user.Name,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(nameParameter);

                var dateTimeParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@DateTime",
                    Value = user.DateOfBirthday,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(dateTimeParameter);

                var ageParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Age",
                    Value = user.Age,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(ageParameter);

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = user.Id,
                    Direction = ParameterDirection.Output

                };
                command.Parameters.Add(idParameter);

                connection.Open();
                
                command.ExecuteNonQuery();
            }

            getIdUser(user);

            foreach (var award in user.userAward)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    var command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddUserAward";

                    var idParametr = new SqlParameter()
                    {
                        DbType = DbType.Int32,
                        ParameterName = "@IdUser",
                        Value = user.Id,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(idParametr);

                    var idAwardParametr = new SqlParameter()
                    {
                        DbType = DbType.Int32,
                        ParameterName = "@IdAward",
                        Value = award,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(idAwardParametr);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            return user;
        }

        private void getIdUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = $"Select [Id] from [User] where [Name] = '{user.Name}'";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                }
            }
        }

        string IUserDao.DeletedById(int id)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteUser";

                var idParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParametr);

                connection.Open();
                
                command.ExecuteNonQuery();
            }

            return $"User delete: {id}";
        }

        string IUserDao.DeletedByIdAward(int idUser, int idAward)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteUserAward";

                var idParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdUser",
                    Value = idUser,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParametr);

                var idAwardParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdAward",
                    Value = idAward,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idAwardParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }

            return $"User id award: {idUser}, {idAward}";
        }

        IEnumerable<User> IUserDao.GetAll()
        {
            var userList = new List<User>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "Select [User].[Id], [Name], [DateTime], [Award].[IdAward] from [User] left outer join [UserAndAward] on [UserAndAward].[IdUser] = [User].[Id] left outer join [Award] on [Award].[IdAward] = [UserAndAward].[IdAward]";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (userList.Exists(x => x.Id == (int)reader["Id"]))
                    {
                        foreach (var item in userList)
                        {
                            if (item.Id == (int)reader["Id"])
                            {
                                item.userAward.Add((int)reader["IdAward"]);
                            }
                        }
                    }
                    else
                    {
                        GetNewUser(userList, reader);
                    }
                }
            }
            _userList = userList;
            return userList;
        }

        User IUserDao.GetById(int id)
        {
            User user = _userList.Find(x => x.Id == id);

            return user;
        }

        private static void GetNewUser(List<User> userList, SqlDataReader reader)
        {
            if (!Convert.IsDBNull(reader["IdAward"]))
            {
                userList.Add(new User
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    DateOfBirthday = DateTime.Parse(reader["DateTime"].ToString()),
                    userAward = new List<int> { (int)reader["IdAward"] }
                });
            }
            else
            {
                userList.Add(new User
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    DateOfBirthday = DateTime.Parse(reader["DateTime"].ToString())
                });
            }
            
        }

        string IUserDao.Update(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateUser";

                var nameParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Name",
                    Value = user.Name,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(nameParameter);

                var dateTimeParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@DateTime",
                    Value = user.DateOfBirthday,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(dateTimeParameter);

                var ageParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Age",
                    Value = user.Age,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(ageParameter);

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = user.Id,
                    Direction = ParameterDirection.Input

                };
                command.Parameters.Add(idParameter);

                connection.Open();
                command.ExecuteNonQuery();
            }

            getIdUser(user);

            foreach (var award in user.userAward)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    var command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddUserAward";

                    var idParametr = new SqlParameter()
                    {
                        DbType = DbType.Int32,
                        ParameterName = "@IdUser",
                        Value = user.Id,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(idParametr);

                    var idAwardParametr = new SqlParameter()
                    {
                        DbType = DbType.Int32,
                        ParameterName = "@IdAward",
                        Value = award,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(idAwardParametr);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }

            return $"Update: {user.Id}";
        }
    }
}
