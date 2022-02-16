// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RucksackSolution.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The rucksack solution class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Implementation;

/// <summary>
/// The rucksack solution class.
/// </summary>
public class RucksackSolution
{
    /// <summary>
    /// Gets or sets the approach.
    /// </summary>
    public string Approach { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the rucksack objects.
    /// </summary>
    public IList<RucksackObject> RucksackObjects { get; set; } = new List<RucksackObject>();

    /// <summary>
    /// Gets or sets the total weight.
    /// </summary>
    public double TotalWeight { get; set; }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Converts the object to a <see cref="string"/>.
    /// </summary>
    /// <returns>The object as <see cref="string"/>.</returns>
    public override string ToString()
    {
        var output = new StringBuilder();
        output.AppendLine($"{this.Approach} | value: {this.Value}, total weight: {this.TotalWeight}");

        foreach (var rucksackObject in this.RucksackObjects)
        {
            output.AppendLine(rucksackObject.ToString());
        }

        return output.ToString();
    }
}
