using static Benchmarks.Constants;

namespace Benchmarks
{
    public static class Scenarios
    {
        public static string CharEquals(string input)
        {
            var lengthMinusOne = input.Length - 1;
            return input[lengthMinusOne] == SemicolonChar
                ? input.Substring(0, lengthMinusOne)
                : input;
        }

        public static string CharEquals_InRef(in string input)
        {
            var lengthMinusOne = input.Length - 1;
            return input[lengthMinusOne] == SemicolonChar
                ? input.Substring(0, lengthMinusOne)
                : input;
        }

        public static string EndsWith(string input)
            => input.EndsWith(SemicolonChar)
                ? input.Substring(0, input.Length - 1)
                : input;

        public static string EndsWith_InRef(in string input)
            => input.EndsWith(SemicolonChar)
                ? input.Substring(0, input.Length - 1)
                : input;
    }
}
