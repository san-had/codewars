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
                "##a[a]b[c]#"
            };

            Console.WriteLine(Kata.AlphabetWar(testCases[1]));
        }
    }
}