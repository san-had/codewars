using System;

namespace TrafficLight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Kata.UpdateLight("yellow"));

            Console.WriteLine(Kata.UpdateLight("red"));

            Console.WriteLine(Kata.UpdateLight("green"));

            Console.WriteLine(Kata.UpdateLight("black"));
        }
    }
}