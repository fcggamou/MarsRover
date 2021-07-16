using MarsRover.Commands;
using System;

namespace MarsRover
{
    public static class CommandFactory
    {
        public static IMoveCommand GetCommand(char command)
        {
            switch (command)
            {
                case 'R':
                    return new RotateRightCommand();
                case 'L':
                    return new RotateLeftCommand();
                case 'M':
                    return new MoveForwardCommand();
                default:
                    throw new Exception($"Invalid command {command}");
            }
        }
    }
}
