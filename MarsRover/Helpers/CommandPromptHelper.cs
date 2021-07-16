using System;

namespace MarsRover
{
    /// <summary>
    /// Provides helper methods for processing inputs from the command prompt.
    /// </summary>
    public static class CommandPromptHelper
    {
        /// <summary>
        /// Prompts the user for the information needed to create a new instance of <see cref="ICommandCenter"></see> and returns it.
        /// </summary>        
        public static ICommandCenter InitializeCommandCenterFromPrompt()
        {
            ISurface surface = CreateSurfaceFromPrompt();
            IRover rover = CreateRoverFromPrompt();
            return new CommandCenter(rover, surface);
        }

        /// <summary>
        /// Prompts the user for the commands and returns them.
        /// </summary>    
        public static string GetCommandsFromPrompt()
        {
            Console.WriteLine("Commands: (e.g. ARAAALA)");
            return Console.ReadLine();
        }

        private static ISurface CreateSurfaceFromPrompt()
        {
            string dimensionsInput = "";
            try
            {
                Console.WriteLine("Surface dimensions (width x length, e.g. \"5 x 5\"):");
                dimensionsInput = Console.ReadLine();

                string[] dimensions = dimensionsInput.Split("x");
                uint width = uint.Parse(dimensions[0]);
                uint length = uint.Parse(dimensions[1]);
                return new Surface(width, length);
            }
            catch
            {
                throw new InputException($"Invalid dimensions: \"{dimensionsInput}\".");
            }
        }

        private static IRover CreateRoverFromPrompt()
        {
            string roverPositionInput = "";
            try
            {
                Console.WriteLine("Rover initial position and orientation (e.g. \"2, 5, W\"):");
                roverPositionInput = Console.ReadLine();
                string[] position = roverPositionInput.Split(",");
                int x = int.Parse(position[0]);
                int y = int.Parse(position[1]);
                Orientation orientation = (Orientation)Enum.Parse(typeof(Orientation), position[2].ToUpper());
                return new Rover(new Position(x, y, orientation));
            }
            catch
            {
                throw new InputException($"Invalid initial position and orientation: \"{roverPositionInput}\".");
            }

        }
    }
}
