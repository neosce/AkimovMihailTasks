using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class NPC :Bonus ,IUnit
    {

        public int HealthNPC { get; set; }

        public int Damage(int damage)
        {
            if (damage > HealthNPC)
            {
                return HealthNPC = 0;
            }
            else
            {
                return HealthNPC - damage;
            }
        }

        public int Health(int health)
        {
            return HealthNPC = health;
        }

        public int Move(int speed)
        {
            return speed;
        }

        public int Point(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void AlgorithmPath()
        {
            Console.WriteLine("Ищу игрока, и хожу мимо препяствий");
        }

        public override void Apple(int x, int y)
        {
            base.Apple(x, y);
            HealthNPC += 10;
        }
    }
}
