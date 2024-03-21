using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public enum Direction
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public interface IRobot
    {
        void Place(int x, int y, Direction direction);
        void Move();
        void TurnLeft();
        void TurnRight();
        string Report();
    }
}
