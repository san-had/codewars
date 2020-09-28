using System.Collections.Generic;
using System.Linq;

namespace WordValues
{
    public class Kata
    {
        private const int Offset = 96;

        public static int[] WordValue(string[] a)
        {
            List<int> wordValues = new List<int>();
            for (int index = 0; index < a.Length; index++)
            {
                int wordSum = 0;
                foreach (var ch in a[index].Replace(" ", string.Empty))
                {
                    int value = ((int)ch - Offset) * (index + 1);
                    wordSum += value;
                }
                wordValues.Add(wordSum);
            }
            return wordValues.ToArray();
        }

        public static int[] WordValue2(string[] a)
        {
            var query = a.Select(word => word.Replace(" ", string.Empty).Select(ch => ((int)ch - Offset)).Sum());

            var query2 = a.Select((word, index) => word.Sum(ch => ch != 32 ? ch - Offset : 0) * ++index);

            return query2.ToArray();
        }
    }
}