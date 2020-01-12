using EPAM.ListUsers.BLL.Interfaces;
using System;

namespace EPAM.ListUsers.ConsolePL.Controller
{
    internal class DeletedController
    {

        internal static void DeletedInCollection(IUserLogic logic)
        {
            int n;

            do
            {
                Console.WriteLine("Select deleted user or user-award: \n1 - User\n2 - User-award\n0 - Exit");

                var numberList = Console.ReadLine();

                if (int.TryParse(numberList, out n))
                {

                    switch (n)
                    {
                        case 1:
                            DeleteUser(logic);
                            break;

                        case 2:
                            DeleteUserAward(logic);
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

        private static void DeleteUserAward(IUserLogic logic)
        {
            try
            {
                Console.WriteLine("Enter User id:");
                var userId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter award id:");
                var awarId = int.Parse(Console.ReadLine());

                if (logic.GetById(userId) != null)
                {
                    var notification = logic.DeletedByIdAward(userId, awarId);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{notification}\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine("User missing!");
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Not integer!");
            }
        }

        private static void DeleteUser(IUserLogic logic)
        {
            int id;

            Console.WriteLine("Enter User id:");

            var userId = Console.ReadLine();

            if (int.TryParse(userId, out id) && id > 0)
            {
                var notification = logic.DeletedById(id);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{notification}\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("Enter error!");
            }
        }
    }
}
