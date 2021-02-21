using System.Text.RegularExpressions;

namespace PassportProcessing.Validators
{
    public class HairColorValidator
    {
        public static bool Validate(string value)
        {
            if (value.Length == 7)
            {
                string pattern = @"#[a-f0-9]{6}";
                Match m = Regex.Match(value, pattern);
                return m.Success;
            }
            return false;
        }
    }
}