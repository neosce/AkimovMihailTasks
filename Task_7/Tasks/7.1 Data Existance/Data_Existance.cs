using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_7.Tasks._7._1_Data_Existance
{
    internal class Data_Existance
    {

        public static void StartRegex()
        {
            //[0-3][0-9]-[0|1][0-9]-(19|20)[0-9]{2}
            Regex regex = new Regex(@"[0-3][0-9]-[0|1][0-9]-[0-9]{3,}");

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
