using System;

namespace PasswordPolicy
{
    internal class Parser : IParser
    {
        public PasswordDto ParseLine(string line)
        {
            var passwordDto = new PasswordDto();

            var firstSplit = line.Split(' ');

            var minMax = firstSplit[0].Split('-');

            passwordDto.MinOccurance = Int32.Parse(minMax[0]);
            passwordDto.MaxOccurance = Int32.Parse(minMax[1]);

            passwordDto.Letter = firstSplit[1][0];

            passwordDto.Password = firstSplit[2].ToLower();

            return passwordDto;
        }
    }
}