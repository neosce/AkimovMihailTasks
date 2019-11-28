using System;

namespace Task_2.Tasks.Encapsulation.Task2._2
{
    public class Triangle
    {

        private double a;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    Console.WriteLine($"A is incorrect, A > 0 your: {value}. \nA is set 1");
                    a = 1;
                }
            }
        }

        private double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine($"B is incorrect, B > 0 your: {value}. \nB is set 1");
                    b = 1;
                }
            }
        }

        private double c;
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    Console.WriteLine($"C is incorrect, C > 0 your: {value}. \nC is set 1");
                    c = 1;
                }
            }
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Square()
        {
            double p = 0.5*(a + b + c);
            return 0.5 * a * ( (2*Math.Sqrt(p*(p - a) * (p - b) * (p - c)))/a );
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
