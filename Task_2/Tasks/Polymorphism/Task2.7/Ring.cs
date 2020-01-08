using System;

namespace Task_2.Tasks.Polymorphism.Task2._7
{
    public class Ring : Shape
    {

        private double radius;
        private double innerRadius;

        public Ring(double radius, double innerRadius) : base("Ring")
        {
            this.radius = radius;
            this.innerRadius = innerRadius;
        }

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

        public override void Draw(double x, double y)
        {
            Console.WriteLine($"Draw: ({x}, {y})");
        }

        public override void Area()
        {
            base.Area();

            Console.WriteLine($"Area ring: {Math.PI * (radius * radius - innerRadius * innerRadius)}");
        }

    }
}
