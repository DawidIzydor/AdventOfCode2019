using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HelpingLibrary;

namespace AdventOfCode2019
{
    public class Day1Part1
    {
        public virtual async Task<int> Result(string input)
        {
            return await CalculateWithFunction(input, CalculateUsage);
        }

        protected static async Task<int> CalculateWithFunction(string input, Func<int, int> calculationFunction)
        {
            return (await File.ReadAllLinesAsync(input)).ToIntArray().Sum(calculationFunction);
        }

        public int CalculateUsage(int mass)
        {
            return mass / 3 - 2;
        }
    }
}