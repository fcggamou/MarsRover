using System;

namespace MarsRover
{
    public class Rover : IRover
    {
        public IPosition CurrentPosition { get; private set; }
        public Rover(IPosition startingPosition)
        {
            CurrentPosition = startingPosition;
        }

        public void MoveForward()
        {
            CurrentPosition.MoveForward();
        }

        public void RotateLeft()
        {
            CurrentPosition.RotateLeft();            
        }

        public void RotateRight()
        {
            CurrentPosition.RotateRight();
        }
    }
}
