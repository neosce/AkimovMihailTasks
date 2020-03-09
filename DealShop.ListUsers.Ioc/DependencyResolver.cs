using DealShop.ListUser.Dao.Interfaces;
using DealShop.ListUsers.BLL;
using DealShop.ListUsers.BLL.Interfaces;
using DealShop.ListUsers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.Ioc
{
    public class DependencyResolver
    {

        #region User
        private static IUserDao _userDao;

        public static IUserDao UserDao => _userDao ?? (_userDao = new UserDao());

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));
        #endregion

        #region Product
        private static IProductDao _productDao;

        public static IProductDao ProductDao => _productDao ?? (_productDao = new ProductDao());

        private static IProductLogic _productLogic;

        public static IProductLogic ProductLogic => _productLogic ?? (_productLogic = new ProductLogic(ProductDao));
        #endregion
    }
}
