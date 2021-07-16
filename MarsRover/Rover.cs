using System;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; private set; }
        public Rover(Position startingPosition)
        {
            Position = startingPosition;
        }

        public void MoveForward()
        {
            Position.MoveForward();
        }

        public void RotateLeft()
        {
            Position.RotateLeft();            
        }

        public void RotateRight()
        {
            Position.RotateRight();
        }
    }
}
