using System;

namespace Task_2.Tasks.Polymorphism.Task2._7
{
    public abstract class Shape
    {

        public Shape(string shapeName)
        {
            Console.WriteLine("Loading " + shapeName);
        }

        public abstract void Draw(double x, double y);

        public virtual void Rotatate(double rot)
        {
            if (rot == 360)
            {
                rot = 0;
            }
            Console.WriteLine($"Rotate = {rot}");
        }

        public virtual void Area()
        {
            Console.WriteLine("Area shape");
        }

    }
}
