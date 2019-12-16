using System;
using System.Threading.Tasks;
using AdventOfCode2019.Day2;

namespace AdventOfCode2019
{
    internal class Program
    {
        private static async Task Main()
        {
            var inputDataName = "day1_input";
            //var result = await new Day1_part1().Result(inputDataName);
            //var result = await new Day1Part2().Result(inputDataName);
            var Day2Input =
                "1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,6,1,19,2,19,13,23,1,23,10,27,1,13,27,31,2,31,10,35,1,35,9,39,1,39,13,43,1,13,43,47,1,47,13,51,1,13,51,55,1,5,55,59,2,10,59,63,1,9,63,67,1,6,67,71,2,71,13,75,2,75,13,79,1,79,9,83,2,83,10,87,1,9,87,91,1,6,91,95,1,95,10,99,1,99,13,103,1,13,103,107,2,13,107,111,1,111,9,115,2,115,10,119,1,119,5,123,1,123,2,127,1,127,5,0,99,2,14,0,0";
            //var result = Day2Part1.GetOutput(Day2Part1.ProcessCode(Day2Part1.ReplaceInputValues(Day2Input, 12, 2)));
            var result = Day2Part2.FindInputs(Day2Input, 0, 99, 19690720);

            Console.WriteLine(result);
        }
    }
}