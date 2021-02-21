using System;
using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public class IssueYearValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "iyr";
            string value = passport[key];

            bool success = Int32.TryParse(value, out int iyr);
            if (success)
            {
                if (iyr >= 2010 && iyr <= 2020)
                {
                    base.Validate(passport);
                }
                else
                {
                    throw new ValidationException($"Invalid iyr value: {value}");
                }
            }
            else
            {
                throw new ValidationException($"Invalid iyr value: {value}");
            }
        }
    }
}