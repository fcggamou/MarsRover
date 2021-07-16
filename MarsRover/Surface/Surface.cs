namespace MarsRover
{
    ///<inheritdoc cref="ISurface"/>
    public class Surface : ISurface
    {
        public uint Width { get; private set; }
        public uint Length { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="Surface"/> with the given width and length.
        /// </summary>        
        public Surface(uint width, uint length)
        {
            Width = width;
            Length = length;
        }

        public bool IsPointInside(IPosition pointPosition)
        {           
            return pointPosition.X <= Width
                    && pointPosition.Y <= Length
                    && pointPosition.X >= 0
                    && pointPosition.Y >= 0;                    
        }
    }
}
