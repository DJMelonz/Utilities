using System;
using System.Text.RegularExpressions;

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
                    return string.Format("{0} ...", input.Substring(0, length));
                }
                return input;
            }
            return string.Empty;
        }

        public static string With(this string input, params object[] args)
        {
            return string.Format(input, args);
        }

        public static string ToSlug(this string input, int? maxLength = null)
        {
            if (input.IsNotEmpty())
            {
                input = input.ToLower();
                // Remove entities
                input = Regex.Replace(input, @"&\w+;", "");
                // Remove anything that is not letters, numbers, dash, or space
                input = Regex.Replace(input, @"[^a-z0-9\-\s]", "");
                // Replace spaces
                input = input.Replace(' ', '-');
                // Collapse dashes
                input = Regex.Replace(input, @"-{2,}", "-");
                // Trim excessive dashes at the beginning
                input = input.TrimStart(new[] {'-'});
                // Truncate if a value has been provided
                if (maxLength.HasValue)
                {
                    // if it's too long, clip it
                    if (input.Length > maxLength.Value - 1)
                    {
                        input = input.Substring(0, maxLength.Value);
                    }
                }
                // Remove trailing dashes
                input = input.TrimEnd(new[] {'-'});

                return input;
            }
            return string.Empty;
        }
    }
}
