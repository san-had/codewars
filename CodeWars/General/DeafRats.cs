using System.Linq;

namespace General
{
    public class DeafRats
    {
        public static int CountDeafRats(string town)
        {
            int deafRatsCount = 0;

            string sequenceAll = GetSequence(town);

            string[] sequences = sequenceAll.Split('P');

            char direction = 'R';

            foreach (var sequence in sequences)
            {
                if (direction == ' ')
                {
                    direction = GetDirection(sequence);
                }
                deafRatsCount += GetDeafRatsCount(direction, sequence);

                direction = direction == 'L' ? 'R' : 'L';
            }

            return deafRatsCount;
        }

        private static int GetDeafRatsCount(char direction, string sequence)
        {
            return sequence.Count(ch => ch != direction);
        }

        private static char GetDirection(string sequence)
        {
            int leftDirection = sequence.Count(x => x == 'L');
            int rightDirection = sequence.Count(x => x == 'R');

            return leftDirection >= rightDirection ? 'L' : 'R';
        }

        private static string GetSequence(string town)
        {
            string filteredTown1 = town.Replace("0", "O");

            int firstIndexOfWave = filteredTown1.IndexOf('~');
            int firstIndexOfO = filteredTown1.IndexOf('O');

            string filteredTown2 = string.Empty;
            if (firstIndexOfO > firstIndexOfWave)
            {
                filteredTown2 = filteredTown1.Replace("~O", "R")
                                             .Replace("O~", "L");
            }
            else
            {
                filteredTown2 = filteredTown1.Replace("O~", "L")
                                              .Replace("~O", "R");
            }

            string sequenceAll = filteredTown2.Replace(" ", string.Empty);

            return sequenceAll;
        }
    }
}