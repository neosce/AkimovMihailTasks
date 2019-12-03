using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Player : Unit
    {

        public int HealthPlayer { get; set; }

        public Player(int healthPlayer)
        {
            HealthPlayer = healthPlayer;
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
            return base.Damage(HealthPlayer - damage);
        }

    }
}
