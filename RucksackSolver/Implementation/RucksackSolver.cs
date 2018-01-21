using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RucksackSolver.Implementation;
using RucksackSolver.Interfaces;

namespace RucksackSolver
{
    public class RucksackSolver : IRucksackSolver
    {
        private readonly IFileWriter _fileWriter = new FileWriter();
        private List<RucksackObject> _rucksackObjects;
        private int[,] _valuesOfFunction;

        public RucksackSolution Solve(List<RucksackObject> rucksackObjects, int b)
        {
            Init(rucksackObjects);
            FillTable(b);
            return CalculateSolution(b, "Dynamic Programming");
        }

        public RucksackSolution SolveFptas(List<RucksackObject> rucksackObjects, int b, int k)
        {
            InitFptas(rucksackObjects, k);
            FillTable(b);
            return CalculateSolution(b, "Dynamic Programming with FPTAS");
        }

        private RucksackSolution CalculateSolution(int b, string approach)
        {
            var solution = GetSolution(b);
            solution.Approach = approach;
            _fileWriter.WriteTableToFile(GetFileNameTable(), _valuesOfFunction);
            _fileWriter.WriteSolutionToFile(GetFileNameSolution(), solution);
            return solution;
        }

        private string GetFileNameTable()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return location != null
                ? Path.Combine(Directory.GetParent(location).FullName, "Table.csv")
                : string.Empty;
        }

        private string GetFileNameSolution()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return location != null
                ? Path.Combine(Directory.GetParent(location).FullName, "Solution.txt")
                : string.Empty;
        }

        private void Init(List<RucksackObject> rucksackObjects)
        {
            _rucksackObjects = rucksackObjects;
            var n = _rucksackObjects.Count * _rucksackObjects.Max(x => x.Price);
            _valuesOfFunction = new int[_rucksackObjects.Count + 1, n];
        }

        private void InitFptas(List<RucksackObject> rucksackObjects, int k)
        {
            Init(rucksackObjects);
            foreach (var rucksackObject in _rucksackObjects)
                rucksackObject.Price /= k;
        }

        private RucksackSolution GetSolution(int b)
        {
            var best = new RucksackSolution {RucksackObjects = new List<RucksackObject>()};
            for (int row = _rucksackObjects.Count, col = b; row > 0; row--)
                if (_valuesOfFunction[row, col] != _valuesOfFunction[row - 1, col])
                {
                    best.RucksackObjects.Add(_rucksackObjects[row - 1]);
                    col -= _rucksackObjects[row - 1].Weight;
                }
            best.TotalWeight = GetWeight(best.RucksackObjects);
            best.Value = GetValue(best.RucksackObjects);
            return best;
        }

        private int GetWeight(IEnumerable<RucksackObject> items)
        {
            return items.Sum(i => i.Weight);
        }

        private int GetValue(IEnumerable<RucksackObject> items)
        {
            return items.Sum(i => i.Price);
        }

        private void FillTable(int b)
        {
            for (var row = 1; row <= _rucksackObjects.Count; row++)
            {
                var item = _rucksackObjects[row - 1];
                for (var col = 0; col <= b; col++)
                    if (item.Weight > col)
                        _valuesOfFunction[row, col] = _valuesOfFunction[row - 1, col];
                    else
                        _valuesOfFunction[row, col] = Math.Max(_valuesOfFunction[row - 1, col],
                            _valuesOfFunction[row - 1, col - item.Weight] + item.Price);
            }
        }
    }
}