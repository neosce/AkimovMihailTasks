using DealShop.ListUsers.Entities;
using DealShop.ListUsers.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealShop.Models
{
    public class UpdateUser
    {

        public void Update(int id, string loginEmail, string password, string firstName, string lastName, DateTime dateTime, string address, decimal money, string userRights, byte[] userLogo)
        {
            User user = new User();
            var userLogic = DependencyResolver.UserLogic;

            user.Id = id;
            user.LoginEmail = loginEmail;
            user.Password = password;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.DateOfBirthday = dateTime;
            user.Address = address;
            user.Money = money;
            user.UserRights = userRights;
            user.userLogo = userLogo;

            userLogic.Update(user);

        }

        public void AddUser(int id, string loginEmail, string password, string firstName, string lastName, DateTime dateTime, string address, decimal money, string userRights, byte[] userLogo)
        {
            User user = new User();
            var userLogic = DependencyResolver.UserLogic;

            user.Id = id;
            user.LoginEmail = loginEmail;
            user.Password = password;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.DateOfBirthday = dateTime;
            user.Address = address;
            user.Money = money;
            user.UserRights = userRights;
            user.userLogo = userLogo;

            userLogic.Add(user);

        }

    }
}