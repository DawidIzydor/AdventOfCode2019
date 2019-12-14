using System;
using System.Threading.Tasks;

namespace AdventOfCode2019
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var day1Result = await new Day1().Result("day1_input");

            Console.WriteLine(day1Result);
        }
    }
}
