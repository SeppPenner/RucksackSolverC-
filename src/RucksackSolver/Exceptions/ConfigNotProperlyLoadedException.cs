// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigNotProperlyLoadedException.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The configuration not properly loaded exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Exceptions
{
    using System;

    /// <inheritdoc cref="Exception"/>
    /// <summary>
    /// The configuration not properly loaded exception.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    public class ConfigNotProperlyLoadedException : Exception
    {
        /// <inheritdoc cref="Exception"/>
        // ReSharper disable once UnusedMember.Global
        public ConfigNotProperlyLoadedException()
        {
        }

        /// <inheritdoc cref="Exception"/>
        // ReSharper disable once UnusedMember.Global
        public ConfigNotProperlyLoadedException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="Exception"/>
        // ReSharper disable once UnusedMember.Global
        public ConfigNotProperlyLoadedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}