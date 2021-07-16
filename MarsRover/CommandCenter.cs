using MarsRover.Commands;
using System;

namespace MarsRover
{
    public class CommandCenter
    {

        Rover _rover;
        Surface _surface;
        public CommandCenter(Rover rover, Surface surface)
        {
            _rover = rover;
            _surface = surface;
        }

        public void ProcessCommands(string commands)
        {
            foreach (char c in commands)
            {
                ProcessCommand(c);
            }
        }
        public void ProcessCommand(char command)
        {
            if (!ValidateCommand(command))
                throw new Exception($"Invalid command '{command}'");
            if (command == 'R')
                _rover.RotateRight();
            if (command == 'L')
                _rover.RotateLeft();
            if (command == 'M')
                _rover.MoveForward();
        }

        public bool IsRoverInsideSurfaceBounds()
        {
            return _rover.Position.X <= _surface.Width
                && _rover.Position.X >= 0
                && _rover.Position.Y >= 0
                && _rover.Position.Y <= _surface.Length;
        }

        public static bool ValidateCommand(char c)
        {
            //ToDo
            return c == 'L' || c == 'R' || c == 'M';
        }

    }
}
