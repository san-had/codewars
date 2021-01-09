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

        public bool IsValidPasswordNew(PasswordDto password)
        {
            bool isValid = false;

            bool firstPositionOk = password.Password[password.MinOccurance - 1] == password.Letter;
            bool lastPositionOk = password.Password[password.MaxOccurance - 1] == password.Letter;

            if ((firstPositionOk && !lastPositionOk) || (!firstPositionOk && lastPositionOk))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}