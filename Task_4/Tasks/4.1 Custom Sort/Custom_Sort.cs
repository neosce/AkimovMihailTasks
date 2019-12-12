using System;

namespace Task_4.Tasks._4._1_Custom_Sort
{
    public delegate void Swap(int[] items, int i, int j);
    public delegate bool ActionFunc(int i, int j);

    public class Custom_Sort
    {
        private readonly Func<int, int, bool> compare = delegate (int i, int j)
        {
            return i > j;
        };

        private static void SwapArray(int[] items, int i, int j)
        {
            int temp;
            temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        private void BubbleSort(int[] items)
        {
            ActionFunc action = new ActionFunc(compare);
            Swap swap = new Swap(SwapArray);

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (action(items[i], items[j]))
                    {
                        swap(items, i, j);
                    }
                }
            }
        }

        public static void CustomSortMain()
        {
            Console.WriteLine("Custom Sotr".ToUpper());

            Custom_Sort custom_Sort = new Custom_Sort();
            Random rndArray = new Random();
            Methods.PrintArray<int> printArray = new Methods.PrintArray<int>();

            int elements = rndArray.Next(10, 25);
            Console.WriteLine($"Array size: {elements}");

            int[] array = new int[elements];

            Methods.Array_Random array_Random = new Methods.Array_Random();
            array_Random.ArrayRand(array);

            custom_Sort.BubbleSort(array);
            printArray.Print_Array(array, "Sort Array");

            Console.WriteLine();
        }

    }
}
