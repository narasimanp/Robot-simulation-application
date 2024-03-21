using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public class MoveCommand : ICommand
    {
        private readonly IRobot _robot;

        public MoveCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.Move();
        }
    }

}
