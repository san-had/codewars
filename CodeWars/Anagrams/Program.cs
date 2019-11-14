using System;
using System.Collections.Generic;

namespace Anagrams
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var wordList = new List<string> { "aabb", "abcd", "bbaa", "dada" };

            var wordList2 = new List<string> { "aabb", "abcd", "bbaa", "dada" };

            var anagrams = Kata2.Anagrams("abba", wordList2);

            anagrams.ForEach(word =>
            {
                Console.WriteLine(word);
            });
        }
    }
}