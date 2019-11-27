using System.Linq;

namespace General
{
    public class IntroArt5
    {
        private const char Space = ' ';
        private const char Asterisk = '*';

        public static string[] GetW(int height)
        {
            var line = Enumerable.Range(0, height)
                .Select(i => $"{new string(Space, i)}{Asterisk}{new string(Space, height - i - 1)}");

            var vue = line.Zip(line.Select(s => s.Reverse()), (s1, s2) => s1.Concat(s2.Skip(1)));

            var doubleyew = vue.Zip(vue.Select(s => s.Reverse()), (s1, s2) => s1.Concat(s2.Skip(1)));

            return doubleyew.Select(s => string.Concat(s)).ToArray();
        }
    }
}