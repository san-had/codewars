namespace DotAndBoxesTest
{
    // https://nunit.org/
    // https://github.com/nunit

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DotAndBoxes;
    using NUnit.Framework;

    // using System.Text;
    // using System.Text.RegularExpressions;

    [TestFixture, Description("Full Test Suite")]
    public class Full_Test_Suite
    {
        private static Random RN = new Random();

        private static string[] FixedTests = new string[10]
        {
            "{{0,1},{7,8},{1,2},{6,7},{0,3},{5,8},{3,4},{1,4},{4,5},{2,5},{4,7},{3,6}} -> 3,1",
            "{{0,1},{1,2},{2,5},{5,4},{4,7},{7,8},{8,5},{1,4},{6,7},{3,6},{3,0},{3,4}} -> 2,2",
            "{{0,1},{7,8},{1,2},{6,7},{0,3},{8,5},{3,4},{4,1},{4,5},{2,5},{3,6},{7,4}} -> 1,3",
            "{{1,4},{3,4},{4,5},{4,7},{0,3},{1,2},{7,8},{7,6},{0,1},{2,5},{3,6},{8,5}} -> 4,0",
            "{{0,1},{5,9},{9,8},{13,9},{7,11},{0,4},{9,10},{10,6},{4,5},{2,3},{13,14},{4,8},{8,12},{1,5},{5,6},{14,15},{10,11},{2,6},{12,13},{1,2},{10,14},{15,11},{6,7},{3,7}} -> 2,7",
            "{{5,9},{6,10},{9,13},{7,11},{4,5},{5,6},{6,7},{8,12},{1,5},{2,6},{8,9},{10,14},{10,11},{4,8},{12,13},{9,10},{1,2},{11,15},{13,14},{14,15},{0,4},{0,1},{3,7},{2,3}} -> 6,3",
            "{{0,1},{1,5},{5,4},{4,8},{8,9},{9,5},{5,6},{6,2},{2,3},{3,7},{7,6},{6,10},{10,9},{9,13},{13,14},{14,15},{15,11},{11,10},{10,14},{1,2},{7,11},{0,4},{8,12},{12,13}} -> 2,7",
            "{{6,10},{9,10},{8,12},{1,5},{10,14},{6,7},{4,5},{5,9},{14,15},{10,11},{9,13},{5,6},{7,11},{11,15},{13,14},{4,8},{8,9},{12,13},{2,6},{0,4},{0,1},{1,2},{3,7},{2,3}} -> 4,5",
            "{{6,11},{11,10},{10,15},{15,16},{16,21},{21,22},{22,17},{17,16},{16,11},{8,13},{9,14},{18,23},{19,24},{12,13},{1,6},{2,3},{7,8},{12,17},{7,12},{11,12},{5,10},{6,7},{22,23},{15,20},{5,6},{17,18},{23,24},{19,18},{18,13},{21,20},{5,0},{13,14},{14,19},{8,3},{9,8},{1,0},{2,7},{1,2},{4,9},{3,4}} -> 7,9",
            "{{5,6},{12,17},{16,21},{13,14},{2,7},{5,10},{13,18},{17,18},{10,11},{15,20},{21,22},{1,6},{7,8},{10,15},{15,16},{8,3},{18,23},{0,5},{6,7},{8,13},{11,12},{11,16},{22,23},{17,22},{20,21},{6,11},{16,17},{0,1},{7,12},{12,13},{2,3},{14,19},{23,24},{1,2},{8,9},{19,24},{18,19},{9,14},{4,9},{3,4}} -> 14,2"
        };

        // FIXED TESTS
        [Test, Description("10 FIXED TESTS"), TestCaseSource("FixedTests")]
        public static void FixedTesting(string s)
        {
            var ssp = s.Split(" -> ");
            int[][] inp = ssp[0].Substring(2, ssp[0].Length - 4).Split("},{", StringSplitOptions.RemoveEmptyEntries).Select(e => convrt(e)).ToArray();
            int[] sol = convrt(ssp[1]);
            Assert.That(DnB.DotsAndBoxes(inp), Is.EqualTo(sol));
        }

        // RANDOM TESTS
        [Test, Description("100 RANDOM TESTS"), TestCaseSource("RandomTests")]
        public static void RandomTesting(int[][] r)
        {
            var ref_sol = ref_func(r);

            Assert.That(DnB.DotsAndBoxes(r), Is.EqualTo(ref_sol), "Hello");
        }

        private static void Print(string s) => Console.WriteLine(s);

        private static int RR(params int[] r)
        {
            int x, y;
            switch (r.Length)
            {
                case 0: x = 0; y = 2; break;
                case 1: x = 0; y = r[0] < 2 ? 2 : r[0]; break;
                default: x = r[0]; y = r[1]; break;
            }
            return RN.Next(x, y);
        }

        // REFERENCE SOLUTION
        private static int[] ref_func(int[][] r)
        {
            int ln = default(int);
            for (int i = 1; i < 11; i++)
            {
                if (r.Length == (i + 2) * (i * 2 + 2)) { ln = i + 2; break; }
            }
            int[] codex = Enumerable.Repeat(4, (ln - 1) * (ln - 1)).ToArray();
            int player = 0;
            Func<int, int> forge = n => --codex[n] == 0 ? 1 : 0;
            return r.Aggregate(new int[] { 0, 0 }, (ix, v) =>
            {
                int turn = 0;
                int x = Math.Min(v[0], v[1]),
                    y = Math.Max(v[0], v[1]),
                    sp = (x / ln) * (ln - 1) + x % ln;
                if (y - x == 1)
                {
                    int vbord = x / ln;
                    if (vbord > 0) { turn += forge(sp - ln + 1); }
                    if (vbord < ln - 1) { turn += forge(sp); }
                }
                else
                {
                    int hbord = x % ln;
                    if (hbord != ln - 1) { turn += forge(sp); }
                    if (hbord != 0) { turn += forge(sp - 1); }
                }
                if (turn == 0) { player ^= 1; } else { ix[player] += turn; }
                return ix;
            });
        }

        private static int[] convrt(string s) => s.Split(',').Select(v => Int32.Parse(v)).ToArray();

        // RANDOM TEST GENERATOR
        private static int[][] test_gen(int n)
        {
            var D = new int[2][] { new[] { 0, 1 }, new[] { 1, 0 } };
            var ix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                ix[i] = new int[n];
                for (int j = 0; j < n; j++) { ix[i][j] = i * n + j; }
            }
            var zr = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int v = ix[i][j];
                    foreach (int[] xy in D)
                    {
                        int x = xy[0] + i;
                        int y = xy[1] + j;
                        if (x < n && y < n)
                        {
                            var zrr = new int[2] { v, ix[x][y] };
                            if (RR() == 1) { Array.Reverse(zrr); }
                            zr.Add(zrr);
                        }
                    }
                }
            }
            return shuffle(zr.ToArray());
        }

        private static int[][] shuffle(int[][] r)
        {
            for (int i = 0; i < r.Length; i++)
            {
                int q = RR(r.Length);
                var tmp = r[q];
                r[q] = r[i];
                r[i] = tmp;
            }
            return r;
        }

        // END RANDOM TEST GENERATOR
        private static IEnumerable<int[][]> RandomTests()
        {
            for (int i = 3; i < 13; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    yield return test_gen(i);
                }
            }
        }
    }
}