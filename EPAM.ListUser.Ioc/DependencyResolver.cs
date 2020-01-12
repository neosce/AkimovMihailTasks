using EPAM.ListUser.DAL.Memory;
using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.BLL;
using EPAM.ListUsers.BLL.Interfaces;

namespace EPAM.ListUser.Ioc
{
    public class DependencyResolver
    {

        // User
        private static IUserDao _userDao;

        public static IUserDao UserDao => _userDao ?? (_userDao = new UserCollectionDao());

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));

        // Award
        private static IAwardDao _awardDao;

        public static IAwardDao AwardDao => _awardDao ?? (_awardDao = new AwardColletionDao());

        private static IAwardLogic _awardLogic;

        public static IAwardLogic AwardLogic => _awardLogic ?? (_awardLogic = new AwardLogic(AwardDao));

    }
}
