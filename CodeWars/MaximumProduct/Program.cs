using System;

namespace MaximumProduct
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new int[] { -23, 4, -5, 99, -27, 329, -2, 7, -921 };

            Console.WriteLine(Kata2.AdjacentElementProducts(array).ToString());
        }
    }
}