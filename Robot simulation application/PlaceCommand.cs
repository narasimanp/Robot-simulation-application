using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public class PlaceCommand : ICommand
    {
        private readonly IRobot _robot;
        private readonly int _x;
        private readonly int _y;
        private readonly Direction _direction;

        public PlaceCommand(IRobot robot, int x, int y, Direction direction)
        {
            _robot = robot;
            _x = x;
            _y = y;
            _direction = direction;
        }

        public void Execute()
        {
            _robot.Place(_x, _y, _direction);
        }
    }

}
