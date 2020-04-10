using System;
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

            battlefield = Strike(battlefield, strikeCount);

            return battlefield;
        }

        private static string Strike(string battlefield, int strikeCount)
        {
            List<int> removeCharPositions = new List<int>();
            //int strikePosition = battlefield.IndexOf('#');
            //removeCharPositions.Add(strikePosition);
            //battlefield = battlefield.Remove(strikePosition, 1);
            removeCharPositions.AddRange(RemoveCharsOutsideOfShelter(battlefield));
            if (strikeCount > 1)
            {
                removeCharPositions.AddRange(RemoveShelters(battlefield));
            }
            removeCharPositions.AddRange(GetAllStrike(battlefield));
            removeCharPositions.AddRange(GetAllShelterPosition(battlefield));
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

        private static List<int> RemoveShelters(string battlefield)
        {
            List<int> removePositions = new List<int>();
            if (battlefield.IndexOf('[') == -1)
            {
                return removePositions;
            }
            List<Tuple<int, int>> shelters = GetShelters(battlefield);
            List<int> strikes = GetAllStrike(battlefield);

            for (int i = 0; i < shelters.Count; i++)
            {
                int previousShelterEnd = 0;

                if (i != 0)
                {
                    previousShelterEnd = shelters[i - 1].Item2;
                }

                var currentShelterBegin = shelters[i].Item1;
                var currentShelterEnd = shelters[i].Item2;

                bool isStrikeLeft = strikes.Any(x => x >= previousShelterEnd && x < currentShelterBegin);

                bool isMoreStrikeLeft = isStrikeLeft && strikes.Count(x => x >= previousShelterEnd && x < currentShelterBegin) > 1;

                if (isMoreStrikeLeft)
                {
                    removePositions.AddRange(RemoveShelter(currentShelterBegin, currentShelterEnd));
                }

                int nextShelterBegin;
                if (i == shelters.Count - 1)
                {
                    nextShelterBegin = battlefield.Length - 1;
                }
                else
                {
                    nextShelterBegin = shelters[i + 1].Item1;
                }

                bool isStrikeRight = strikes.Any(x => x > currentShelterEnd && x <= nextShelterBegin);

                bool isMoreStrikeRight = isStrikeRight && strikes.Count(x => x > currentShelterEnd && x <= nextShelterBegin) > 1;

                if (isStrikeLeft && isStrikeRight || isMoreStrikeRight)
                {
                    removePositions.AddRange(RemoveShelter(currentShelterBegin, currentShelterEnd));
                }
            }

            return removePositions;
        }

        private static List<int> RemoveShelter(int currentShelterBegin, int currentShelterEnd)
        {
            List<int> removePositions = new List<int>();

            int length = currentShelterEnd + 1;
            for (int index = currentShelterBegin; index < length; index++)
            {
                removePositions.Add(index);
            }
            return removePositions;
        }

        private static List<int> GetAllStrike(string battlefield)
        {
            List<int> strikes = new List<int>();

            for (int i = 0; i < battlefield.Length; i++)
            {
                if (battlefield[i] == '#')
                {
                    strikes.Add(i);
                }
            }

            return strikes;
        }

        private static List<Tuple<int, int>> GetShelters(string battlefield)
        {
            List<Tuple<int, int>> shelters = new List<Tuple<int, int>>();

            int shelterBeginPosition = 0;
            int shelterEndPosition = 0;

            for (int i = 0; i < battlefield.Length; i++)
            {
                if (battlefield[i] == '[')
                {
                    shelterBeginPosition = i;
                    continue;
                }
                if (battlefield[i] == ']')
                {
                    shelterEndPosition = i;
                    shelters.Add(new Tuple<int, int>(shelterBeginPosition, shelterEndPosition));
                }
            }

            return shelters;
        }

        private static List<int> GetAllShelterPosition(string battleField)
        {
            List<int> shelterPositions = new List<int>();
            for (int i = 0; i < battleField.Length; i++)
            {
                if (battleField[i] == '[' || battleField[i] == ']')
                {
                    shelterPositions.Add(i);
                }
            }
            return shelterPositions;
        }
    }
}