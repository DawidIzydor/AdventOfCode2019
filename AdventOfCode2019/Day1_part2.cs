using System.Threading.Tasks;

namespace AdventOfCode2019
{
    public class Day1Part2 : Day1Part1
    {
        public override Task<int> Result(string input)
        {
            return CalculateWithFunction(input, CalculateUsageExtended);
        }

        public int CalculateUsageExtended(int input)
        {
            var baseUsage = CalculateUsage(input);
            if (baseUsage <= 0)
            {
                return 0;
            }

            return baseUsage + CalculateUsageExtended(baseUsage);
        }
    }
}