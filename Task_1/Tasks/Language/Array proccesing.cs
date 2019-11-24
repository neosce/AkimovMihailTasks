using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Tasks.Language
{
    public class Array_proccesing
    {

        private static void ArrayMain()
        {
            Random rndArray = new Random();

            int elemets = rndArray.Next(10, 25);

            Console.WriteLine($"Array size: {elemets}");

            int[] array = new int[elemets];

            Array_proccesing array_Proccesing = new Array_proccesing();

            array_Proccesing.ArrayRand(array);

            array_Proccesing.BubbleSort(array);
            Console.WriteLine();

            array_Proccesing.Print_Array(array);
            Console.WriteLine();
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

        private void BubbleSort(int[] items)
        {
            int temp;

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
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

        private void Print_Array(int[] items)
        {
            int max = 0;

            Console.Write("Sort array: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(",");
                if (i == items.Length - 1)
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
