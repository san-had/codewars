using System;

namespace PassportProcessing.Validators
{
    public class EyeColorValidator
    {
        public static bool Validate(string value)
        {
            string[] colors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

            if (value.Length == 3)
            {
                return Array.IndexOf(colors, value) != -1;
            }
            return false;
        }
    }
}