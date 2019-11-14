using System;

namespace Pendulum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Pendulum...");

            var pendulum = Kata.Pendulum(new int[] { 11, -16, -18, 13, -11, -12, 3, 18 });

            Console.WriteLine(string.Join(" ", pendulum));
        }
    }
}