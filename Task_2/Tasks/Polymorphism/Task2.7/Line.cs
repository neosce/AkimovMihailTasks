using System;

namespace Task_2.Tasks.Polymorphism.Task2._7
{
    public class Line : Shape
    {

        private readonly double length;

        public Line(double length) : base("Line")
        {
            this.length = length;
        }

        public override void Draw(double x, double y)
        {
            Console.WriteLine($"Draw: ({x}, {y})");
        }
    }
}
