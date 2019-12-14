using AdventOfCode2019;
using Xunit;

namespace AoCTests
{
    public class Day1Test
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void TestUsageCalculations(int input, int expected)
        {
            var day1 = new Day1();

            var result = day1.CalculateUsage(input);

            Assert.Equal(expected, result);
        }
    }
}