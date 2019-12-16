namespace AdventOfCode2019.Day2
{
    public static class Day2Part2
    {
        public static (int, int) FindInputs(string inputString, int minInput, int maxInput, int desiredOutput)
        {
            for (var checkingInput1 = minInput; checkingInput1 < maxInput; ++checkingInput1)
            {
                for (var checkingInput2 = minInput; checkingInput2 < maxInput; ++checkingInput2)
                {
                    if (Day2Part1.GetOutput(
                            Day2Part1.ProcessCode(Day2Part1.ReplaceInputValues(inputString, checkingInput1,
                                checkingInput2))) == desiredOutput)
                    {
                        return (checkingInput1, checkingInput2);
                    }
                }
            }

            return (-1, -1);
        }
    }
}