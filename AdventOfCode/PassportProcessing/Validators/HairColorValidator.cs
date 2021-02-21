using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PassportProcessing.Validators
{
    public class HairColorValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "hcl";
            string value = passport[key];

            if (value.Length == 7)
            {
                string pattern = @"#[a-f0-9]{6}";
                Match m = Regex.Match(value, pattern);
                if (m.Success)
                {
                    base.Validate(passport);
                }
                else
                {
                    throw new ValidationException($"Invalid hcl value: {value}");
                }
            }
            else
            {
                throw new ValidationException($"Invalid hcl value: {value}");
            }
        }
    }
}