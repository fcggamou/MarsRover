﻿namespace MarsRover
{
    /// <summary>
    /// Represents a two-dimensional rectangular surface.
    /// </summary>
    public interface ISurface
    {
        /// <summary>
        /// The width of the surface.
        /// </summary>
        uint Width { get; }

        /// <summary>
        /// The length of the surface.
        /// </summary>
        uint Length { get; }

        /// <summary>
        /// Indicates whether the given point is within the boundaries of the surface.
        /// </summary>                

        bool IsPointInside(IPosition pointPosition);

    }
}
