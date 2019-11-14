using System;

namespace DiffOfVolumes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = new int[] { 3, 2, 5 };
            var b = new int[] { 1, 4, 4 };

            Console.WriteLine(Kata.FindDifference(a, b));
        }
    }
}