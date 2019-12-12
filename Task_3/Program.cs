using System;
using Task_3.Tasks.Dynamic_Array;
using Task_3.Tasks.Lost;
using Task_3.Tasks.Word_Frequency;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

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
                            MainWordFrequency.MainWFrequency();
                            break;
                        case 3:
                            MainArray.DynamicArrayTest();
                            break;
                        default:
                            n = 0;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Try once more...");
                    n = -1;
                }

                Console.WriteLine();

            } while (n != 0);
        }
    }
}