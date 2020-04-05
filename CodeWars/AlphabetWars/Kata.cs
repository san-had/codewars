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
            if (strikeCount != 1)
            {
                removeCharPositions.AddRange(RemoveShelters(battlefield));
            }
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
                if (i != 0)
                {
                    var previousShelterEnd = shelters[i - 1].Item2;
                    var currentShelterBegin = shelters[i].Item1;

                    var nextShelterBegin = shelters[i + 1].Item1;
                    var currentShelterEnd = shelters[i].Item2;
                }
            }

            return removePositions;
        }

        private static List<int> GetAllStrike(string battlefield)
        {
            List<int> strikes = new List<int>();

            int strikePosition = 0;

            while ((strikePosition = battlefield.IndexOf('#', strikePosition)) != -1)
            {
                strikes.Add(strikePosition);
            }
            return strikes;
        }

        private static List<Tuple<int, int>> GetShelters(string battlefield)
        {
            List<Tuple<int, int>> shelters = new List<Tuple<int, int>>();

            int shelterBeginPosition = 0;
            int shelterEndPosition = 0;

            while ((shelterBeginPosition = battlefield.IndexOf('[', shelterBeginPosition)) != -1)
            {
                while ((shelterEndPosition = battlefield.IndexOf(']', shelterEndPosition)) != -1)
                {
                    shelters.Add(new Tuple<int, int>(shelterBeginPosition, shelterEndPosition));
                }
            }
            return shelters;
        }

        private static int GetPreviousShelterBeginPosition(string battlefield, int strikePosition)
        {
            int previousShelterBeginPosition = strikePosition;
            for (int i = strikePosition; i >= 0; i--)
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