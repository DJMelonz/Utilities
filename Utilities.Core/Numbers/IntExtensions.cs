using System;

namespace Utilities.Core.Numbers
{
    public static class IntExtensions
    {
        public static bool IsNullOrZero(this int? input)
        {
            return (!input.HasValue || input.Value == 0);
        }

        public static bool IsNotNullOrZero(this int? input)
        {
            return (input.HasValue && input.Value != 0);
        }
    }
}
