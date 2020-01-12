using EPAM.ListUsers.BLL.Interfaces;
using System;

namespace EPAM.ListUsers.ConsolePL.Controller
{
    internal class GetAllController
    {

        private static int _count = 1;

        internal static void GetAllCollection(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            int n;
            
            do
            {
                Console.WriteLine("Select display collection list: \n1 - User\n2 - Award\n0 - Exit");

                var numberList = Console.ReadLine();

                if (int.TryParse(numberList, out n))
                {

                    switch (n)
                    {
                        case 1:
                            AllGetUser(userLogic, awardLogic);
                            break;

                        case 2:
                            AllGetAward(userLogic, awardLogic);
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

        private static void AllGetUser(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            _count = 1;

            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine();
                Console.WriteLine($"User:{_count++}\n {user}");

                if (user.userAward != null)
                {
                    Console.Write(" Award:");
                    foreach (var awardUser in user.userAward)
                    {
                        foreach (var award in awardLogic.GetAll())
                        {
                            if (awardUser == award.Id)
                            {
                                Console.Write($" {award}");
                            }
                        }
                    }
                }

            }
            Console.WriteLine("\n");
        }

        private static void AllGetAward(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            _count = 1;

            foreach (var award in awardLogic.GetAll())
            {
                Console.WriteLine();
                Console.WriteLine($"Award:{_count++}\n {award}");

                foreach (var user in userLogic.GetAll())
                {
                    if (user.userAward != null)
                    {
                        Console.Write(" User:");
                        foreach (var awardUser in user.userAward)
                        {
                            if (award.Id == awardUser)
                            {
                                Console.Write($" {user.Id}:{user.Name}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n");
        }

    }
}
