using System;
using System.Linq;

namespace Avg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var avg = GetAverage(new int[] { 5, 10 });
            Console.WriteLine(avg);
        }

        public static int GetAverage(int[] marks)
            => (int)marks.Average();
    }
}