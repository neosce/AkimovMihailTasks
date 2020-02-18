using EPAM.ListUser.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPAM.ListUserAward.WebPages.Models;
using EPAM.ListUserAward.WebPages.Common;

namespace EPAM.ListUserAward.WebPages.Controller
{
    public class LoginController
    {

        public void ResponseUserList()
        {

            var userLogic = DependencyResolver.UserLogic;
            var awardLogic = DependencyResolver.AwardLogic;
            var _authModel = new AuthModel();

            AddController.StartCollection(userLogic, awardLogic, _authModel);

        }

    }
}