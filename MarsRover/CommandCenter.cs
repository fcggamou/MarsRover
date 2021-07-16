using MarsRover.Commands;

namespace MarsRover
{
    public class CommandCenter
    {
        private readonly IRover _rover;
        private readonly ISurface _surface;

        public CommandCenter(IRover rover, ISurface surface)
        {
            _rover = rover;
            _surface = surface;
        }

        public void ProcessCommands(string commands)
        {
            foreach (char c in commands)
            {
                ProcessCommand(c);
            }
        }

        public void ProcessCommand(char command)
        {
            IMoveCommand moveCommand = CommandFactory.GetCommand(command);
            _rover.Move(moveCommand);
        }

        public bool IsRoverInsideSurfaceBounds
        {
            get
            {
                return _rover.CurrentPosition.X <= _surface.Width
                    && _rover.CurrentPosition.X >= 0
                    && _rover.CurrentPosition.Y >= 0
                    && _rover.CurrentPosition.Y <= _surface.Length;
            }
        }

        public IPosition RoverCurrentPosition
        {
            get
            {
                return _rover.CurrentPosition;
            }
        }

    }
}
