
namespace MarsRover.Commands
{
    public abstract class MoveCommand : ICommand
    {
        protected readonly IPosition _position;
        public MoveCommand(IPosition position)
        {
            _position = position;
        }

        public abstract void Execute();

    }
}

