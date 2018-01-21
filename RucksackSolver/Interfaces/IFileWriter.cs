namespace RucksackSolver.Interfaces
{
    public interface IFileWriter
    {
        // ReSharper disable once UnusedMember.Global
        void WriteTableToFile(string fileName, int[,] table);

        // ReSharper disable once UnusedMember.Global
        void WriteSolutionToFile(string fileName, RucksackSolution solution);
    }
}