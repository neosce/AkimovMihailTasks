using EPAM.ListUser.Ioc;
using EPAM.ListUsers.ConsolePL.Controller;
using System;

namespace EPAM.ListUsers.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            var logic = DependencyResolver.UserLogic;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Epam - List Users Awards!");
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {

                Console.WriteLine("Select operating mode: \n1 - Add User and Award\n2 - Get All List\n3 - Deleted User by\n0 - EXIT ");

                var _numberList = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(_numberList, out n))
                {
                    switch (n)
                    {
                        case 1:
                            AddController.AddCollection(logic);
                            break;
                        case 2:
                            GetAllController.GetAllCollection(logic);
                            break;
                        case 3:
                            DeletedController.DeletedInCollection(logic);
                            break;
                        default:
                            n = 0;
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    n = -1;
                }

            } while (n != 0);

        }
    }
}
