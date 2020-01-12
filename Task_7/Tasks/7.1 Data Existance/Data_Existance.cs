using System;
using System.Text.RegularExpressions;

namespace Task_7.Tasks._7._1_Data_Existance
{
    internal class Data_Existance
    {

        public static void StartRegex()
        {
            //[0-3][0-9]-[0|1][0-9]-(19|20)[0-9]{2}
            Regex regex = new Regex(@"[0-3][0-9]-[0|1][0-9]-[0-9]{3,}");
            string textExapmle = "The Russian Federation arose 25-12-1991";

            Console.WriteLine($"Example: {textExapmle}, Regex: {regex.IsMatch(textExapmle)}");

            Console.WriteLine("Enter text with data format dd-mm-yyyy: ");
            var text = Console.ReadLine();

            if (regex.IsMatch(text))
            {
                Console.WriteLine($"The {text} contains the date!");
            }
            else
            {
                Console.WriteLine($" The {text} does not contain a date!");
            }

        }

    }
}
