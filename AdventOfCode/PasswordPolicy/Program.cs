using System.Collections.Generic;
using System.IO;

namespace PasswordPolicy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputList = ReadInput();

            var passwordList = new List<PasswordDto>();
            var parser = new Parser();

            foreach (var line in inputList)
            {
                passwordList.Add(parser.ParseLine(line));
            }

            var passwordValidator = new PasswordValidator();
            int rightPasswordCounter = 0;
            foreach (var password in passwordList)
            {
                if (passwordValidator.IsValidPasswordNew(password))
                {
                    rightPasswordCounter++;
                }
            }
            System.Console.WriteLine(rightPasswordCounter);
        }

        private static List<string> ReadInput()
        {
            var lines = new List<string>();

            using (StreamReader reader = new StreamReader("passwords.txt"))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}