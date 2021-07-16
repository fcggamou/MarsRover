using System;

namespace MarsRover
{
    public class InputException : Exception
    {
        public InputException(string errorMessage) : base(errorMessage) { }
    }

}
