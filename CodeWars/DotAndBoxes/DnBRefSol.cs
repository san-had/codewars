using System;
using System.Linq;

namespace DotAndBoxes
{
    public class DnBRefSol
    {
        public static int[] DotsAndBoxes(int[][] r)
        {
            int ln = default(int);
            for (int i = 1; i < 11; i++)
            {
                if (r.Length == (i + 2) * (i * 2 + 2))
                {
                    ln = i + 2;
                    break;
                }
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
    }
}