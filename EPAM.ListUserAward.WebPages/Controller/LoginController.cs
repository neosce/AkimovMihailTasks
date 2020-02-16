using EPAM.ListUser.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPAM.ListUserAward.WebPages.Models;

namespace EPAM.ListUserAward.WebPages.Controller
{
    public class LoginController
    {

        public void ResponseUserList()
        {

            var userLogic = DependencyResolver.UserLogic;
            var awardLogic = DependencyResolver.AwardLogic;

            AddController.StartCollection(userLogic, awardLogic);

        }


    }
}