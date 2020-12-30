// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigLoader.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class to load the configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver.Implementation
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using global::RucksackSolver.Interfaces;

    /// <inheritdoc cref="IConfigLoader"/>
    /// <summary>
    /// A class to load the configuration.
    /// </summary>
    /// <seealso cref="IConfigLoader"/>
    public class ConfigLoader : IConfigLoader
    {
        /// <inheritdoc cref="IConfigLoader"/>
        /// <summary>
        /// Loads the configuration.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>A <see cref="Config"/> object.</returns>
        /// <seealso cref="IConfigLoader"/>
        public Config LoadConfiguration(string fileName)
        {
            try
            {
                var xDocument = XDocument.Load(fileName);
                return CreateObjectsFromString<Config>(xDocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Creates a object of type <see cref="T"/> from the <see cref="string"/>.
        /// </summary>
        /// <typeparam name="T">The type parameter.</typeparam>
        /// <param name="xDocument">The x document.</param>
        /// <returns>A new object of type <see cref="T"/>.</returns>
        private static T CreateObjectsFromString<T>(XDocument xDocument)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(new StringReader(xDocument.ToString()));
        }
    }
}