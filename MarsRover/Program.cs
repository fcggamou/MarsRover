using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Surface width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Surface length:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Rover initial position and orientation: (e.g. '5,2,W')");
            var position = Console.ReadLine().Split(",");
            int x = int.Parse(position[0]);
            int y = int.Parse(position[1]);
            Orientation o = (Orientation)Enum.Parse(typeof(Orientation), position[2]);           

            Console.WriteLine("Commands:");
            var commands = Console.ReadLine();

            CommandCenter c = new CommandCenter(new Rover(new Position(x, y, o)), new Surface(width, length));
            c.ProcessCommands(commands);

            Console.WriteLine($"{c.IsRoverInsideSurfaceBounds}, {c.RoverCurrentPosition.Orientation}, ({c.RoverCurrentPosition.X},{c.RoverCurrentPosition.Y})");
        }
    }
}
