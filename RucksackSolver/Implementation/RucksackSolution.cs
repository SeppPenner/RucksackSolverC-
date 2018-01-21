using System.Collections.Generic;
using System.Text;

namespace RucksackSolver
{
    public class RucksackSolution
    {
        public string Approach { get; set; }

        public IList<RucksackObject> RucksackObjects { get; set; }

        public double TotalWeight { get; set; }

        public double Value { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine($"{Approach} | value: {Value}, total weight: {TotalWeight}");
            foreach (var rucksackObject in RucksackObjects)
                output.AppendLine(rucksackObject.ToString());
            return output.ToString();
        }
    }
}