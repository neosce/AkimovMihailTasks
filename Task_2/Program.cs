using System;
using Task_2.Tasks.Encapsulation.Task2._1;
using Task_2.Tasks.Encapsulation.Task2._2;
using Task_2.Tasks.Encapsulation.Task2._3;
using Task_2.Tasks.Encapsulation.Task2._4;
using Task_2.Tasks.Inheritance;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, n1, n2, n3;

            Console.WriteLine("Task_2\n" + "The task corresponds to the number in the list:");

            do
            {
                Console.WriteLine("1 - Encapsulation\n" + "2 - Inheritance\n" + "3 - Polymorphism\n" + "0 - EXIT\n");

                var number_list = Console.ReadLine();

                if (int.TryParse(number_list, out n) && n < 4 && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("Encapsulation:\n" + "1 - Round" + "\n2 - Triangle" + "\n3 - User" + "\n4 - My String" + "\n0 - BREAK");
                                var number_sublist1 = Console.ReadLine();

                                if (int.TryParse(number_sublist1, out n1) && n < 5 && n >= 0)
                                {
                                    switch (n1)
                                    {
                                        case 1:
                                            MainRound.mainRound();
                                            break;
                                        case 2:
                                            MainTriangle.mainTriangle();
                                            break;
                                        case 3:
                                            MainUser.mainUser();
                                            break;
                                        case 4:
                                            MainMyString.mainString();
                                            break;
                                        default:
                                            n1 = 0;
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Try once more...");
                                }
                            } while (n1 != 0);
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("Inheritance:\n" + "\n5 - Empolyee" + "\n6 - Ring" + "\n0 - BREAK");
                                var number_sublist2 = Console.ReadLine();

                                if (int.TryParse(number_sublist2, out n2) && n < 7 && n >= 0)
                                {
                                    switch (n2)
                                    {
                                        case 5:
                                            Task_2.Tasks.Inheritance.Task2._5.MainUser.mainUser();
                                            break;
                                        case 6:
                                            Console.WriteLine("6");
                                            break;
                                        default:
                                            n2 = 0;
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Try once more...");
                                }
                            } while (n2 != 0);
                            break;
                        case 3:
                            do
                            {
                                Console.WriteLine("Polymorphism:\n" + "\n7 - Vector Graphics Editor" + "\n8 - Game" + "\n0 - BREAK");

                                var number_sublist3 = Console.ReadLine();

                                if (int.TryParse(number_sublist3, out n3) && n < 9 && n >= 0)
                                {
                                    switch (n3)
                                    {
                                        case 7:
                                            Console.WriteLine("7");
                                            break;
                                        case 8:
                                            Console.WriteLine("8");
                                            break;
                                        default:
                                            n3 = 0;
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Try once more...");
                                }
                            } while (n3 != 0);
                            break;
                        default:
                            n = 0;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Try once more...");
                }

                Console.WriteLine();

            } while (n != 0);
        }
    }
}