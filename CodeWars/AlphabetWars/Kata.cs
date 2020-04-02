using System.Collections.Generic;
using System.Linq;

namespace AlphabetWars
{
    public class Kata
    {
        public static string AlphabetWar(string battlefield)
        {
            int strikeCount = battlefield.Where(c => c == '#').Count();

            int shelterCount = battlefield.Where(c => c == '[').Count();

            if (strikeCount == 0)
            {
                return battlefield.Replace("[", string.Empty).Replace("]", string.Empty);
            }

            if (strikeCount >= shelterCount)
            {
                for (int i = 0; i < strikeCount; i++)
                {
                    battlefield = Strike(battlefield);
                }
            }

            return battlefield;
        }

        private static string Strike(string battlefield)
        {
            List<int> removeCharPositions = new List<int>();
            int strikePosition = battlefield.IndexOf('#');
            removeCharPositions.Add(strikePosition);
            //battlefield = battlefield.Remove(strikePosition, 1);
            removeCharPositions.AddRange(RemoveCharsOutsideOfShelter(battlefield));
            removeCharPositions.AddRange(RemoveShelters(battlefield, strikePosition));
            removeCharPositions.Sort();
            removeCharPositions = removeCharPositions.Distinct().ToList();
            battlefield = RemoveChars(removeCharPositions, battlefield);
            return battlefield;
        }

        private static string RemoveChars(List<int> removeCharPositions, string battlefield)
        {
            for (int i = removeCharPositions.Count - 1; i >= 0; i--)
            {
                battlefield = battlefield.Remove(removeCharPositions[i], 1);
            }
            return battlefield;
        }

        private static List<int> RemoveCharsOutsideOfShelter(string battlefield)
        {
            List<int> removePositions = new List<int>();
            bool deleteChars = true;
            for (int i = battlefield.Length - 1; i >= 0; i--)
            {
                if (battlefield[i] == ']')
                {
                    deleteChars = false;
                    continue;
                }
                if (battlefield[i] == '[')
                {
                    deleteChars = true;
                    continue;
                }
                if (deleteChars && battlefield[i] != '#')
                {
                    removePositions.Add(i);
                }
            }
            return removePositions;
        }

        private static List<int> RemoveShelters(string battlefield, int strikePosition)
        {
            List<int> removePositions = new List<int>();
            if (battlefield.IndexOf('[') == -1)
            {
                return removePositions;
            }
            int previousShelterBeginPosition = GetPreviousShelterBeginPosition(battlefield, strikePosition);
            int previousShelterEndPosition = battlefield.IndexOf(']', previousShelterBeginPosition);
            removePositions.Add(previousShelterEndPosition);
            removePositions.Add(previousShelterBeginPosition);
            //battlefield = battlefield.Remove(previousShelterEndPosition, 1);
            //battlefield = battlefield.Remove(previousShelterBeginPosition, 1);

            int nextShelterBeginPosition = battlefield.IndexOf('[', strikePosition);
            int nextShelterEndPosition = battlefield.IndexOf(']', strikePosition);
            removePositions.Add(nextShelterEndPosition);
            removePositions.Add(nextShelterBeginPosition);
            //battlefield = battlefield.Remove(nextShelterEndPosition, 1);
            //battlefield = battlefield.Remove(nextShelterBeginPosition, 1);
            return removePositions;
        }

        private static int GetPreviousShelterBeginPosition(string battlefield, int strikePosition)
        {
            int previousShelterBeginPosition = strikePosition;
            for (int i = strikePosition; i > 0; i--)
            {
                if (battlefield[i] == '[')
                {
                    previousShelterBeginPosition = i;
                }
            }
            return previousShelterBeginPosition;
        }
    }
}