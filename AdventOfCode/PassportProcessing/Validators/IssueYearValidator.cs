using System;

namespace PassportProcessing.Validators
{
    public class IssueYearValidator
    {
        public static bool Validate(string value)
        {
            bool success = Int32.TryParse(value, out int iyr);
            if (success)
            {
                return iyr >= 2010 && iyr <= 2020;
            }
            return false;
        }
    }
}