using System;
using System.Text.RegularExpressions;

namespace Task_7.Tasks._7._4_Number_Validator
{
    internal class Number_Validator
    {

        // all number (simple and scientific) ^[+-]?\d+(?:\.\d*(?:[eE][+-]?\d+)?)?$
        private Regex regexSimple = new Regex(@"(^[0-9+-]+$)|(^[0-9+-]*[.,][0-9]+$)", RegexOptions.Multiline);
        private Regex regexScientific = new Regex(@"[1-9]\d*(?:\.\d{1,2})(?:e[+-]?\d+)?");

        public static void StartNumber()
        {
            Number_Validator number_Validator = new Number_Validator();

            Console.Write("\nEnter number: ");
            var text = Console.ReadLine();
            Console.WriteLine(number_Validator.RegexNumber(text));
        }

        private string RegexNumber(string text)
        {
            if (regexSimple.IsMatch(text))
            {
                return $"This {text} number is in normal notation.";
            }
            else if (regexScientific.IsMatch(text))
            {
                return $"This {text} number is in scientific notation.";
            }
            return $"This {text} not number!";
        }

    }
}
