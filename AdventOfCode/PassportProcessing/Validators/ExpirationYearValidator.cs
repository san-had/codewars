using System;
using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public class ExpirationYearValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "eyr";
            string value = passport[key];
            bool success = Int32.TryParse(value, out int eyr);
            if (success)
            {
                if (eyr >= 2020 && eyr <= 2030)
                {
                    base.Validate(passport);
                }
                else
                {
                    throw new ValidationException($"Invalid eyr value: {value}");
                }
            }
            else
            {
                throw new ValidationException($"Invalid eyr value: {value}");
            }
        }
    }
}