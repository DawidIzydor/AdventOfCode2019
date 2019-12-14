using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HelpingLibrary;

namespace AdventOfCode2019
{
    public class Day1
    {
        public async Task<int> Result(string input)
        {
            return (await File.ReadAllLinesAsync(input)).ToIntArray().Sum(CalculateUsage);
        }

        public int CalculateUsage(int mass)
        {
            return mass / 3 - 2;
        }
    }
}