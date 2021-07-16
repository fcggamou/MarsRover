using MarsRover.Commands;

namespace MarsRover
{
    public class Rover : IRover
    {
        public IPosition CurrentPosition { get; private set; }
        public Rover(IPosition startingPosition)
        {
            CurrentPosition = startingPosition;
        }

        public void Move(IMoveCommand moveCommand)
        {
            CurrentPosition = moveCommand.Execute(CurrentPosition);
        }
    }
}
