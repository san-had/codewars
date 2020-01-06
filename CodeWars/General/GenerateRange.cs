using System.Collections.Generic;
using System.Linq;

namespace General
{
    public class GenerateRange
    {
        public static int[] GenerateRangeOfIntegeres(int min, int max, int step)
        {
            var integers = new List<int>();

            for (int i = min; i <= max; i += step)
            {
                integers.Add(i);
            }

            return integers.ToArray();
        }

        public static int[] GenerateRangeOfIntegers2(int min, int max, int step)
        {
            return Enumerable.Range(min, max - min + 1).Where(x => (x - min) % step == 0).ToArray();
        }
    }
}