﻿using EPAM.ListUserAward.WebPages.Common;
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

            //// Award
            //_ = awardLogic.Add(new Award()
            //{
            //    Title = "Backend",
            //});

            //_ = awardLogic.Add(new Award()
            //{
            //    Title = "Frontend",
            //});

            //// User
            //_ = userLogic.Add(new User()
            //{
            //    DateOfBirthday = DateTime.Parse("14.05.1995"),
            //    Name = "Nikola",
            //    userAward = new List<int> { 1, 2 }
            //});

            //_ = userLogic.Add(new User()
            //{
            //    DateOfBirthday = DateTime.Parse("17.02.2005"),
            //    Name = "Slava"
            //});

            //_ = userLogic.Add(new User()
            //{
            //    DateOfBirthday = DateTime.Parse("01.03.1955"),
            //    Name = "Igor",
            //    userAward = new List<int> { 1, 2 }
            //});
            #endregion

            #region Collection in user for Site

            //SuperAdmin
            authModel.Add(new UserAuth()
            {
                Email = "Misha@mail.com",
                Password = "superadmin",
                Telephone = "101010",
                UserRights = "SuperAdmin",
                UserLogo = "data:image/png;base64,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"

            });

            //Admin
            authModel.Add(new UserAuth()
            {
                Email = "UserAdmin@mail.com",
                Password = "admin",
                Telephone = "111111",
                UserRights = "Admin",
                UserLogo = "https://clipartart.com/images/admin-icon-clipart-5.jpg"
            });

            //User
            authModel.Add(new UserAuth()
            {
                Email = "UserOne@mail.com",
                Password = "12345",
                Telephone = "121212",
                UserRights = "User",
                UserLogo = "https://img.icons8.com/clouds/2x/user.png"
            });

            authModel.Add(new UserAuth()
            {
                Email = "UserTwo@mail.com",
                Password = "12345",
                Telephone = "131313",
                UserRights = "User",
                UserLogo = "https://img.icons8.com/clouds/2x/user.png"
            });

            authModel.Add(new UserAuth()
            {
                Email = "UserThree@mail.com",
                Password = "12345",
                Telephone = "141414",
                UserRights = "User",
                UserLogo = "https://img.icons8.com/clouds/2x/user.png"
            });

            #endregion

        }

    }
}