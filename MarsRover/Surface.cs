namespace MarsRover
{
    public class Surface : ISurface
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
