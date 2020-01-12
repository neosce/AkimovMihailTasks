using System;
using Task_7.Tasks._7._1_Data_Existance;
using Task_7.Tasks._7._2_Html_Replacer;
using Task_7.Tasks._7._3_Email_Finder;
using Task_7.Tasks._7._4_Number_Validator;
using Task_7.Tasks._7._5_Time_Counter;

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
                            Html_Replacer.StartHtml();
                            break;

                        case 3:
                            Email_Finder.StartEmail();
                            break;

                        case 4:
                            Number_Validator.StartNumber();
                            break;

                        case 5:
                            Time_Counter.StartTime();
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
