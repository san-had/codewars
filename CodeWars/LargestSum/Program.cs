using System;

namespace LargestSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array1 = new int[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 };
            Console.WriteLine(Kata.LargestSum(array1));

            var array2 = new int[] { };
            Console.WriteLine(Kata.LargestSum(array2));

            var array3 = new int[] { -1, -2, -3 };
            Console.WriteLine(Kata.LargestSum(array3));

            var array4 = new int[] { 0 };
            Console.WriteLine(Kata.LargestSum(array4));

            var array5 = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(Kata.LargestSum(array5));
        }
    }
}