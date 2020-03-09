using DealShop.ListUsers.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealShop.Models
{
    public class MessageUserRight
    {

        public string GetUserRight(string username)
        {
            var userLogic = DependencyResolver.UserLogic;

            foreach (var user in userLogic.GetAll())
            {
                if (user.LoginEmail == username)
                {
                    return user.UserRights;
                }
            }

            return "Error user/admin not in DB!";
        } 

    }
}