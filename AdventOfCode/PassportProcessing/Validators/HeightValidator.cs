using System;

namespace PassportProcessing.Validators
{
    public class HeightValidator
    {
        public static bool Validate(string value)
        {
            int lastTwoIndex = value.Length - 2;
            string measurement = value.Substring(lastTwoIndex);
            string heightString = value.Substring(0, lastTwoIndex);
            bool success = Int32.TryParse(heightString, out int hgt);
            if (success)
            {
                if (measurement == "cm")
                {
                    return hgt >= 150 && hgt <= 193;
                }
                else if (measurement == "in")
                {
                    return hgt >= 59 && hgt <= 76;
                }
            }
            return false;
        }
    }
}