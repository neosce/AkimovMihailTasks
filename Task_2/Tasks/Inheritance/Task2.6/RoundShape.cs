using System;

namespace Task_2.Tasks.Inheritance.Task2._6
{
    public class RoundShape
    {

        private double radius;
        private double innerRadius;

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
        
        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                if (value > 0 && value < radius)
                {
                    innerRadius = value;
                }
                else
                {
                    Console.WriteLine($"Radius is incorrect, inner Radius > 0 and < Radius your: {value}. \ninner Radius is set 0.5");
                    innerRadius = 0.5;
                }
            }
        }

    }
}
