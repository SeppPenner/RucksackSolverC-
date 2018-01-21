using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using RucksackSolver.Interfaces;

namespace RucksackSolver.Implementation
{
    public class ConfigLoader : IConfigLoader
    {
        public Config LoadConfiguration(string filename)
        {
            try
            {
                var xDocument = XDocument.Load(filename);
                return CreateObjectsFromString<Config>(xDocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return null;
            }
        }

        private T CreateObjectsFromString<T>(XDocument xDocument)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T) xmlSerializer.Deserialize(new StringReader(xDocument.ToString()));
        }
    }
}