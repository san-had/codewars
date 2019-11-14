using System.Collections.Generic;
using System.Linq;

namespace OrArrays
{
    internal class KataLettersCount
    {
        public static Dictionary<char, int> LetterCount(string inputString)
        {
            var result = new Dictionary<char, int>();

            foreach (var ch in inputString.OrderBy(x => x))
            {
                if (!result.ContainsKey(ch))
                {
                    var numberOfChars = inputString.Where(x => x == ch).Count();

                    result.Add(ch, numberOfChars);
                }
            }
            return result;
        }
    }
}