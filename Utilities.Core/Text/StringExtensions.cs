using System;
using System.Linq;

namespace Utilities.Core.Text
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static bool IsNotEmpty(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        public static bool IsNotEmptyAndEqualTo(this string input, string compare)
        {
            return input.IsNotEmpty() && input == compare;
        }

        public static bool IsNotEmptyOrEqualTo(this string input, string compare)
        {
            return input.IsNotEmpty() && input != compare;
        }

        public static string Truncate(this string input, int length = 75)
        {
            if (input.IsNotEmpty())
            {
                if (input.Length >= length)
                {
                    return "{0} ...".With(input.Substring(0, length));
                }
                return input;
            }
            return string.Empty;
        }

        public static string With(this string input, params object[] args)
        {
            return string.Format(input, args);
        }

        public static string AddSpacesBetweenCaps(this string input)
        {
            if (input.IsNotEmpty())
            {
                return string.Concat(input.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
            }
            return string.Empty;
        }
    }
}
