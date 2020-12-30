// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Config.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The configuration class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Implementation
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The configuration class.
    /// </summary>
    [Serializable]
    public class Config
    {
        /// <summary>
        /// Gets or sets the rucksack objects.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public List<RucksackObject> RucksackObjects { get; set; }
    }
}