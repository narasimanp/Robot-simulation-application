using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public class CommandProcessor
    {
        private readonly ICommand[] _commands;

        public CommandProcessor(ICommand[] commands)
        {
            _commands = commands;
        }

        public void ProcessCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }

}
