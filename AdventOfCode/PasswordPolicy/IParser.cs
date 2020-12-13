namespace PasswordPolicy
{
    internal interface IParser
    {
        PasswordDto ParseLine(string line);
    }
}