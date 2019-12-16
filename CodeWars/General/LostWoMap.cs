using System.Linq;

namespace General
{
    public class LostWoMap
    {
        public static int[] Maps(int[] input)
        {
            var query = input.Select(x => 2 * x).ToArray();
            return query;
        }
    }
}