using System;

namespace RucksackSolver.Exceptions
{
    // ReSharper disable once UnusedMember.Global
    public class ConfigNotProperlyLoadedException : Exception
    {
        public ConfigNotProperlyLoadedException()
        {
        }

        public ConfigNotProperlyLoadedException(string message) : base(message)
        {
        }

        public ConfigNotProperlyLoadedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}