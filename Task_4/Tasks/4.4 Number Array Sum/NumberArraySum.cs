using System;

namespace Task_4.Tasks._4._4_Number_Array_Sum
{
    public class NumberArraySum
    {

        public static void NumberArraySumMain()
        {
            Console.WriteLine("Number Array Sum".ToUpper());

            Random rndArray = new Random();
            int elements = rndArray.Next(10, 25);
            Console.WriteLine($"Array size: {elements}");
            int[] array = new int[elements];

            Methods.Array_Random array_Random = new Methods.Array_Random();
            array_Random.ArrayRand(array);

            Console.WriteLine($"\nSum array: {array.IsSum()}");
            Console.WriteLine();
        }

    }
}
