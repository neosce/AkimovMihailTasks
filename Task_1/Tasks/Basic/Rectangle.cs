using System;

namespace Task_1.Tasks
{
    public class Rectangle
    {

        private int rectangle(int a, int b)
        {
            return a * b;
        }

        public static void RectangleMain()
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("RECTANGLE:\n" + "Input side A:");

            // side of the rectangle
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input side B:");
            var b = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("A and B > 0");
            }
            else
            {
                Console.WriteLine("Square = " + rectangle.rectangle(a, b));
            }
        }
    }
}
