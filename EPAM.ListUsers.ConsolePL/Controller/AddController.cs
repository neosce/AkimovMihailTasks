using EPAM.ListUser.Ioc;
using EPAM.ListUsers.BLL.Interfaces;
using EPAM.ListUsers.Entities;
using System;

namespace EPAM.ListUsers.ConsolePL.Controller
{
    internal class AddController
    {

        internal static void AddCollection(IUserLogic logic)
        {
            //var logic = DependencyResolver.UserLogic;

            _ = logic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("14.05.1995"),
                Name = "Misha",
            });

            _ = logic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("17.02.2005"),
                Name = "Anton"
            });

            _ = logic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("01.03.1955"),
                Name = "Victor"
            });

            Console.WriteLine("Users was Add");
        } 

    }
}
