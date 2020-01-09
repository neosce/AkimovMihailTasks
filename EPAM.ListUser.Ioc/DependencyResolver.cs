using EPAM.ListUser.DAL.Memory;
using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.BLL;
using EPAM.ListUsers.BLL.Interfaces;

namespace EPAM.ListUser.Ioc
{
    public class DependencyResolver
    {

        private static IUserDao _userDao;

        public static IUserDao UserDao => _userDao ?? (_userDao = new UserCollectionDao());

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));

    }
}
