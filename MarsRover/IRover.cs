using System;

namespace MarsRover
{
    public interface IRover
    {
        public IPosition CurrentPosition { get; }

        void MoveForward();
        void RotateLeft();
        void RotateRight();
        
    }
}
