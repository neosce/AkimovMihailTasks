using System;

namespace Task_1.Tasks.String
{
    public class Average_string_length
    {

        private static void MainString(string str)
        {
            char c;
            string strClean = "";
            int cout = 0;

            for (int i = 0; i < str.Length; i++)
            {
                c = str[i];

                if (char.IsLetter(c))
                {
                    cout++;
                    strClean += str[i];
                }
            }
            if (cout % 2 != 0)
            {
                cout++;
            }

            Console.WriteLine(cout/2);
            Console.WriteLine(strClean[strClean.Length / 2]);
        }

        public static void average_string_length()
        {

            Console.WriteLine("Input your string: ");
            var str = Console.ReadLine();

            MainString(str);

        }
    }
}
