using System;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            try
            {
                ICommandCenter commandCenter = CommandPromptHelper.InitializeCommandCenterFromPrompt();
                string commands = CommandPromptHelper.GetCommandsFromPrompt();
                commandCenter.ExecuteCommands(commands);
                Console.WriteLine(commandCenter.GetStatus());
            }
            catch (InputException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
