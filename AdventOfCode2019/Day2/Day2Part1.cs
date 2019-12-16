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
                        codes[OutPosition(codes, position)] = DoAddition(codes, position);
                        position += 4;
                        break;
                    case 2:
                        codes[OutPosition(codes, position)] = DoMultiplication(codes, position);
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

        private static int DoAddition(int[] codes, in int position)
        {
            return GetParameter(codes, position, 1) + GetParameter(codes, position, 2);
        }

        private static int GetParameter(int[] table, int position, int parameterNumber)
        {
            return table[table[position + parameterNumber]];
        }

        private static int OutPosition(int[] codes, int position)
        {
            return codes[position + 3];
        }

        private static int DoMultiplication(int[] codes, int position)
        {
            return GetParameter(codes, position, 1) * GetParameter(codes, position, 2);
        }

        private static string FormatOutput(int[] codes)
        {
            var ret = codes.Aggregate("", (current, code) => $"{current}{code},");
            return ret.Substring(0, ret.Length - 1);
        }

        public static string ReplaceInputValues(string inputString, int input1, int input2)
        {
            var split = inputString.Split(',').ToIntArray();
            split[1] = input1;
            split[2] = input2;

            return FormatOutput(split);
        }

        public static int GetOutput(string inputString)
        {
            return int.Parse(inputString.Split(',')[0]);
        }
    }
}