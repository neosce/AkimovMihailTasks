using EPAM.ListUser.Ioc;
using EPAM.ListUsers.BLL.Interfaces;
using EPAM.ListUsers.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EPAM.ListUsers.ConsolePL.Controller
{
    internal class AddController
    {

        internal static void AddCollection(IUserLogic userLogic, IAwardLogic awardLogic)
        {

            int n;
            
            do
            {
                Console.WriteLine("Select add: \n1 - User\n2 - Award\n0 - Exit");
                
                var numberList = Console.ReadLine();

                if (int.TryParse(numberList, out n))
                {

                    switch (n)
                    {
                        case 1:
                            AddUser(userLogic, awardLogic);
                            break;

                        case 2:
                            Console.WriteLine("Enter title: ");
                            var title = Console.ReadLine();

                            _ = awardLogic.Add(new Award()
                            {
                                Title = title
                            });
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
                Name = "Misha",
                //userAward = new System.Collections.Generic.List<Award>() { award1 } 
            });

            _ = userLogic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("17.02.2005"),
                Name = "Anton"
            });

            _ = userLogic.Add(new User()
            {
                DateOfBirthday = DateTime.Parse("01.03.1955"),
                Name = "Victor",
                userAward = new List<int> { 1, 2 }
            });

        }

        private static void AddUser(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            int idAward;

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Date Of Birthday in format(dd.MM.yyyy): ");
            var dob = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter number award");
                idAward = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new ArgumentException("Not integer!");
            }

            if (awardLogic.GetById(idAward) != null)
            {
                _ = userLogic.Add(new User()
                {
                    Name = name,
                    DateOfBirthday = DateTime.Parse(dob),
                    userAward = new List<int>() { idAward }
                });
            }
            else
            {
                Console.WriteLine($"Enter number award:{idAward} missing!");

                _ = userLogic.Add(new User()
                {
                    Name = name,
                    DateOfBirthday = DateTime.Parse(dob)
                });
            }

            Console.WriteLine("Userd add!");
        }

        

    }
}
