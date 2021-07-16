
namespace MarsRover.Commands
{
    public class MoveForwardCommand : MoveCommand
    {
        public MoveForwardCommand(IPosition position) : base(position) { }
        public override void Execute()
        {
            _position.MoveForward();
        }
    }
}

