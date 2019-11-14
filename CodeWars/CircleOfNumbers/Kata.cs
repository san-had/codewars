namespace CircleOfNumbers
{
    public class Kata
    {
        public int CircleOfNumbers(int n, int firstNumber)
        {
            var diff = n / 2;

            return firstNumber >= diff ? firstNumber - diff : firstNumber + diff;
        }
    }
}