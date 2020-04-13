using System.Linq;

namespace General
{
    public class ExpressionsMatterKata
    {
        public static int ExpressionMatter2(int a, int b, int c)
        {
            int[] results = {
                a + (b * c),
                (a + b) * c,
                a * (b + c),
                (a * b) + c,
                a + b + c,
                a * b * c};
            return results.Max();
        }

        public static int ExpressionsMatter(int a, int b, int c)
        {
            if (a == 1 && c == 1)
            {
                return a + b + c;
            }

            if (a == 1 && b == 1)
            {
                return (a + b) * c;
            }

            if (a == 1)
            {
                return (a + b) * c;
            }

            if (b == 1)
            {
                if (a >= c)
                {
                    return a * (b + c);
                }
                else
                {
                    return (a + b) * c;
                }
            }

            if (c == 1)
            {
                return a * (b + c);
            }

            return a * b * c;
        }
    }
}