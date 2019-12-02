using System;

namespace Task_2.Tasks.Polymorphism.Task2._7
{
    public class Rectangle : Shape
    {

        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height) : base("rectangle")
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(double x, double y)
        {
            Console.WriteLine($"Draw: ({x}, {y})");
        }

        public override void Area()
        {
            base.Area();

            if (width == height)
            {
                Console.WriteLine($"Area square: {width * width}");
            }
            else
            {
                Console.WriteLine($"Area rectangle: {width * height}");
            }
        }

        public override void Rotatate(double rot)
        {
            base.Rotatate(rot);
        }
    }
}
