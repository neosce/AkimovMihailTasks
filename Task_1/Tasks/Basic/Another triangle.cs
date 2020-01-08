using System;

namespace Task_1.Tasks.Basic
{
    public class Another_triangle
    {

        public static void anothreTriangle()
        {
            Another_triangle triangle = new Another_triangle();

            Console.WriteLine("Another triangle:\n" + "Input N:");

            var n = int.Parse(Console.ReadLine());

            triangle.anothreTriangleInput(n);
        }

        private void anothreTriangleInput(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j <= 2 * i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
    }
}
