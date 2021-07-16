
namespace MarsRover.Commands
{
    /// <summary>
    /// An <see cref="IMoveCommand"/> to rotate left from the current position.
    /// </summary>
    public class RotateLeftCommand : IMoveCommand
    {
        public IPosition Execute(IPosition currentPosition)
        {
            switch (currentPosition.Orientation)
            {
                case Orientation.N:
                    return new Position(currentPosition.X, currentPosition.Y, Orientation.W);
                case Orientation.E:
                    return new Position(currentPosition.X, currentPosition.Y, Orientation.N);
                case Orientation.S:
                    return new Position(currentPosition.X, currentPosition.Y, Orientation.E);
                default:
                    return new Position(currentPosition.X, currentPosition.Y, Orientation.S);
            }
        }
    }
}

