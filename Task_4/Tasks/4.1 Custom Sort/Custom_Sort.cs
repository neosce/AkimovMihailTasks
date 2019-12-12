using System;

namespace Task_4.Tasks._4._1_Custom_Sort
{
    public delegate void Swap(int[] items, int i, int j);

    public class Custom_Sort
    {
        private static void SwapArray(int[] items, int i, int j)
        {
            int temp;
            temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        private void BubbleSort(int[] items)
        {
            Swap swap = new Swap(SwapArray);

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] > items[j])
                    {
                        swap(items, i, j);
                    }
                }
            }
        }

        private void ArrayRand(int[] items)
        {
            Random rnd = new Random();

            Console.Write("Random array: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = rnd.Next(0, 100);
                Console.Write(items[i]);
                Console.Write(",");
            }
            Console.Write("}");
        }

        private void Print_Array(int[] items)
        {

            Console.Write("\nSort array: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(",");
            }
            Console.Write("}\n");
        }

        public static void CustomSortMain()
        {
            Console.WriteLine("Custom Sotr".ToUpper());

            Custom_Sort custom_Sort = new Custom_Sort();
            Random rndArray = new Random();

            int elements = rndArray.Next(10, 25);
            Console.WriteLine($"Array size: {elements}");

            int[] array = new int[elements];

            custom_Sort.ArrayRand(array);
            custom_Sort.BubbleSort(array);
            custom_Sort.Print_Array(array);

            Console.WriteLine();
        }

    }
}
