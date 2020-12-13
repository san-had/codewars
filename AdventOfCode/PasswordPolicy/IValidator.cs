namespace PasswordPolicy
{
    public interface IValidator
    {
        bool IsValidPassword(PasswordDto password);
    }
}