// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RucksackSolver.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class to solve the rucksack problem.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using global::RucksackSolver.Interfaces;

    /// <inheritdoc cref="IRucksackSolver"/>
    /// <summary>
    /// A class to solve the rucksack problem.
    /// </summary>
    /// <seealso cref="IRucksackSolver"/>
    public class RucksackSolver : IRucksackSolver
    {
        /// <summary>
        /// The file writer.
        /// </summary>
        private readonly IFileWriter fileWriter = new FileWriter();

        /// <summary>
        /// The rucksack objects.
        /// </summary>
        private List<RucksackObject> rucksackObjects = new();

        /// <summary>
        /// The values of the function.
        /// </summary>
        private int[,] valuesOfFunction = new int[1, 1];

        /// <inheritdoc cref="IRucksackSolver"/>
        /// <summary>
        /// Solves the problem.
        /// </summary>
        /// <param name="rucksackObjectsParam">The rucksack objects.</param>
        /// <param name="b">The b value.</param>
        /// <returns>The <see cref="RucksackSolution"/>.</returns>
        /// <seealso cref="IRucksackSolver"/>
        public RucksackSolution Solve(List<RucksackObject> rucksackObjectsParam, int b)
        {
            this.Init(rucksackObjectsParam);
            this.FillTable(b);
            return this.CalculateSolution(b, "Dynamic Programming");
        }

        /// <inheritdoc cref="IRucksackSolver"/>
        /// <summary>
        /// Solves the FPTAS.
        /// </summary>
        /// <param name="rucksackObjectsParam">The rucksack objects.</param>
        /// <param name="b">The b value.</param>
        /// <param name="k">The k value.</param>
        /// <returns>The <see cref="RucksackSolution"/>.</returns>
        /// <seealso cref="IRucksackSolver"/>
        public RucksackSolution SolveFptas(List<RucksackObject> rucksackObjectsParam, int b, int k)
        {
            this.InitFptas(rucksackObjectsParam, k);
            this.FillTable(b);
            return this.CalculateSolution(b, "Dynamic Programming with FPTAS");
        }

        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>The weight as <see cref="int"/>.</returns>
        private static int GetWeight(IEnumerable<RucksackObject> items)
        {
            return items.Sum(i => i.Weight);
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>The value as <see cref="int"/>.</returns>
        private static int GetValue(IEnumerable<RucksackObject> items)
        {
            return items.Sum(i => i.Price);
        }

        /// <summary>
        /// Gets the table file name.
        /// </summary>
        /// <returns>The table file name as <see cref="string"/>.</returns>
        private static string GetFileNameTable()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.Combine(Directory.GetParent(location)?.FullName ?? string.Empty, "Table.csv");
        }

        /// <summary>
        /// Gets the solution file name.
        /// </summary>
        /// <returns>The solution file name as <see cref="string"/>.</returns>
        private static string GetFileNameSolution()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.Combine(Directory.GetParent(location)?.FullName ?? string.Empty, "Solution.txt");
        }

        /// <summary>
        /// Calculates the solution.
        /// </summary>
        /// <param name="b">The v value.</param>
        /// <param name="approach">The approach.</param>
        /// <returns>The <see cref="RucksackSolution"/>.</returns>
        private RucksackSolution CalculateSolution(int b, string approach)
        {
            var solution = this.GetSolution(b);
            solution.Approach = approach;
            this.fileWriter.WriteTableToFile(GetFileNameTable(), this.valuesOfFunction);
            this.fileWriter.WriteSolutionToFile(GetFileNameSolution(), solution);
            return solution;
        }

        /// <summary>
        /// Initializes the rucksack objects.
        /// </summary>
        /// <param name="rucksackObjectsParam">The rucksack objects.</param>
        private void Init(List<RucksackObject> rucksackObjectsParam)
        {
            this.rucksackObjects = rucksackObjectsParam;
            var n = this.rucksackObjects.Count * this.rucksackObjects.Max(x => x.Price);
            this.valuesOfFunction = new int[this.rucksackObjects.Count + 1, n];
        }

        /// <summary>
        /// Initializes the FPTAS.
        /// </summary>
        /// <param name="rucksackObjectsParam">The rucksack objects.</param>
        /// <param name="k">The k value.</param>
        private void InitFptas(List<RucksackObject> rucksackObjectsParam, int k)
        {
            this.Init(rucksackObjectsParam);

            foreach (var rucksackObject in this.rucksackObjects)
            {
                rucksackObject.Price /= k;
            }
        }

        /// <summary>
        /// Gets the solution.
        /// </summary>
        /// <param name="b">The b value.</param>
        /// <returns>The <see cref="RucksackSolution"/>.</returns>
        private RucksackSolution GetSolution(int b)
        {
            var best = new RucksackSolution { RucksackObjects = new List<RucksackObject>() };

            for (int row = this.rucksackObjects.Count, col = b; row > 0; row--)
            {
                if (this.valuesOfFunction[row, col] == this.valuesOfFunction[row - 1, col])
                {
                    continue;
                }

                best.RucksackObjects.Add(this.rucksackObjects[row - 1]);
                col -= this.rucksackObjects[row - 1].Weight;
            }

            best.TotalWeight = GetWeight(best.RucksackObjects);
            best.Value = GetValue(best.RucksackObjects);
            return best;
        }

        /// <summary>
        /// Fills the table.
        /// </summary>
        /// <param name="b">The b value.</param>
        private void FillTable(int b)
        {
            for (var row = 1; row <= this.rucksackObjects.Count; row++)
            {
                var item = this.rucksackObjects[row - 1];

                for (var col = 0; col <= b; col++)
                {
                    if (item.Weight > col)
                    {
                        this.valuesOfFunction[row, col] = this.valuesOfFunction[row - 1, col];
                    }
                    else
                    {
                        this.valuesOfFunction[row, col] = Math.Max(
                            this.valuesOfFunction[row - 1, col],
                            this.valuesOfFunction[row - 1, col - item.Weight] + item.Price);
                    }
                }
            }
        }
    }
}