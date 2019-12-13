using System;

namespace Task_4.Tasks.Methods
{
    public class Array_Random
    {
        public void ArrayRand(int[] items)
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

        public void ArrayRandNoPrint(int[] items)
        {
            Random rnd = new Random();

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = rnd.Next(-500, 500);
            }
        }

    }
}
