using System;
using System.Threading.Tasks;

namespace AdventOfCode2019
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var inputDataName = "day1_input";
            //var result = await new Day1_part1().Result(inputDataName);
            var result = await new Day1Part2().Result(inputDataName);


            Console.WriteLine(result);
        }
    }
}