using System;

namespace BlackJack
{
    internal class Program
    {
        private static void Main()
        {
            string[] cards = { "A" };
            Console.WriteLine(Kata.ScoreHand(cards));

            string[] cards2 = { "A", "J" };
            Console.WriteLine(Kata.ScoreHand(cards2));

            string[] cards3 = { "A", "10", "A" };
            Console.WriteLine(Kata.ScoreHand(cards3));

            string[] cards4 = { "5", "3", "7" };
            Console.WriteLine(Kata.ScoreHand(cards4));

            string[] cards5 = { "5", "4", "3", "2", "A", "K" };
            Console.WriteLine(Kata.ScoreHand(cards5));
        }
    }
}