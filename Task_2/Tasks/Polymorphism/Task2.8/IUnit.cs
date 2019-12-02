namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public interface IUnit
    {

        int Move(int speed);
        int Damage(int damage);
        int Health(int health);
        /// <summary>
        /// Положение на карте
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int Point(int x, int y); 

    }
}
