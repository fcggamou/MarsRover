namespace MarsRover
{
    public interface IPosition
    {
        int X { get; set; }
        int Y { get; set; }
        Orientation Orientation { get; set; }
        void MoveForward();
        void RotateLeft();
        void RotateRight();
    }
}
