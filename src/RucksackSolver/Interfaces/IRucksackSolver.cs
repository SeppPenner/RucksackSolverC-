// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRucksackSolver.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   An interface to solve the rucksack problem.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Interfaces;

/// <summary>
/// An interface to solve the rucksack problem.
/// </summary>
public interface IRucksackSolver
{
    /// <summary>
    /// Solves the problem.
    /// </summary>
    /// <param name="rucksackObjectsParam">The rucksack objects.</param>
    /// <param name="b">The b value.</param>
    /// <returns>The <see cref="RucksackSolution"/>.</returns>
    RucksackSolution Solve(List<RucksackObject> rucksackObjectsParam, int b);

    /// <summary>
    /// Solves the FPTAS.
    /// </summary>
    /// <param name="rucksackObjectsParam">The rucksack objects.</param>
    /// <param name="b">The b value.</param>
    /// <param name="k">The k value.</param>
    /// <returns>The <see cref="RucksackSolution"/>.</returns>
    RucksackSolution SolveFptas(List<RucksackObject> rucksackObjectsParam, int b, int k);
}
