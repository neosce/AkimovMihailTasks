using System;
using Task_5.Controller;

namespace Task_5
{
    // This module View
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            
            // Сolors are inverted if users use othrer colors
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello it's BackUp System!");
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                Console.WriteLine("Select operating mode: \n1 - Watch\n2 - BackUp\n0 - Exit");

                var number_list = Console.ReadLine();
                
                if (int.TryParse(number_list, out n) && n < 3 && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Start tracking".ToUpper());

                            TrackingController trackingController = new TrackingController();
                            TimeController timeController = new TimeController();
                            
                            timeController.RecordTime();
                            trackingController.StartTracking();

                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case 2:
                            BackUpController backUpController = new BackUpController();
                            backUpController.FindToLog();
                            break;
                        default:
                            n = 0;
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Try once more...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    n = -1;
                }

            } while (n != 0);

        }
    }
}
