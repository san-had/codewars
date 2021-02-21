using System.Text.RegularExpressions;

namespace PassportProcessing.Validators
{
    public class PassportIdValidator
    {
        public static bool Validate(string value)
        {
            if (value.Length == 9)
            {
                string pattern = @"[0-9]{9}";
                Match m = Regex.Match(value, pattern);
                return m.Success;
            }
            return false;
        }
    }
}