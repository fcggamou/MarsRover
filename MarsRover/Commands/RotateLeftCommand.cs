
namespace MarsRover.Commands
{
    public class RotateLeftCommand : MoveCommand
    {
        public RotateLeftCommand(IPosition position) : base(position) { }
        public override void Execute()
        {
            _position.RotateLeft();
        }

    }
}

