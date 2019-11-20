using System;

namespace Task_1.Tasks.Basic
{

    public class Triangle
    {

        private void triangleInput(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void triangle()
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("RECTANGLE:\n" + "Input N:");

            var n = int.Parse(Console.ReadLine());

            triangle.triangleInput(n);
        }
    }
}
