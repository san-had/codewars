using System.Linq;
using System.Text;

namespace General
{
    public class DeafRats
    {
        public static int CountDeafRats(string town)
        {
            int deafRatsCount = 0;

            string[] sequences = town.Split('P');

            char direction = 'R';

            foreach (var rawSequence in sequences)
            {
                string sequence = FilterSequence(rawSequence);

                deafRatsCount += GetDeafRatsCount(direction, sequence);

                direction = direction == 'L' ? 'R' : 'L';
            }

            return deafRatsCount;
        }

        private static int GetDeafRatsCount(char direction, string sequence)
        {
            return sequence.Count(ch => ch != direction);
        }

        private static string FilterSequence(string sequence)
        {
            StringBuilder filteredSequence = new StringBuilder();

            sequence = sequence.Replace("0", "O")
                               .Replace(" ", string.Empty);

            for (int i = 0; i < sequence.Length; i += 2)
            {
                string direction = sequence.Substring(i, 2) == "~O" ? "R" : "L";
                filteredSequence.Append(direction);
            }

            return filteredSequence.ToString();
        }
    }
}