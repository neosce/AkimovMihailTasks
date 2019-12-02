using System;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Player : Bonus, IUnit
    {
        public int HealthPlayer { get; set; }
        public int Damage(int damage)
        {
            if (damage > HealthPlayer)
            {
                return HealthPlayer = 0;
            }
            else
            {
                return HealthPlayer - damage;
            }
        }

        public int Health(int health)
        {
            return HealthPlayer = health;
        }

        public int Move(int speed)
        {
            return speed;
        }

        public int Point(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Apple(int x, int y)
        {
            base.Apple(x, y);
            HealthPlayer += 5;
        }

    }
}
