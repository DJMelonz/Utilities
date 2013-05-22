using System.Collections.Generic;
using System.Linq;

namespace Utilities.Core.Numbers
{
    public static class PercentageExtensions
    {
        public static IEnumerable<double> AsPercentages(this IEnumerable<int> values)
        {
            if (values != null)
            {
                var list = values as IList<int> ?? values.ToList();
                int sum = list.Sum();
                if (sum == 0)
                {
                    return new double[0];
                }
                return list.Select(value => (double) value/(double) sum);
            }
            return new double[0];
        }

        public static IEnumerable<double> AsPercentages(this IEnumerable<long> values)
        {
            if (values != null)
            {
                var list = values as IList<long> ?? values.ToList();
                long sum = list.Sum();
                if (sum == 0)
                {
                    return new double[0];
                }
                return list.Select(value => (double)value / (double)sum);
            }
            return new double[0];
        }

        public static IEnumerable<double> AsPercentages(this IEnumerable<double> values)
        {
            if (values != null)
            {
                var list = values as IList<double> ?? values.ToList();
                double sum = list.Sum();
                if (sum == 0)
                {
                    return new double[0];
                }
                return list.Select(value => value / sum);
            }
            return new double[0];
        }
    }
}
