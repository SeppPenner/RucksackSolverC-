using System;

namespace RucksackSolver
{
    [Serializable]
    public class RucksackObject
    {
        public int Price { get; set; }

        public int Weight { get; set; }

        public override string ToString()
        {
            return $"RucksackObject: Price: {Price} | Weight: {Weight}";
        }
    }
}