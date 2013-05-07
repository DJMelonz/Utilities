using System;

namespace System.Utilities.Core.Numbers
{
    public static class IntExtensions
    {
        public static bool IsNullOrZero(this int? input)
        {
            return (!input.HasValue || input.Value == 0);
        }
    }
}
