namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public interface IBonus
    {

        int PointOnMapX(int Height);
        int PointOnMapY(int Width);
        void AddHealth();
        void Armor();
        void BoostSpeed();
        void BoostJump();

    }
}
