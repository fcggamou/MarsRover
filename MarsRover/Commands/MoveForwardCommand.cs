
namespace MarsRover.Commands
{
    public class MoveForwardCommand : IMoveCommand
    {
        public IPosition Execute(IPosition currentPosition)
        {
            switch (currentPosition.Orientation)
            {
                case Orientation.N:
                    return new Position(currentPosition.X, currentPosition.Y + 1, currentPosition.Orientation);
                case Orientation.E:
                    return new Position(currentPosition.X + 1, currentPosition.Y, currentPosition.Orientation);
                case Orientation.S:
                    return new Position(currentPosition.X, currentPosition.Y - 1, currentPosition.Orientation);
                default:
                    return new Position(currentPosition.X - 1, currentPosition.Y, currentPosition.Orientation);
            }
        }
    }
}

