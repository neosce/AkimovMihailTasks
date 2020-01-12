using System;
using Task_7.Tasks._7._1_Data_Existance;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Regex");
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                Console.WriteLine("Select tasks: \n1 - Data Existance\n2 - Html Replacer\n3 - Email Finder\n4 - Number Validator\n5 - Time Counter\n0 - Exit");
                var numberList = Console.ReadLine();

                if (int.TryParse(numberList, out n))
                {

                    switch (n)
                    {
                        case 1:
                            Data_Existance.StartRegex();
                            break;
                            
                        case 2:

                            break;

                        case 3:

                            break;

                        case 4:

                            break;

                        case 5:

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
