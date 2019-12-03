using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Tree : IObstruction
    {

        public int SizeTree { get; set; }

        public int PointOnMapX(int Height)
        {
            return Height;
        }

        public int PointOnMapY(int Width)
        {
            return Width;
        }

        public void SizeObstruction()
        {
            Console.WriteLine(SizeTree);
        }
    }
}
