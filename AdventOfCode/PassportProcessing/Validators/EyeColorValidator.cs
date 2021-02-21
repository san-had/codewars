using System;
using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public class EyeColorValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "ecl";
            string value = passport[key];

            string[] colors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

            if (value.Length == 3)
            {
                if (Array.IndexOf(colors, value) != -1)
                {
                    base.Validate(passport);
                }
                else
                {
                    throw new ValidationException($"Invalid ecl value: {value}");
                }
            }
            else
            {
                throw new ValidationException($"Invalid ecl value: {value}");
            }
        }
    }
}