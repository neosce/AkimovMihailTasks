namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Cherry : IBonus
    {
        public int Health { get; set; }
        public int AddBoostSpeed { get; set; }

        public void AddHealth()
        {
            Health += 5;
        }

        public void Armor() {}

        public void BoostJump() { }

        public void BoostSpeed()
        {
            AddBoostSpeed += 10;
        }

        public int PointOnMapX(int Height)
        {
            return Height;
        }

        public int PointOnMapY(int Width)
        {
            return Width;
        }
    }
}
