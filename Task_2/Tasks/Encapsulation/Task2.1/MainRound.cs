using System;

namespace Task_2.Tasks.Encapsulation.Task2._1
{
    public class MainRound
    {

        public static void mainRound()
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

                Round round = new Round(x, y, radius);

                Console.WriteLine($"Circumference: {round.Circumference()}");

                Console.WriteLine($"Square: {round.Square()}");
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }
            
        }
    }
}
