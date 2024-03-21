using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public class ReportCommand : ICommand
    {
        private readonly IRobot _robot;

        public ReportCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            Console.WriteLine($"Output: {_robot.Report()}");
        }
    }

}
