// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConfigLoader.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   An interface to load the configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Interfaces;

/// <summary>
/// An interface to load the configuration.
/// </summary>
public interface IConfigLoader
{
    /// <summary>
    /// Loads the configuration.
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <returns>A <see cref="Config"/> object.</returns>
    Config LoadConfiguration(string fileName);
}
