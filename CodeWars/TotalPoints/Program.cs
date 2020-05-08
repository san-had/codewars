using System;

namespace TotalPoints
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] pointsArray2 = new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };

            string[] pointsArray3 = new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" };

            int totalPoints = Kata.TotalPoints2(pointsArray2);

            Console.WriteLine($"Total points: {totalPoints}");
        }
    }
}