using System.Linq;

namespace Pendulum
{
    public class Kata
    {
        public static int[] Pendulum(int[] values)
        {
            //var pendulum = new List<int>();

            //var orderedValues = values.OrderBy(v => v);

            //for (int i = 0; i < orderedValues.Count(); i++)
            //{
            //    if (i == 0 || i % 2 == 1)
            //    {
            //        pendulum.Add(orderedValues.ElementAt(i));
            //    }
            //    else
            //    {
            //        pendulum.Insert(0, orderedValues.ElementAt(i));
            //    }
            //}

            //return pendulum.ToArray();

            var pendulum = values.OrderBy(v => v)
                .Aggregate(Enumerable.Empty<int>(), (c, n) => c.Count() % 2 == 0 ? c.Prepend(n) : c.Append(n));

            return pendulum.ToArray();
        }
    }
}