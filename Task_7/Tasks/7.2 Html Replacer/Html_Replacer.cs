using System;
using System.Text.RegularExpressions;

namespace Task_7.Tasks._7._2_Html_Replacer
{
    internal class Html_Replacer
    {

        public static void StartHtml()
        {

            Regex regex = new Regex(@"<[^<>]+>");

            string text = "<b>This</b>text<i>with</i><font color=\"red\">HTML</font>codes";

            text = regex.Replace(text, "_");

            Console.WriteLine($"Result: {text}");

        }

    }
}
