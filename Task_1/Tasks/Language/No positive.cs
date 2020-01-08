using System;

namespace Task_1.Tasks.Language
{
    public class No_positive
    {

        public static void no_positive()
        {
            ArrayMain();
        }

        private static void ArrayMain()
        {
            int[,,] arraythree = new int[3, 3, 3];

            No_positive no_Positive = new No_positive();

            no_Positive.ArrayRand(arraythree);

            no_Positive.ArrayPrint(arraythree);
            Console.WriteLine();
        }

        private void ArrayRand(int[,,] items)
        {
            Random rnd = new Random();

            Console.Write("Array three random:\n");
            
            for (int i = 0; i < items.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < items.GetLength(2); k++)
                    {
                        items[i,j,k] = rnd.Next(-100, 100);
                        Console.Write($"{ items[i, j, k]},");
                    }
                    Console.Write("}, ");
                }
                Console.WriteLine("}, ");
            }
        }

        private void ArrayPrint(int[,,] items)
        {
            Console.Write("Array three no positive:\n");
            
            for (int i = 0; i < items.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < items.GetLength(2); k++)
                    {
                        if (items[i,j,k] > 0)
                        {
                            items[i, j, k] = 0;
                        }
                        Console.Write($"{items[i, j, k]},");
                    }
                    Console.Write("}, ");
                }
                Console.WriteLine("}, ");
            }
        }

    }
}
