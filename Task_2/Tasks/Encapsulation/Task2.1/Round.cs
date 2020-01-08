using System;

namespace Task_2.Tasks.Encapsulation
{
    public class Round
    {

        private double radius;

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine($"Radius is incorrect, radius > 0 your: {value}. \nRadius is set 1");
                    radius = 1;
                }
            }
        }

        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double Square()
        {
            return Math.PI * radius * radius;
        }

    }
}