using System;

namespace Task_1.Tasks.Language
{
    public class Array_proccesing
    {

        private static void ArrayMain()
        {
            Array_proccesing array_Proccesing = new Array_proccesing();

            Random rndArray = new Random();

            int elements = rndArray.Next(10, 25);

            Console.WriteLine($"Array size: {elements}");

            int[] array = new int[elements];

            array_Proccesing.ArrayRand(array, elements);

            array_Proccesing.BubbleSort(array, elements);
            Console.WriteLine();

            array_Proccesing.Print_Array(array, elements);
            Console.WriteLine();
        }

        private void ArrayRand(int[] items, int elements)
        {
            Random rnd = new Random();

            Console.Write("Random array: ");
            Console.Write("{ ");
            for (int i = 0; i < elements; i++)
            {
                items[i] = rnd.Next(0, 100);
                Console.Write(items[i]);
                Console.Write(",");
            }
            Console.Write("}");
        }

        private void BubbleSort(int[] items, int elements)
        {
            int temp;

            for (int i = 0; i < elements - 1; i++)
            {
                for (int j = i + 1; j < elements; j++)
                {
                    if (items[i] > items[j])
                    {
                        temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        private void Print_Array(int[] items, int elements)
        {
            int max = 0;

            Console.Write("Sort array: ");
            Console.Write("{ ");
            for (int i = 0; i < elements; i++)
            {
                Console.Write(items[i]);
                Console.Write(",");
                if (i == elements - 1)
                {
                    max = items[i];
                }

            }
            Console.Write("}\n");
            Console.WriteLine($"Min: {items[0]}");
            Console.WriteLine($"Max: {max}");
        }

        public static void array_proccesing()
        {

            ArrayMain();

        }
    }
}
