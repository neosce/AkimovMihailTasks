using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_7.Tasks._7._5_Time_Counter
{
    internal class Time_Counter
    {

        public static void StartTime()
        {

            Regex regex = new Regex(@"(\b[0-1][0-9]|[2][0-3]):([0-5][0-9]\b)");
            string textExapmle = "02:04 | 16:56 | 23:59 | 02:00PM | PM2:00 | 22:77 | 00:00 | 24:00 | 77:30";

            var result = regex.Matches(textExapmle);

            Console.WriteLine($"Time is present in the text: {result.Count} once");
            
        }

    }
}
