namespace HelpingLibrary
{
    public static class StringHelper
    {
        public static int[] ToIntArray(this string[] stringArray)
        {
            var ret = new int[stringArray.Length];

            for (var i = 0; i < stringArray.Length; i++)
            {
                ret[i] = int.Parse(stringArray[i]);
            }
            return ret;
        }
    }
}