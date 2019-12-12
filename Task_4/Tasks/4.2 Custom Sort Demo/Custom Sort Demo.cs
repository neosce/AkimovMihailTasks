using System;

namespace Task_4.Tasks._4._2_Custom_Sort_Demo
{
    public delegate void Swap(string[] item, int i, int j);
    public delegate bool Alphabet(string s1, string s2);
    public delegate bool ActionFunc(int i, int j);

    public class Custom_Sort_Demo
    {
        private readonly Func<int, int, bool> compare = delegate (int i, int j)
        {
            return i > j;
        };
        private readonly Func<int, int, bool> equals = delegate (int i, int j)
        {
            return i == j;
        };

        private static void SwapArray(string[] items, int i, int j)
        {
            string temp;
            temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        private static bool AlphabetArray(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i])
                {
                    return true;
                }
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i])
                {
                    return false;
                }
            }
            return false;
        }

        private void BubbleSort(string[] items)
        {
            Swap swap = new Swap(SwapArray);
            Alphabet alphabet = new Alphabet(AlphabetArray);
            ActionFunc actionCompare = new ActionFunc(compare);
            ActionFunc actionEquals = new ActionFunc(equals);

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (actionCompare(items[i].Length, items[j].Length) )
                    {
                        swap(items, i, j);
                    } 
                    else if(actionEquals(items[i].Length, items[j].Length) && alphabet(items[i], items[j]))
                    {
                        swap(items, i, j);
                    }
                }
            }
        }

        public static void CustomSortDemoMain()
        {
            Console.WriteLine("Custom Sort Demo".ToUpper());

            Random rndArray = new Random();
            int elements = rndArray.Next(10, 25);
            Console.WriteLine($"Array size: {elements}");
            string[] array = new string[elements];

            Methods.RandomWords randomWords = new Methods.RandomWords();
            randomWords.ArrayRand(array);

            Custom_Sort_Demo custom_Sort_Demo = new Custom_Sort_Demo();
            custom_Sort_Demo.BubbleSort(array);

            Methods.PrintArray<string> printArray = new Methods.PrintArray<string>();
            printArray.Print_Array(array, "Sort string");

            Console.WriteLine();
        }

    }
}
