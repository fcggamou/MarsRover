using MarsRover.Commands;
using System;

namespace MarsRover
{
    public static class CommandFactory
    {
        private const char RotateRightCommand = 'R';
        private const char RotateLeftCommand = 'L';
        private const char MoveForwardCommand = 'A';
        public static bool TryGetCommand(char command, out IMoveCommand moveCommand)
        {            
            switch (char.ToUpper(command))
            {
                case RotateRightCommand:
                    moveCommand = new RotateRightCommand();
                    return true;
                case RotateLeftCommand:
                    moveCommand = new RotateLeftCommand();
                    return true;
                case MoveForwardCommand:
                    moveCommand = new MoveForwardCommand();
                    return true;
                default:
                    moveCommand = null;
                    return false;
            }
        }
    }
}
