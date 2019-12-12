using System;
using System.Linq;

namespace DotAndBoxes
{
    internal class DnBSol
    {
        public static int[] DotsAndBoxes(int[][] r)
        {
            int[] score = { 0, 0 };
            int n = (int)Math.Sqrt(r.Length / 2) + 1;
            var boxes = Enumerable.Range(n, n * n - n).Where(i => i % n > 0).Select(i =>
                      new int[][] { new[] { i - n - 1, i - n }, new[] { i - n - 1, i - 1 }, new[] { i - 1, i }, new[] { i - n, i } }).ToArray();
            var boxSides = new int[n * n];

            for (int l = 0, pts = 0, turn = 0; l < r.Length; l++, pts = 0, turn++)
            {
                Array.Sort(r[l]);
                for (int i = 0; i < boxes.Length; i++)
                {
                    if (boxes[i].Any(z => z[0] == r[l][0] && z[1] == r[l][1]))
                    {
                        boxSides[i]++;
                        if (boxSides[i] == 4) pts++;
                    }
                }
                if (pts > 0) score[(turn--) % 2] += pts;
            }
            return score;
        }
    }
}