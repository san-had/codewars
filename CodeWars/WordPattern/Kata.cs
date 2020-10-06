using System.Collections.Generic;

namespace WordPattern
{
    public class Kata
    {
        public static string WordPattern(string word)
        {
            word = word.ToLower();
            Dictionary<char, int> charStore = new Dictionary<char, int>();
            var patternList = new List<int>();

            int pattern = 0;
            foreach (char ch in word)
            {
                if (!charStore.ContainsKey(ch))
                {
                    charStore[ch] = pattern++;
                }
                patternList.Add(charStore[ch]);
            }

            return string.Join('.', patternList);
        }
    }
}