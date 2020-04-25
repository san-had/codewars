using System.Collections.Generic;
using System.Linq;
using Combinatorics.Collections;

namespace BestTravel
{
    public static class BestTravelKata
    {
        public static int? chooseBestSum(int distance, int numberOfTowns, List<int> distanceList)
        {
            string[] arrayString = new string[10];

            if (distanceList.Count < numberOfTowns)
            {
                return null;
            }

            var combinationList = new Combinations<int>(distanceList, numberOfTowns);

            int? bestSum = combinationList.Select(x => x.Sum()).Where(y => y <= distance).Max();

            //foreach (var combination in combinationList)
            //{
            //    int combinationSum = combination.Sum();
            //    bestSum = combinationSum > bestSum && combinationSum <= distance ? combinationSum : bestSum;
            //}

            return bestSum != 0 ? bestSum : null;
        }
    }
}