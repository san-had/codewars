using System.Linq;

namespace AbbreviateName
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            var nameArray = name.ToUpper().Split(' ');

            return $"{nameArray[0][0]}.{nameArray[1][0]}";
        }

        public static string AbbrevName2(string name)
        {
            return string.Join(".", name.ToUpper().Split(' ').Select(w => w[0]));
        }
    }
}