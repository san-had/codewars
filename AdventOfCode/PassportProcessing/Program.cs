using System.Collections.Generic;
using Common;
using PassportProcessing.Validators;

namespace PassportProcessing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lines = new InputReader().ReadInput();

            var passportDataCollection = GetPassportData(lines);

            var validPassports = GetValidPassports(passportDataCollection);

            var parsedPassports = GetParsedPassports(validPassports);

            var validPassportsNumber = ValidatePassports(parsedPassports);

            System.Console.WriteLine($"Number of valid passports: {validPassportsNumber}");
        }

        private static int ValidatePassports(List<Dictionary<string, string>> passports)
        {
            int validPassportsNumber = 0;
            foreach (var passport in passports)
            {
                if (ValidatePassport(passport))
                {
                    validPassportsNumber++;
                }
            }
            return validPassportsNumber;
        }

        private static bool ValidatePassport(Dictionary<string, string> passport)
        {
            bool valid = true;
            foreach (var field in passport)
            {
                switch (field.Key)
                {
                    case "byr":
                        valid = BirthYearValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "iyr":
                        valid = IssueYearValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "eyr":
                        valid = ExpirationYearValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "hgt":
                        valid = HeightValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "hcl":
                        valid = HairColorValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "ecl":
                        valid = EyeColorValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "pid":
                        valid = PassportIdValidator.Validate(field.Value);
                        if (valid == false)
                        {
                            return valid;
                        };
                        break;

                    case "cid":
                        return true;

                    default:
                        break;
                }
            }
            return valid;
        }

        private static List<Dictionary<string, string>> GetParsedPassports(List<string> passports)
        {
            var parsedPassports = new List<Dictionary<string, string>>();
            var parsedPassport = new Dictionary<string, string>();

            foreach (var passport in passports)
            {
                var fields = passport.Split(' ');
                var parsedKeyValuePair = new Dictionary<string, string>();
                foreach (var field in fields)
                {
                    var keyValuePairs = field.Split(':');
                    parsedKeyValuePair.Add(keyValuePairs[0], keyValuePairs[1]);
                }
                parsedPassports.Add(parsedKeyValuePair);
            }
            return parsedPassports;
        }

        private static List<string> GetValidPassports(List<string> passportDataCollection)
        {
            List<string> validPassports = new List<string>();

            string[] fields = { "byr:", "iyr:", "eyr:", "hgt:", "hcl:", "ecl:", "pid:" };

            foreach (var passport in passportDataCollection)
            {
                System.Console.WriteLine(passport);
                bool isValid = true;
                foreach (var field in fields)
                {
                    if (passport.IndexOf(field) == -1)
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    validPassports.Add(passport);
                }
            }
            return validPassports;
        }

        private static List<string> GetPassportData(List<string> lines)
        {
            List<string> passportDataCollection = new List<string>();

            string passportData = string.Empty;
            foreach (var line in lines)
            {
                if (line.Length > 0)
                {
                    passportData += " " + line;
                }
                else
                {
                    passportDataCollection.Add(passportData.Trim());
                    passportData = string.Empty;
                }
            }
            if (!string.IsNullOrEmpty(passportData))
            {
                passportDataCollection.Add(passportData.Trim());
            }
            return passportDataCollection;
        }
    }
}