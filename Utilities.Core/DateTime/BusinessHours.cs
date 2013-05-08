using System.Linq;

namespace System.Utilities.Core.DateTime
{
    public class BusinessHours
    {
        private readonly TimeSpan _startingTime;
        private readonly TimeSpan _endingTime;
        private readonly DayOfWeek[] _excludeDays;

        public BusinessHours(TimeSpan? startingTime, TimeSpan? endingTime, DayOfWeek[] excludeDays)
        {
            this._startingTime = startingTime ?? new TimeSpan(8, 0, 0);
            this._endingTime = endingTime ?? new TimeSpan(18, 0, 0);
            this._excludeDays = excludeDays ?? new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };
        }

        public BusinessHours()
            : this(null, null, null)
        {

        }

        public TimeSpan Calculate(System.DateTime startDate, System.DateTime endDate)
        {
            var counter = startDate;
            double hours = 0;

            while (counter <= endDate)
            {
                var dayStart = counter.Date.Add(_startingTime);
                var dayEnd = counter.Date.Add(_endingTime);
                var nextDayStart = startDate.Date.Add(_startingTime).AddDays(1);

                if (counter < dayStart)
                {
                    counter = dayStart;
                }

                if (_excludeDays == null || _excludeDays.Contains(counter.DayOfWeek) == false)
                {
                    if (endDate < nextDayStart)
                    {
                        var ticks = Math.Min(endDate.Ticks, dayEnd.Ticks) - counter.Ticks;
                        hours = TimeSpan.FromTicks(ticks).TotalHours;
                        break;
                    }
                    else if (counter.Date == startDate.Date)
                    {
                        if (counter >= dayStart && counter <= dayEnd)
                        {
                            hours += (dayEnd - counter).TotalHours;
                        }
                    }
                    else if (counter.Date == endDate.Date && startDate.Date != endDate.Date)
                    {
                        if (counter >= dayStart && counter <= dayEnd)
                        {
                            hours += (counter - dayStart).TotalHours;
                        }
                        else if (counter > dayEnd)
                        {
                            hours += (_endingTime - _startingTime).TotalHours;
                        }
                    }
                    else
                    {
                        hours += (_endingTime - _startingTime).TotalHours;
                    }

                }

                counter = counter.AddDays(1);
                if (counter.Date == endDate.Date)
                {
                    counter = endDate;
                }
            }

            var returnValue = TimeSpan.FromHours(hours);
            return returnValue.Ticks < 0 ? TimeSpan.Zero : returnValue;
        }
    }
}
