using System;

namespace MarsRover
{
    /// <summary>
    /// Represent an error that occurs when processing the input from the command prompt.
    /// </summary>
    public class InputException : Exception
    {
        public InputException(string errorMessage) : base(errorMessage) { }
    }

}
