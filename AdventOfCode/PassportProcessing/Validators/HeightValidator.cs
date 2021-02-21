using System;
using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public class HeightValidator : BaseValidator
    {
        public override void Validate(Dictionary<string, string> passport)
        {
            string key = "hgt";
            string value = passport[key];

            int lastTwoIndex = value.Length - 2;
            string measurement = value.Substring(lastTwoIndex);
            string heightString = value.Substring(0, lastTwoIndex);
            bool success = Int32.TryParse(heightString, out int hgt);
            if (success)
            {
                if (measurement == "cm")
                {
                    if (hgt >= 150 && hgt <= 193)
                    {
                        base.Validate(passport);
                    }
                    else
                    {
                        throw new ValidationException($"Invalid hgt value: {value}");
                    }
                }
                else if (measurement == "in")
                {
                    if (hgt >= 59 && hgt <= 76)
                    {
                        base.Validate(passport);
                    }
                    else
                    {
                        throw new ValidationException($"Invalid hgt value: {value}");
                    }
                }
            }
            else
            {
                throw new ValidationException($"Invalid hgt value: {value}");
            }
        }
    }
}