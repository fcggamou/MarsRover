using MarsRover.Commands;

namespace MarsRover
{
    ///<inheritdoc cref="ICommandCenter"/>
    public class CommandCenter : ICommandCenter
    {
        private readonly IRover _rover;
        private readonly ISurface _surface;
        private bool _invalidCommandFound;

        /// <summary>
        /// Creates a new instance of <see cref="CommandCenter"/> with the given <see cref="IRover"/> and <see cref="ISurface"/>.
        /// </summary>
        public CommandCenter(IRover rover, ISurface surface)
        {
            _rover = rover;
            _surface = surface;
            CheckIfRoverIsInsideSurface();
        }

        public void ExecuteCommands(string commands)
        {
            foreach (char c in commands)
            {
                ProcessCommand(c);
            }
        }

        private void ProcessCommand(char command)
        {

            if (CommandFactory.TryGetCommand(command, out IMoveCommand moveCommand))
            {
                _rover.Move(moveCommand);
                CheckIfRoverIsInsideSurface();
            }
            else
                _invalidCommandFound = true;
        }

        private void CheckIfRoverIsInsideSurface()
        {
            if (!_surface.IsPointInside(_rover.CurrentPosition))
                _invalidCommandFound = true;
        }

        public string GetStatus()
        {
            return ($"{!_invalidCommandFound}, {_rover.CurrentPosition.Orientation}, ({_rover.CurrentPosition.X},{_rover.CurrentPosition.Y})");
        }

    }
}
