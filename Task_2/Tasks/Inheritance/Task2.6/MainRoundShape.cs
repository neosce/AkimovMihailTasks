using System;

namespace Task_2.Tasks.Inheritance.Task2._6
{
    public class MainRoundShape
    {
        public static void mainRoundShape()
        {

            Console.WriteLine("Round:");
            
            try
            {

                Console.Write("Input X: ");
                var x = double.Parse(Console.ReadLine());
                Console.Write("\nInput Y: ");
                var y = double.Parse(Console.ReadLine());
                Console.Write("\nInput Radius: ");
                var radius = double.Parse(Console.ReadLine());
                Console.Write("\nInput Inner Radius: ");
                var innerRadius = double.Parse(Console.ReadLine());

                Ring ring = new Ring(x, y, radius, innerRadius);

                Console.WriteLine($"GetSquare: {ring.GetSquare()}");
                Console.WriteLine($"GetSumLength: {ring.GetSumLength()}");

                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }

        }
    }
}
