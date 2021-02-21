using System;
using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public class BirthYearValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "byr";
            string value = passport[key];
            bool success = Int32.TryParse(value, out int byr);
            if (success)
            {
                if (byr >= 1920 && byr <= 2002)
                {
                    base.Validate(passport);
                }
                else
                {
                    throw new ValidationException($"Invalid byr value: {value}");
                }
            }
            else
            {
                throw new ValidationException($"Invalid byr value: {value}");
            }
        }
    }
}