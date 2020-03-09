using DealShop.ListUser.Dao.Interfaces;
using DealShop.ListUsers.BLL.Interfaces;
using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.BLL
{
    public class UserLogic : IUserLogic
    {

        private readonly IUserDao _userDao;

        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }

        User IUserLogic.Add(User user)
        {
            return _userDao.Add(user);
        }

        string IUserLogic.DeletedById(int id)
        {
            return _userDao.DeletedById(id);
        }

        IEnumerable<User> IUserLogic.GetAll()
        {
            return _userDao.GetAll();
        }

        User IUserLogic.GetById(int id)
        {
            return _userDao.GetById(id);
        }

        string IUserLogic.Update(User user)
        {
            return _userDao.Update(user);
        }
    }
}
