using System;

namespace Task_1.Tasks.Language
{
    public class _2D_Array
    {

        private static void ArrayMain()
        {
            int[,] array2d = new int[3,3];

            _2D_Array _Array = new _2D_Array();

            _Array.ArrayRand(array2d);

            _Array.PrintArray(array2d);
            Console.WriteLine();
        }

        private void ArrayRand(int[,] items)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < items.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    items[i, j] = rnd.Next(0,100);
                    Console.Write($"{items[i,j]},");
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }

        private void PrintArray(int[,] items)
        {
            int sum = 0;

            Console.WriteLine("Even positions: ");
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    if (((i + j) % 2) == 0 )
                    {
                        Console.Write($"[{i},{j}] = {items[i,j]}, ");
                        sum += items[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum: {sum}");
        }

        public static void _2dArray()
        {

            ArrayMain();

        }
    }
}
