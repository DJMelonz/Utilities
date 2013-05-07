﻿using System;

namespace System.Utilities.Core.Text
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
    }
}