using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public class LeftCommand : ICommand
    {
        private readonly IRobot _robot;

        public LeftCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.TurnLeft();
        }
    }

}
