using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Tasks.Polymorphism.Task2._8
{
    public interface IObstruction
    {

        int PointOnMapX(int Height);
        int PointOnMapY(int Width);
        void SizeObstruction();

    }
}
