using System;
using System.Linq;

namespace General
{
    public class BorrowerSpeak
    {
        public static string Borrow(string inputText)
        {
            string result = new string(
                inputText.ToLower().ToCharArray()
                .Where(c => Char.IsLetter(c))
                .ToArray());

            return result;
        }
    }
}