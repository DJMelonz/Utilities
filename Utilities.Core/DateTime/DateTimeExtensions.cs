using System;

namespace System.Utilities.Core.DateTime
{
    public static class DateTimeExtensions
    {
        public static System.DateTime FirstDayOfWeek(this System.DateTime input)
        {
            int delta = DayOfWeek.Monday - input.DayOfWeek;
            System.DateTime monday = input.AddDays(delta);
            return new System.DateTime(monday.Year, monday.Month, monday.Day);
        }

        public static System.DateTime FirstDayOfMonth(this System.DateTime input)
        {
            return new System.DateTime(input.Year, input.Month, 1);
        }
    }
}
