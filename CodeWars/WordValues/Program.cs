using System;

namespace WordValues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var values = Kata.WordValue(new string[] { "codewars", "abc", "xyz" });
            var values = Kata.WordValue2(new string[] { "abc", "abc abc" });
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}