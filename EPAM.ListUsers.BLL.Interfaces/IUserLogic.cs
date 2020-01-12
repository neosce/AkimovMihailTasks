using EPAM.ListUsers.Entities;
using System.Collections.Generic;

namespace EPAM.ListUsers.BLL.Interfaces
{
    public interface IUserLogic
    {

        User Add(User user);

        User GetById(int id);

        string DeletedById(int id);

        IEnumerable<User> GetAll();

        string DeletedByIdAward(int idUser, int idAward);

    }
}
