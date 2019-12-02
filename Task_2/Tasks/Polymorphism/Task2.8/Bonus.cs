using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public abstract class Bonus
    {

        public virtual void Apple(int x, int y)
        {
            Console.WriteLine("+5 or +10(for NPC) Helth");
        }

        public virtual void Cherry(int x, int y)
        {
            Console.WriteLine("+10 Armor");
        }

    }
}
