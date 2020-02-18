using EPAM.ListUserAward.WebPages.Common;
using EPAM.ListUsers.BLL.Interfaces;
using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPAM.ListUserAward.WebPages.Models
{
    public class AddController
    {

        internal static void StartCollection(IUserLogic userLogic, IAwardLogic awardLogic, AuthModel authModel)
        {
            #region Collection in user for awards

            // Award
            _ = awardLogic.Add(new Award()
            {
                Title = "Backend",
            });

            _ = awardLogic.Add(new Award()
            {
                Title = "Frontend",
            });

            // User
            _ = userLogic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("14.05.1995"),
                Name = "Nikola",
                userAward = new List<int> { 1, 2 }
            });

            _ = userLogic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("17.02.2005"),
                Name = "Slava"
            });

            _ = userLogic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("01.03.1955"),
                Name = "Igor",
                userAward = new List<int> { 1, 2 }
            });
            #endregion

            #region Collection in user for Site

            //SuperAdmin
            authModel.Add(new UserAuth()
            {
                Email = "Misha@mail.com",
                Password = "superadmin",
                Telephone = "101010",
                UserRights = "SuperAdmin"
            });

            //Admin
            authModel.Add(new UserAuth()
            {
                Email = "UserAdmin@mail.com",
                Password = "admin",
                Telephone = "111111",
                UserRights = "Admin"
            });

            //User
            authModel.Add(new UserAuth()
            {
                Email = "UserOne@mail.com",
                Password = "12345",
                Telephone = "121212",
                UserRights = "User"
            });

            authModel.Add(new UserAuth()
            {
                Email = "UserTwo@mail.com",
                Password = "12345",
                Telephone = "131313",
                UserRights = "User"
            });

            authModel.Add(new UserAuth()
            {
                Email = "UserThree@mail.com",
                Password = "12345",
                Telephone = "141414",
                UserRights = "User"
            });

            #endregion

        }

    }
}