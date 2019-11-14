using System;

namespace SuperSize
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Kata.SuperSize(123456));

            Console.WriteLine(Kata.SuperSize(105));

            Console.WriteLine(Kata.SuperSize(12));

            Console.WriteLine(Kata.Aggregating());
        }
    }
}