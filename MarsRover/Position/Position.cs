namespace MarsRover
{
    ///<inheritdoc cref="IPosition"/>
    public struct Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Orientation Orientation { get; set; }

        /// <summary>
        /// Creates a new <see cref="Position"/> with the given X and Y coordinates and <see cref="Orientation.Orientation"/>.
        /// </summary>        
        public Position(int x, int y, Orientation orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
        }
    }
}
