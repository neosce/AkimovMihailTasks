using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class NPC: Unit
    {

        public NPC(int healthNPC)
        {
            HealthNPC = healthNPC;
        }

        public int HealthNPC { get; set; }

        public void AlgorithmPath()
        {
            Console.WriteLine("Ищу игрока, и хожу мимо препяствий");
        }

        public override int Move(int speed)
        {
            throw new NotImplementedException();
        }

        public override void Point(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override int Damage(int damage)
        {
            return base.Damage(HealthNPC - damage);
        }

    }
}
