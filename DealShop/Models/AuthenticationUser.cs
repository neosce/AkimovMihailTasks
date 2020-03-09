using DealShop.ListUsers.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealShop.Models
{
    public class AuthenticationUser
    {

        public bool GetAuthUser(string email, string pass) 
        {
            var userLogic = DependencyResolver.UserLogic;

            if (userLogic.GetAll().Any(x => x.LoginEmail == email && x.Password == pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}