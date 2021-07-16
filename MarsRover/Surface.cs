using System;

namespace MarsRover
{
    public class Surface
    {
        public int Width { get; private set; }
        public int Length { get; private set; }
        public Surface(int width, int length)
        {
            Width = width;
            Length = length;
        }
    }
}
