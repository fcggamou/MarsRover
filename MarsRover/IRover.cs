using MarsRover.Commands;

namespace MarsRover
{
    public interface IRover
    {
        public IPosition CurrentPosition { get; }

        void Move(IMoveCommand moveCommand);

    }
}
