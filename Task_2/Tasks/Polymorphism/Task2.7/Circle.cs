using System;

namespace Task_2.Tasks.Polymorphism.Task2._7
{
    public class Circle : Shape
    {

        private double radius;
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

        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }

        public override void Draw(double x, double y)
        {
            Console.WriteLine($"Draw: ({x}, {y})");
        }

        public override void Area()
        {
            base.Area();

            Console.WriteLine($"Area circle: {Math.PI * radius * radius}");
        }

    }
}
