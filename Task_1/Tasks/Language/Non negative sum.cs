using System;

namespace Task_1.Tasks.Language
{
    public class Non_negative_sum
    {

        public static void non_negative_sum()
        {
            ArrayMain();
        }

        private static void ArrayMain()
        {
            Non_negative_sum non_Negative_Sum = new Non_negative_sum();

            Random rndArray = new Random();

            int elements = rndArray.Next(10, 25);

            Console.WriteLine($"Array size: {elements}");

            int[] array = new int[elements];

            non_Negative_Sum.ArrayRand(array, elements);

            non_Negative_Sum.Print_Array(array, elements);
            Console.WriteLine();
        }

        private void ArrayRand(int[] items, int elements)
        {
            Random rnd = new Random();

            Console.Write("Random array: ");
            Console.Write("{ ");
            for (int i = 0; i < elements; i++)
            {
                items[i] = rnd.Next(-100, 100);
                Console.Write(items[i]);
                Console.Write(",");
            }
            Console.Write("}\n");
        }

        private void Print_Array(int[] items, int elements)
        {
            int max = 0;

            for (int i = 0; i < elements; i++)
            {
                if (items[i] > 0)
                {
                    max += items[i];
                }
            }
            Console.WriteLine($"Sum: {max}");
        }

    }
}
