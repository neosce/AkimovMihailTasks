using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.BLL.Interfaces;
using EPAM.ListUsers.Entities;
using System.Collections.Generic;

namespace EPAM.ListUsers.BLL
{
    public class UserLogic : IUserLogic
    {

        private readonly IUserDao _userDao;

        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public User Add(User user)
        {
            return _userDao.Add(user);
        }

        public string DeletedById(int id)
        {
            return _userDao.DeletedById(id);
        }

        public string DeletedByIdAward(int idUser, int idAward)
        {
            return _userDao.DeletedByIdAward(idUser, idAward);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public User GetById(int id)
        {
            return _userDao.GetById(id);
        }
    }
}
