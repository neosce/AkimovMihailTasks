using System;

namespace Task_2.Tasks.Encapsulation.Task2._4
{
    public class MyString
    {

        public void Concatenation(string str1, string str2)
        {
            Console.WriteLine(string.Concat(str1, str2)); // через "+" слишком изи
        }

        public void Comparison(string str1, string str2)
        {
            int result = string.Compare(str1, str2);
            if (result < 0)
            {
                Console.WriteLine("string 1 > string 2");
            }
            else if (result > 0)
            {
                Console.WriteLine("string 1 < string 2");
            }
            else
            {
                Console.WriteLine("string 1 = string 2");
            }
        }

        public void SearchString(string str1, char c)
        {

            int indexOfChar = str1.IndexOf(c);
            Console.WriteLine("Number in string: " + indexOfChar);

        }

        public void SearchSubstring(string str1, string str2)
        {
            int indexOfSubstring = str1.IndexOf(str2);
            Console.WriteLine("Number in substring: " + indexOfSubstring);
        }

        public void ConvertInArray(string str)
        {

            char[] item = new char[str.Length];

            Console.WriteLine("Array char: ");
            Console.Write("[");
            for (int i = 0; i < str.Length; i++)
            {
                item[i] += str[i];
                Console.Write($"{item[i]}, ");
            }
            Console.Write("]");
            Console.WriteLine();

        }

    }
}
