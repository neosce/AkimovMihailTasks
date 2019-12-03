using System;
using Task_3.Tasks.Lost;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, n1, n2, n3;

            Console.WriteLine("Task_3\n" + "The task corresponds to the number in the list:");

            do
            {
                Console.WriteLine("1 - Lost\n" + "2 - Word Frequency\n" + "3 - Dynamic Array\n" + "0 - EXIT\n");

                var number_list = Console.ReadLine();

                if (int.TryParse(number_list, out n) && n < 4 && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                                MainLost.MLost();   
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
                                            Console.WriteLine("Empty2");
                                            break;
                                        case 6:
                                            Console.WriteLine("Empty2");
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
                                            Console.WriteLine("Empty3");
                                            break;
                                        case 8:
                                            Console.WriteLine("Empty3");
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