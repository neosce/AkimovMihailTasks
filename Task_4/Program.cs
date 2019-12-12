using System;
using Task_4.Tasks._4._1_Custom_Sort;
using Task_4.Tasks._4._2_Custom_Sort_Demo;
using Task_4.Tasks._4._3_Sorting_Unit;
using Task_4.Tasks._4._4_Number_Array_Sum;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Task_4\n" + "The task corresponds to the number in the list:");

            do
            {
                Console.WriteLine("1 - CUSTOM SORT\n" + "2 - CUSTOM SORT DEMO\n" + "3 - SORTING UNIT\n" + "4 - NUMBER ARRAY SUM\n" + "5 - TO INT OR NOT TO INT?\n" + "6 - I SEEK YOU*\n" + "0 - EXIT\n");

                var number_list = Console.ReadLine();

                if (int.TryParse(number_list, out n) && n < 7 && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                            Custom_Sort.CustomSortMain();
                            break;
                        case 2:
                            Custom_Sort_Demo.CustomSortDemoMain();
                            break;
                        case 3:
                            Sorting_Unit.SortingUnitMain();
                            break;
                        case 4:
                            NumberArraySum.NumberArraySumMain();
                            break;
                        case 5:
                            Console.WriteLine("");
                            break;
                        case 6:
                            Console.WriteLine("");
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