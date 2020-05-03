using System.Collections.Generic;

namespace NumberZooPatrol
{
    public class Kata
    {
        public static int FindNumber(int[] animals)
        {
            List<int> animalsList = new List<int>();
            animalsList.AddRange(animals);
            animalsList.Sort();

            int missing = GetMissing(animalsList);

            return missing;
        }

        private static int GetMissing(List<int> animalsList)
        {
            int missing = animalsList.Count + 1;
            for (int index = 0; index < animalsList.Count; index++)
            {
                if (index + 1 != animalsList[index])
                {
                    missing = index + 1;
                    break;
                }
            }

            return missing;
        }
    }
}