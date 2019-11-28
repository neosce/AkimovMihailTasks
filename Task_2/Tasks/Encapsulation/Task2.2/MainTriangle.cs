using System;

namespace Task_2.Tasks.Encapsulation.Task2._2
{
    public class MainTriangle
    {

        public static void mainTriangle()
        {

            Console.WriteLine("Triangle:");
            try
            {

                Console.Write("Input A: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("\nInput B: ");
                var b = double.Parse(Console.ReadLine());
                Console.Write("\nInput C: ");
                var c = double.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(a, b, c);

                Console.WriteLine($"Perimetr: {triangle.Perimeter()}");
                Console.WriteLine($"Square: {triangle.Square()}");
                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }
        }

    }
}
