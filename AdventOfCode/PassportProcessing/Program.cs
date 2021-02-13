using System.Collections.Generic;
using Common;

namespace PassportProcessing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lines = new InputReader().ReadInput();

            var passportDataCollection = GetPassportData(lines);

            var validPassportsNumber = CountValidPassports(passportDataCollection);

            System.Console.WriteLine($"Number of valid passports: {validPassportsNumber}");
        }

        private static int CountValidPassports(List<string> passportDataCollection)
        {
            int validPassportCounter = 0;
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
                    validPassportCounter++;
                }
            }
            return validPassportCounter;
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