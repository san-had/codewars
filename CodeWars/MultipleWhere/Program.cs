using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MultipleWhere
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new List<int>(Enumerable.Range(-10, 20));

            var positiveEvensA = numbers.Where(i => i > 0 && ((i % 2) == 0)).Select(i => i);

            var positiveEvensB = numbers.Where(i => i > 0).Where(i => (i % 2) == 0);

            Debug.Assert(positiveEvensA.Count() == positiveEvensB.Count());
        }
    }
}