using System.Collections.Generic;
using System.Linq;

namespace WordPattern

    public class Kata
{
    public static string WordPattern(string word)
    {
        word = word.ToLower();
        Dictionary<char, int> charStore = new Dictionary<char, int>();
        var patternList = new List<int>();

        int pattern = 0;
        char prevChar = ' ';
        for (int index = 0; index < word.Length; index++)
        {
            if (index != 0 && prevChar != word[index])
            {
                pattern = patternList.Max() + 1;
            }
            if (!charStore.ContainsKey(word[index]))
            {
                charStore.Add(word[index], pattern);
                patternList.Add(pattern);
            }
            else
            {
                pattern = charStore[word[index]];
                patternList.Add(pattern);
            }

            prevChar = word[index];
        }

        return string.Join('.', patternList);
    }
}
}