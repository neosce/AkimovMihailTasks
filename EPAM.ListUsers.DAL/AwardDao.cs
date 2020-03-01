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
    public class AwardDao : IAwardDao
    {

        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserAward;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        List<Award> _awardList = new List<Award>();

        Award IAwardDao.Add(Award award)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddAward";

                var titleParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Title",
                    Value = award.Title,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(titleParametr);
                
                var idParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdAward",
                    Value = award.Id,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }
            return award;
        }

        string IAwardDao.DeletedById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteAward";

                var idParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdAward",
                    Value = id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }
            return $"Award delete id: {id}";
        }

        IEnumerable<Award> IAwardDao.GetAll()
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                _awardList.Clear();
                
                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "Select [Award].[IdAward], [Award].[Title] From [Award]";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    _awardList.Add(new Award
                    {
                        Id = (int)reader["IdAward"],
                        Title = reader["Title"].ToString()
                    });
                }
            }
            return _awardList;
        }

        Award IAwardDao.GetById(int id)
        {
            Award award = _awardList.Find(x => x.Id == id);
            return award;
        }
    }
}
