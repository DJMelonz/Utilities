using System;

namespace Utilities.Core.DateTime
{
    public static class DateTimeExtensions
    {
        public static System.DateTime FirstDayOfWeek(this System.DateTime input, DayOfWeek firstDayOfWeek = DayOfWeek.Monday)
        {
            int delta = firstDayOfWeek - input.DayOfWeek;
            System.DateTime monday = input.AddDays(delta);

            return new System.DateTime(monday.Year, monday.Month, monday.Day);
        }

        public static System.DateTime LastDayOfWeek(this System.DateTime input)
        {
            System.DateTime firstDayOfTheWeek = input.FirstDayOfWeek();

            return firstDayOfTheWeek.AddDays(7).AddDays(-1);
        }

        public static System.DateTime FirstDayOfMonth(this System.DateTime input)
        {
            return new System.DateTime(input.Year, input.Month, 1);
        }

        public static System.DateTime LastDayOfMonth(this System.DateTime input)
        {
            System.DateTime firstDayOfTheMonth = input.FirstDayOfMonth();

            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// Convert DateTime into ISO8601 format.
        /// </summary>
        /// <param name="input">DateTime object.</param>
        /// <returns></returns>
        public static string ToIso8601(this System.DateTime input)
        {
            return input.ToString("yyyy-MM-ddTHH:mm:ssz");
        }

        public static TimeSpan BusinessHoursSince(this System.DateTime input)
        {
            return new BusinessHours().Calculate(input, System.DateTime.Now);
        }

        public static TimeSpan BusinessHoursBetween(this System.DateTime startDate, System.DateTime endDate)
        {
            return new BusinessHours().Calculate(startDate, endDate);
        }
    }
}
