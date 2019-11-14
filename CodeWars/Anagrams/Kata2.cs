using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    public class Kata2
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var anagrams = new List<string>();

            foreach (var candidateWord in words)
            {
                if (word.OrderBy(ch => ch).SequenceEqual(candidateWord.OrderBy(ch => ch)))
                {
                    anagrams.Add(candidateWord);
                }
            }

            return anagrams;
        }
    }
}