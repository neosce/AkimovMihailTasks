namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public class Apple : IBonus
    {
        public int AddArmor { get; set; }
        public int Jump { get; set; }

        public void AddHealth() { }

        public void Armor()
        {
            AddArmor += 10;
        }

        public void BoostJump()
        {
            Jump += 5;
        }

        public void BoostSpeed() { }

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
