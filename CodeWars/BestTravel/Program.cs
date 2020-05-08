using System;
using System.Collections.Generic;

namespace BestTravel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var distanceList = new List<int>() { 50, 55, 57, 58, 60 };
            var distanceList2 = new List<int>() { 50, 55, 56, 57, 58 };
            var distanceList3 = new List<int>() { 50 };
            var distanceList4 = new List<int>() { 91, 74, 73, 85, 73, 81, 87 };

            Console.WriteLine(BestTravelKata.chooseBestSum(174, 3, distanceList));
            Console.WriteLine(BestTravelKata.chooseBestSum(163, 3, distanceList2));
            Console.WriteLine(BestTravelKata.chooseBestSum(163, 3, distanceList3));
            Console.WriteLine(BestTravelKata.chooseBestSum(230, 3, distanceList4));
        }
    }
}