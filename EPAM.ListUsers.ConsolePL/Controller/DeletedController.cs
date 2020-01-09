using EPAM.ListUser.Ioc;
using EPAM.ListUsers.BLL.Interfaces;
using System;

namespace EPAM.ListUsers.ConsolePL.Controller
{
    internal class DeletedController
    {

        internal static void DeletedInCollection(IUserLogic logic)
        {

            int n;

            Console.WriteLine("Enter User id:");
            var _numberList = Console.ReadLine();

            if (int.TryParse(_numberList, out n) && n > 0)
            {
                var error = logic.DeletedById(n);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("Enter error!");
            }

        }

    }
}
