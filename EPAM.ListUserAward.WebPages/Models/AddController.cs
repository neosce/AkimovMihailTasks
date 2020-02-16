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

        internal static void StartCollection(IUserLogic userLogic, IAwardLogic awardLogic)
        {

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

        }

    }
}