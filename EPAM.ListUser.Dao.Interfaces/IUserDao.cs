using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EPAM.ListUser.Dao.Interfaces
{
    public interface IUserDao
    {

        User Add(User user);

        User GetById(int id);

        string DeletedById(int id);

        IEnumerable<User> GetAll();

        string DeletedByIdAward(int idUser, int idAward);

        string Update(User user);

    }
}
