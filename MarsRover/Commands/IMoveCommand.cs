
namespace MarsRover.Commands
{
    public interface IMoveCommand
    {
        public IPosition Execute(IPosition currentPosition);
    }
}
