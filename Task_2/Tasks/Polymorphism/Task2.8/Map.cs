using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Map
    {

        /// <summary>
        /// Задаем размер карты
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

    }
}
