namespace MarsRover
{
    public interface ICommandCenter
    {
        void ExecuteCommands(string commands);

        string GetStatus();
    }
}
