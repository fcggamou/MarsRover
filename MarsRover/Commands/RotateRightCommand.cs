
namespace MarsRover.Commands
{
    public abstract class RotateRightCommand : MoveCommand
    {
        public RotateRightCommand(IPosition position) : base(position) { }
        public override void Execute()
        {
            _position.RotateRight();
        }

    }
}

