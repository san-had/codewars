using System;

namespace NewCachier
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var order = Kata.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza");

            Console.WriteLine(order);
        }
    }
}