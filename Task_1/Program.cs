﻿using System;
using Task_1.Tasks;
using Task_1.Tasks.Basic;
using Task_1.Tasks.Language;
using Task_1.Tasks.String;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, n1, n2, n3;

            Console.WriteLine("Task_1\n" + "The task corresponds to the number in the list:");

            do
            {
                Console.WriteLine("1 - C# BASIC\n" + "2 - C# LANGUAGE\n" + "3 - C# STRING\n" + "0 - EXIT\n");

                var number_list = Console.ReadLine();

                if (int.TryParse(number_list, out n) && n < 4 && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("C# BASIC:\n" + "1 - RECTANGLE" + "\n2 - TRIANGLE" + "\n3 - ANOTHER TRIANGLE" + "\n4 - X-MAS TREE" + "\n5 - SUM OF NUMBERS" + "\n6 - FONT ADJUSTMENT" + "\n0 - BREAK");
                                var number_sublist1 = Console.ReadLine();

                                if (int.TryParse(number_sublist1, out n1) && n < 7 && n >= 0)
                                {
                                    switch (n1)
                                    {
                                        case 1:
                                            Rectangle.RectangleMain();
                                            break;
                                        case 2:
                                            Triangle.triangle();
                                            break;
                                        case 3:
                                            Another_triangle.anothreTriangle();
                                            break;
                                        case 4:
                                            X_mass_tree.x_mass_tree();
                                            break;
                                        case 5:
                                            Sum_of_numbers.sum_Of_Numbers();
                                            break;
                                        case 6:
                                            Font_Adjustment.font_adjustment();
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
                                Console.WriteLine("C# LANGUAGE:\n" + "\n7 - ARRAY PROCCESING" + "\n8 - NO POSITIVE" + "\n9 - NON-NEGATIVE SUM" + "\n10 - 2D-ARRAY" + "\n0 - BREAK");
                                var number_sublist2 = Console.ReadLine();

                                if (int.TryParse(number_sublist2, out n2) && n < 11 && n >= 0)
                                {
                                    switch (n2)
                                    {
                                        case 7:
                                            Array_proccesing.array_proccesing();
                                            break;
                                        case 8:
                                            No_positive.no_positive();
                                            break;
                                        case 9:
                                            Non_negative_sum.non_negative_sum();
                                            break;
                                        case 10:
                                            _2D_Array._2dArray();
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
                                Console.WriteLine("C# STRING:\n" + "\n11 - AVERAGE STRING LENGTH" + "\n12 - CHAR DOUBLER" + "\n0 - BREAK");
                                
                                var number_sublist3 = Console.ReadLine();

                                if (int.TryParse(number_sublist3, out n3) && n < 13 && n >= 0)
                                {
                                    switch (n3)
                                    {
                                        case 11:
                                            Average_string_length.average_string_length();
                                            break;
                                        case 12:
                                            Char_doubler.char_doubler();
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
                    n = -1;
                }
                
                Console.WriteLine();

            } while (n != 0);
        }
    }
}
