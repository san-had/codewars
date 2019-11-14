using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var anagrams = new List<string>();

            string wordMap = GetWordMap(word);

            foreach (var candidateWord in words)
            {
                string candidateWordMap = GetWordMap(candidateWord);

                if (wordMap.Equals(candidateWordMap, StringComparison.OrdinalIgnoreCase))
                {
                    anagrams.Add(candidateWord);
                }
            }

            return anagrams;
        }

        private static string GetWordMap(string word)
        {
            string wordMap = string.Empty;

            var charGroups = word.GroupBy(ch => ch);

            foreach (var ch in charGroups.OrderBy(x => x.Key))
            {
                wordMap += ch.Key + ch.Count().ToString();
            }

            return wordMap;
        }
    }
}