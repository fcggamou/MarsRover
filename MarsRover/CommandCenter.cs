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
            switch (command)
            {
                case 'R':
                    _rover.RotateRight();
                    break;
                case 'L':
                    _rover.RotateLeft();
                    break;
                case 'M':
                    _rover.MoveForward();
                    break;
                default:
                    throw new Exception($"Invalid command {command}");
                    
            }            
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

        public IPosition RoverCurrentPosition
        {
            get
            {
                return _rover.CurrentPosition;
            }
        }

    }
}
