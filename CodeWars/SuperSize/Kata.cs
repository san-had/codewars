using System.Linq;

namespace SuperSize
{
    public class Kata
    {
        public static long SuperSize(long num)
        {
            //var stringArray = num.ToString().ToCharArray().OrderByDescending(ch => ch).Select(ch => ch.ToString());

            //var strResult = stringArray.Aggregate((a, b) => a + b);

            var strResult = string.Concat(num.ToString().OrderByDescending(ch => ch));

            return long.Parse(strResult);
        }

        internal static string Aggregating()
        {
            var stringArray = new[] { "1", "2", "3" }.OrderByDescending(str => str);

            var finalString = stringArray.Aggregate((a, b) => a + "" + b);

            return finalString;
        }
    }
}