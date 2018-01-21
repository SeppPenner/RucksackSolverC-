using System.Collections.Generic;

namespace RucksackSolver.Interfaces
{
    public interface IRucksackSolver
    {
        // ReSharper disable once UnusedMethodReturnValue.Global
        RucksackSolution Solve(List<RucksackObject> rucksackObjects, int b);

        // ReSharper disable once UnusedMember.Global
        RucksackSolution SolveFptas(List<RucksackObject> rucksackObjects, int b, int k);
    }
}