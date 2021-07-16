namespace MarsRover
{
    /// <summary>
    /// Holds the X and Y coordinates and <see cref="Orientation.Orientation"/> of an object in a two-dimensional plane.
    /// </summary>
    public interface IPosition
    {
        int X { get; set; }
        int Y { get; set; }
        Orientation Orientation { get; set; }      
    }
}
