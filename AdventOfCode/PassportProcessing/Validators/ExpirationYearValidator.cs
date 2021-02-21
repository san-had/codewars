using System;

namespace PassportProcessing.Validators
{
    public class ExpirationYearValidator
    {
        public static bool Validate(string value)
        {
            bool success = Int32.TryParse(value, out int eyr);
            if (success)
            {
                return eyr >= 2020 && eyr <= 2030;
            }
            return false;
        }
    }
}