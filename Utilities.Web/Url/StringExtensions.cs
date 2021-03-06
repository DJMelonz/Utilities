﻿using System.Text.RegularExpressions;
using Utilities.Core.Text;

namespace Utilities.Web.Url
{
    public static class StringExtensions
    {
        /// <summary>
        /// Generate a friendly URL.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <param name="maxLength">Specify the maximum length of the URL (optional).</param>
        /// <remarks>Konrad Rudolph: http://stackoverflow.com/q/37809#37880</remarks>
        /// <returns></returns>
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
                input = input.TrimStart(new[] { '-' });
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
                input = input.TrimEnd(new[] { '-' });

                return input;
            }
            return string.Empty;
        }
    }
}
