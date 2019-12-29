using System;

namespace BlackJack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] cards = { "1", "2", "J", "A" };

            Console.WriteLine(Kata.ScoreHand(cards));
        }
    }
}