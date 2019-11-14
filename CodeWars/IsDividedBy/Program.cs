using System;

namespace IsDividedBy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var isDivided = Kata.is_divide_by(-12, 2, -5);

            Console.WriteLine(isDivided);
        }
    }
}