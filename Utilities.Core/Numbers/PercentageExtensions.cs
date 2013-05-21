using System.Collections.Generic;
using System.Linq;

namespace Utilities.Core.Numbers
{
    public static class PercentageExtensions
    {
        public static IEnumerable<double> Percentage(this IEnumerable<int> values)
        {
            var list = values.ToList();
            int sum = list.Sum();

            return list.Select(value => (double)value / (double)sum);
        }

        public static IEnumerable<double> Percentage(this IEnumerable<long> values)
        {
            var list = values.ToList();
            long sum = list.Sum();

            return list.Select(value => (double)value / (double)sum);
        }

        public static IEnumerable<double> Percentage(this IEnumerable<double> values)
        {
            var list = values.ToList();
            double sum = list.Sum();

            return list.Select(value => value / sum);
        }
    }
}
