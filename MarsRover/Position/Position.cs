namespace MarsRover
{
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Orientation Orientation { get; set; }

        public Position(int x, int y, Orientation orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
        }

        public void MoveForward()
        {
            switch (Orientation)
            {
                case Orientation.N:
                    Y++;
                    break;
                case Orientation.E:
                    X++;
                    break;
                case Orientation.S:
                    Y--;
                    break;
                case Orientation.W:
                    X--;
                    break;
            }
        }
        public void RotateLeft()
        {
            switch (Orientation)
            {
                case Orientation.N:
                    Orientation = Orientation.W;
                    break;
                case Orientation.E:
                    Orientation = Orientation.N;
                    break;
                case Orientation.S:
                    Orientation = Orientation.E;
                    break;
                case Orientation.W:
                    Orientation = Orientation.S;
                    break;
            }
        }

        public void RotateRight()
        {
            switch (Orientation)
            {
                case Orientation.N:
                    Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    Orientation = Orientation.N;
                    break;
            }
        }
    }
}
