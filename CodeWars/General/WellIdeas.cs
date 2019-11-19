using System.Linq;

namespace General
{
    public class WellIdeas
    {
        public static string Well(string[] ideas)
        {
            const string fewGood = "Publish!";

            const string moreGood = "I smell a series!";

            const string noGood = "Fail!";

            var goodIdeas = ideas.Count(x => x == "good");

            var result = string.Empty;

            switch (goodIdeas)
            {
                case 1:
                case 2:
                    result = fewGood;
                    break;

                case int n when n > 2:
                    result = moreGood;
                    break;

                default:
                    result = noGood;
                    break;
            }

            return result;
        }
    }
}