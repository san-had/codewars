using System;

namespace PassportProcessing.Validators
{
    public class BirthYearValidator
    {
        public static bool Validate(string value)
        {
            bool success = Int32.TryParse(value, out int byr);
            if (success)
            {
                return byr >= 1920 && byr <= 2002;
            }
            return false;
        }
    }
}