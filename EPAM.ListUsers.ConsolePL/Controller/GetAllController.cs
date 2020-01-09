using EPAM.ListUser.Ioc;
using EPAM.ListUsers.BLL.Interfaces;
using System;

namespace EPAM.ListUsers.ConsolePL.Controller
{
    internal class GetAllController
    {

        internal static void GetAllCollection(IUserLogic logic)
        {
            foreach (var item in logic.GetAll())
            {
                Console.WriteLine(item);
            }
        }

    }
}
