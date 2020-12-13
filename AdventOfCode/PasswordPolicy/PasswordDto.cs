namespace PasswordPolicy
{
    public class PasswordDto
    {
        public int MinOccurance { get; set; }

        public int MaxOccurance { get; set; }

        public char Letter { get; set; }

        public string Password { get; set; }

        public bool IsValid { get; set; }
    }
}