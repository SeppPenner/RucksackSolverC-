// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileWriter.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   An interface to write files.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Interfaces;

/// <summary>
/// An interface to write files.
/// </summary>
public interface IFileWriter
{
    /// <summary>
    /// Writes the table to a file.
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <param name="table">The table.</param>
    void WriteTableToFile(string fileName, int[,] table);

    /// <summary>
    /// Writes the solution to a file.
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <param name="solution">The solution.</param>
    void WriteSolutionToFile(string fileName, RucksackSolution solution);
}
