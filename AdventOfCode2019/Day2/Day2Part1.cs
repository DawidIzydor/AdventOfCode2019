using System;
using System.Linq;
using HelpingLibrary;

namespace AdventOfCode2019.Day2
{
    public class Day2Part1
    {
        public static string ProcessCode(string opCode)
        {
            var split = opCode.Split(',');
            var codes = split.ToIntArray();
            var endFor = false;

            for (var position = 0; position < codes.Length;)
            {
                switch (codes[position])
                {
                    case 99:
                        endFor = true;
                        break;
                    case 1:
                        DoAddition(codes, position);
                        position += 4;
                        break;
                    case 2:
                        DoMultiplication(codes, position);
                        position += 4;
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (endFor)
                {
                    break;
                }
            }

            return FormatOutput(codes);
        }

        private static string FormatOutput(int[] codes)
        {
            var ret = codes.Aggregate("", (current, code) => $"{current}{code},");
            return ret.Substring(0, ret.Length - 1);
        }

        public static string RestoreGravityAssistProgramToAlarm(string input)
        {
            var split = input.Split(',').ToIntArray();
            split[1] = 12;
            split[2] = 2;

            return FormatOutput(split);
        }

        private static void DoMultiplication(int[] codes, int position)
        {
            var addPosition1 = codes[position + 1];
            var addPosition2 = codes[position + 2];
            var outPosition = codes[position + 3];
            codes[outPosition] = codes[addPosition1] * codes[addPosition2];
        }

        private static void DoAddition(int[] codes, int position)
        {
            var addPosition1 = codes[position + 1];
            var addPosition2 = codes[position + 2];
            var outPosition = codes[position + 3];
            codes[outPosition] = codes[addPosition1] + codes[addPosition2];
        }
    }
}