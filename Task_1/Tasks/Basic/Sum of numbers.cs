using System;

namespace Task_1.Tasks.Basic
{
    public class Sum_of_numbers
    {

        private void SumOfNumberInput()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 | i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum 1000: " + sum);
        }

        public static void sum_Of_Numbers()
        {

            Sum_of_numbers sum_Of_Numbers = new Sum_of_numbers();

            sum_Of_Numbers.SumOfNumberInput();

            Console.WriteLine();
        }
    }
}