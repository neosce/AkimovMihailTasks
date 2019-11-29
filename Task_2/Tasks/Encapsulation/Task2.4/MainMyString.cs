using System;

namespace Task_2.Tasks.Encapsulation.Task2._4
{
    public class MainMyString
    {

        public static void mainString()
        {

            Console.WriteLine("MyString:");

            try
            {

                MyString myString = new MyString();

                Console.Write("Input string 1: ");
                var str1 = Console.ReadLine();
                Console.Write("\nInput string 2: ");
                var str2 = Console.ReadLine();
                Console.Write("\nInput char for search string: ");
                var c = char.Parse(Console.ReadLine());
                Console.Write("\nInput string 3 for search substring: ");
                var str3 = Console.ReadLine();
                

                myString.ConvertInArray(str1);
                myString.Concatenation(str1, str2);
                myString.Comparison(str1, str2);
                myString.SearchString(str1, c);
                myString.SearchSubstring(str1, str3);

                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }

        }

    }
}
