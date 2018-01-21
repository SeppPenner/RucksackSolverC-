using System;
using System.IO;
using RucksackSolver.Interfaces;

namespace RucksackSolver.Implementation
{
    public class FileWriter : IFileWriter
    {
        public void WriteTableToFile(string fileName, int[,] table)
        {
            using (var file = File.AppendText(fileName))
            {
                file.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH24:mm:ss-fff") + ":");
                file.Write("alpha,");
                var dimensionX = table.GetLength(0);
                var dimensionY = table.GetLength(1);
                for (var row = 0; row < dimensionX - 2; row++)
                    if (row == dimensionX - 3)
                        file.WriteLine(row + 1);
                    else
                        file.Write(row + 1 + ",");

                for (var col = 0; col < dimensionY; col++)
                for (var row = 1; row < dimensionX; row++)
                    if (row == 1)
                        file.Write(col + ",");
                    else if (row == dimensionX - 1)
                        file.WriteLine(table[row, col]);
                    else
                        file.Write(table[row, col] + ",");
            }
        }

        public void WriteSolutionToFile(string fileName, RucksackSolution solution)
        {
            using (var file = File.AppendText(fileName))
            {
                file.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH24:mm:ss-fff") + ":");
                file.WriteLine(solution.ToString());
            }
        }
    }
}