using System;
using System.Collections.Generic;

namespace Task_3.Tasks.Word_Frequency
{
    public class Algorithm_Word_Frequency
    {
        public static void AlgorithmWordF(string text)
        {
            List<string> list = new List<string>();
            string strNew = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != ',' && text[i] != '.')
                {
                    strNew += text[i];
                }
                else if (strNew != "")
                {
                    list.Add(strNew.ToLower());
                    strNew = "";
                }
            }

            PrintList(list);

            AlgorithmWF(list);

        }

        private static void PrintList(List<string> list)
        {
            Console.Write("List: [");
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("]");
            Console.WriteLine();
        }

        private static void AlgorithmWF(List<string> list)
        {
            string WordSearch = "";
            string PrevSearch = "";
            int cout = 1;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j] && i != j)
                    {
                        WordSearch = list[i];
                        cout++;
                    }
                    else if (PrevSearch == WordSearch)
                    {
                        cout = 1;
                    }
                }
                if (cout > 1 && PrevSearch != WordSearch)
                {
                    PrevSearch = WordSearch;
                    Console.WriteLine($"{WordSearch}: {cout}");
                    cout = 1;
                }
            }
        }

    }
}
