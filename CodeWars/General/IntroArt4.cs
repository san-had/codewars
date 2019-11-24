using System.Linq;

namespace General
{
    public class IntroArt4
    {
        public static string[] GetW(int height)
        {
            if (height < 2)
            {
                return new string[0];
            }

            var line = Enumerable.Range(0, height)
                .Select(i => $"{new string(' ', i)}*{new string(' ', height - i - 1)}");

            var vee = line.Zip(line.Select(s => s.Reverse()), (s1, s2) => s1.Concat(s2.Skip(1)));
            var doubleyew = vee.Zip(vee.Select(s => s.Reverse()), (s1, s2) => s1.Concat(s2.Skip(1)));
            return doubleyew.Select(s => string.Concat(s)).ToArray();
        }
    }
}