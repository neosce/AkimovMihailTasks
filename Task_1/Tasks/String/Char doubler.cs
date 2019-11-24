using System;

namespace Task_1.Tasks.String
{
    public class Char_doubler
    {

        private static void doubler(string str1, string str2)
        {
            string strNew = "";

            for (int i = 0; i < str1.Length; i++)
            {
                strNew += str1[i];
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        strNew += str1[i];
                    }
                }
            }

            Console.WriteLine($"Result string: {strNew}");
        }

        public static void char_doubler()
        {
            Console.WriteLine("Input one string: ");
            var str1 = Console.ReadLine();

            Console.WriteLine("Input two string: ");
            var str2 = Console.ReadLine();

            doubler(str1, str2);

            Console.WriteLine();
        }
    }
}
