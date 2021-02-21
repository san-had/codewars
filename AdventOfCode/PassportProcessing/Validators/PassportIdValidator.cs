using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PassportProcessing.Validators
{
    public class PassportIdValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "pid";
            string value = passport[key];

            if (value.Length == 9)
            {
                string pattern = @"[0-9]{9}";
                Match m = Regex.Match(value, pattern);
                if (m.Success)
                {
                    base.Validate(passport);
                }
                else
                {
                    throw new ValidationException($"Invalid pid value: {value}");
                }
            }
            else
            {
                throw new ValidationException($"Invalid pid value: {value}");
            }
        }
    }
}