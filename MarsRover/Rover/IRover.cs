using MarsRover.Commands;

namespace MarsRover
{
    /// <summary>
    /// Represents a Rover that can be moved in a two-dimensional space.
    /// </summary>
    public interface IRover
    {
        /// <summary>
        /// The current <see cref="IPosition"/> of the Rover.
        /// </summary>
        public IPosition CurrentPosition { get; }

        /// <summary>
        /// Updates the position of the rover following the execution of the given <see cref="IMoveCommand"/>.
        /// </summary>
        void Move(IMoveCommand moveCommand);

    }
}
