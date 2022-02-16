// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigNotProperlyLoadedException.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The configuration not properly loaded exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Exceptions;

/// <inheritdoc cref="Exception"/>
/// <summary>
/// The configuration not properly loaded exception.
/// </summary>
public class ConfigNotProperlyLoadedException : Exception
{
    /// <inheritdoc cref="Exception"/>
    public ConfigNotProperlyLoadedException()
    {
    }

    /// <inheritdoc cref="Exception"/>
    public ConfigNotProperlyLoadedException(string message) : base(message)
    {
    }

    /// <inheritdoc cref="Exception"/>
    public ConfigNotProperlyLoadedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
