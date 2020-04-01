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
            int strikePosition = battlefield.IndexOf('#');
            battlefield = battlefield.Remove(strikePosition, 1);
            battlefield = RemoveCharsOutsideOfShelter(battlefield);
            battlefield = RemoveShelters(battlefield, strikePosition);
            return battlefield;
        }

        private static string RemoveCharsOutsideOfShelter(string battlefield)
        {
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
                    battlefield = battlefield.Remove(i, 1);
                }
            }
            return battlefield;
        }

        private static string RemoveShelters(string battlefield, int strikePosition)
        {
            int previousShelterBeginPosition = GetPreviousShelterBeginPosition(battlefield, strikePosition);
            int previousShelterEndPosition = battlefield.IndexOf(']', previousShelterBeginPosition);
            battlefield = battlefield.Remove(previousShelterEndPosition, 1);
            battlefield = battlefield.Remove(previousShelterBeginPosition, 1);

            int nextShelterBeginPosition = battlefield.IndexOf('[', strikePosition);
            int nextShelterEndPosition = battlefield.IndexOf(']', strikePosition);
            battlefield = battlefield.Remove(nextShelterEndPosition, 1);
            battlefield = battlefield.Remove(nextShelterBeginPosition, 1);
            return battlefield;
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