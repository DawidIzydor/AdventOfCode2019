using AdventOfCode2019.Day1;
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
        public void Part1TestDataTest(int input, int expected)
        {
            var day1 = new Day1Part1();

            var result = day1.CalculateUsage(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void Part2TestDataTest(int input, int expected)
        {
            var day2 = new Day1Part2();

            var result = day2.CalculateUsageExtended(input);

            Assert.Equal(expected, result);
        }
    }
}