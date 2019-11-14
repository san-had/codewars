using System;

namespace CircleOfNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var kata = new Kata();

            Console.WriteLine(kata.CircleOfNumbers(10, 2));

            Console.WriteLine(kata.CircleOfNumbers(8, 1));

            Console.WriteLine(kata.CircleOfNumbers(10, 7));
        }
    }
}