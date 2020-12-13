using System.Linq;

namespace PasswordPolicy
{
    public class PasswordValidator : IValidator
    {
        public bool IsValidPassword(PasswordDto password)
        {
            bool isValid = false;
            int charCount = password.Password.ToCharArray().Where(ch => ch == password.Letter).Count();
            if (charCount >= password.MinOccurance && charCount <= password.MaxOccurance)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}