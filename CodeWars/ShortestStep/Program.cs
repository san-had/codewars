using System;

namespace ShortestStep
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num = 16;

            Console.WriteLine($"{num} has {Kata.ShortestStepsToNum(num)} steps");
        }
    }
}