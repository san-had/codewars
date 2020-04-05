using System;

namespace AlphabetWars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] testCases =
            {
                "abde[fgh]ijk",
                "ab#de[fgh]ijk",
                "ab#de[fgh]ij#k",
                "##abde[fgh]ijk",
                "##abde[fgh]ijk[mn]op",
                "#ab#de[fgh]ijk[mn]op",
                "#abde[fgh]i#jk[mn]op",
                "[a]#[b]#[c]",
                "[a]#b#[c][d]",
                "[a][b][c]",
                "##a[a]b[c]#",
                "[ab]adfd[dd]##[abe]dedf[ijk]d#d[h]#"
            };

            string[] expectedResults =
            {
                "abdefghijk",
                "fgh",
                string.Empty,
                string.Empty,
                "mn",
                "mn",
                "mn",
                "ac",
                "d",
                "abc",
                "c",
                "abijk"
            };

            //Console.WriteLine(Kata.AlphabetWar(testCases[10]));

            for (int i = 0; i < testCases.Length; i++)
            {
                string actual = Kata.AlphabetWar(testCases[i]);

                if (expectedResults[i] != actual)
                {
                    Console.WriteLine($"Expected: { expectedResults[i]} != Actual: { actual}");
                }
                else
                {
                    Console.WriteLine($"Testcase: { i.ToString()} { testCases[i]}");
                }
            }
        }
    }
}