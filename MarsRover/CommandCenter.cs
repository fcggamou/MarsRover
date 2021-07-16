using MarsRover.Commands;
using System;

namespace MarsRover
{
    public class CommandCenter
    {

        IRover _rover;
        ISurface _surface;
        public CommandCenter(IRover rover, ISurface surface)
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

        public bool IsRoverInsideSurfaceBounds
        {
            get
            {
                return _rover.CurrentPosition.X <= _surface.Width
                    && _rover.CurrentPosition.X >= 0
                    && _rover.CurrentPosition.Y >= 0
                    && _rover.CurrentPosition.Y <= _surface.Length;
            }
        }

        public static bool ValidateCommand(char c)
        {
            //ToDo
            return c == 'L' || c == 'R' || c == 'M';
        }

        public IPosition RoverCurrentPosition
        {
            get
            {
                return _rover.CurrentPosition;
            }
        }

    }
}
