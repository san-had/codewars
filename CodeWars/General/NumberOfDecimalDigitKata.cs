namespace General
{
    public class NumberOfDecimalDigitKata
    {
        public static int Digits(ulong n)
        {
            return n.ToString().Length;
        }
    }
}