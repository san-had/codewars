using System.Linq;

namespace General
{
    public class IntroArt5
    {
        public static string[] GetW(int height)
        {
            var line = Enumerable.Range(0, height)
                .Select(i => $"{ new string(' ', i)}*{new string(' ', height - 1 - i)}");

            var vee = line.Zip(line.Select(s => s.Reverse()), (s1, s2) => s1.Concat(s2.Skip(1)));
            var doubleyew = vee.Zip(vee.Select(s => s.Reverse()), (s1, s2) => s1.Concat(s2.Skip(1)));

            var result = doubleyew.Select(s => string.Concat(s)).ToArray();

            return result;
        }
    }
}