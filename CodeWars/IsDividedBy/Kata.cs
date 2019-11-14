namespace IsDividedBy
{
    public class Kata
    {
        public static bool is_divide_by(int number, int a, int b)
        {
            return number % a == 0 && number % b == 0;
        }
    }
}