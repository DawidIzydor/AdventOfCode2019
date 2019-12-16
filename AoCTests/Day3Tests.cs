using AdventOfCode2019.Day3;
using HelpingLibrary;
using Xunit;

namespace AoCTests
{
    public class Day3Tests
    {
        [Theory]
        [InlineData("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83", 159)]
        [InlineData("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7", 135)]
        [InlineData("R8,U5,L5,D3", "U7,R6,D4,L4", 6)]
        public void TestDistanceCalculation(string inputLines1, string inputLines2, int expected)
        {
            var lines1 = Day3Part1.GetLinesFromString(inputLines1);
            var lines2 = Day3Part1.GetLinesFromString(inputLines2);

            var intersections = Day3Part1.GetIntersectionPoints(lines1, lines2);
            var closest = Day3Part1.GetClosestDistance(new Point(0, 0), intersections);

            Assert.Equal(expected, closest);
        }
    }
}