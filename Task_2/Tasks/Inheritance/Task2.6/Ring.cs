using System;

namespace Task_2.Tasks.Inheritance.Task2._6
{
    public class Ring: RoundShape
    {

        public Ring(double x, double y, double radius, double innerRadius)
        {
            X = x;
            Y = y;
            Radius = radius;
            InnerRadius = innerRadius;
        }

        public double GetSquare()
        {
            return Math.PI * (Radius * Radius - InnerRadius * InnerRadius);
        }

        public double GetSumLength()
        {
            return (Math.PI * (Radius + Radius)) + (Math.PI * (InnerRadius + InnerRadius));
        }

    }
}