using System;

namespace NewCachier
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var order = Kata2.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza");

            Console.WriteLine(order);
        }
    }
}