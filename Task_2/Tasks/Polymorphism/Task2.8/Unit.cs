namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public abstract class Unit
    {
        public int HealthUnit { get; set; }
        public abstract int Move(int speed);
        public virtual int Damage(int damage)
        {
            if (damage > HealthUnit)
            {
                return HealthUnit = 0;
            }
            else
            {
                return HealthUnit - damage;
            }
        }
        public virtual int Health(int health)
        {
            return HealthUnit = health;
        }
        /// <summary>
        /// Положение на карте
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public abstract void Point(int x, int y);

    }
}
