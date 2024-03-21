using Robot_simulation_application;
using System;

class Program
{
    static void Main(string[] args)
    {
        ICommand[] commands =
        {

          new PlaceCommand(new ToyRobot(), 0, 0, Direction.NORTH), 
            new MoveCommand(new ToyRobot()),
            new ReportCommand(new ToyRobot()) // Output: 0,1,NORTH
        };

        ICommand[] commands2 =
        {
            new PlaceCommand(new ToyRobot(), 0, 0, Direction.NORTH),
            new LeftCommand(new ToyRobot()),
            new ReportCommand(new ToyRobot()) // Output: 0,0,WEST
        };

        CommandProcessor processor = new CommandProcessor(commands);
        processor.ProcessCommands();

        processor = new CommandProcessor(commands2);
        processor.ProcessCommands();


        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
