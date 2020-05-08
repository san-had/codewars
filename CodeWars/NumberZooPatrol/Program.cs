using System;

namespace NumberZooPatrol
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var animals = new int[] { 7, 8, 1, 2, 4, 6, 5 };

            Console.WriteLine(Kata.FindNumber(animals));
        }
    }
}