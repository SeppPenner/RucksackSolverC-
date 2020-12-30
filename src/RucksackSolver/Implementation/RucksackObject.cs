// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RucksackObject.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The rucksack object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Implementation
{
    using System;

    /// <summary>
    /// The rucksack object.
    /// </summary>
    [Serializable]
    public class RucksackObject
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Converts the object to a <see cref="string"/>.
        /// </summary>
        /// <returns>The object as <see cref="string"/>.</returns>
        public override string ToString()
        {
            return $"RucksackObject: Price: {this.Price} | Weight: {this.Weight}";
        }
    }
}