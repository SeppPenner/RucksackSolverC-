using RucksackSolver.Implementation;

namespace RucksackSolver.Interfaces
{
    public interface IConfigLoader
    {
        Config LoadConfiguration(string filename);
    }
}