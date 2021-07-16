namespace MarsRover
{
    public interface ISurface
    {
        uint Width { get; }
        uint Length { get; }

        bool IsPointInside(IPosition pointPosition);

    }
}
