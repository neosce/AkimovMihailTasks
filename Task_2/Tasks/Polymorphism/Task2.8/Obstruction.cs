using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Obstruction: Map
    {

        string[] obstructionArray = new string[10];
        
        private int width;
        private int height;
        
        public Obstruction(int width, int height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }

        public void GenerateObstructionMap(int width, int height)
        {
            // Сами препятствия будут находится в массиве obstructionArray
            Console.WriteLine("Генерирует на карте зная ее размеры препятствия");
        }

    }
}
