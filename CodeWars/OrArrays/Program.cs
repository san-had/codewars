namespace OrArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunCountLetters();
        }

        private static void RunCountLetters()
        {
            var result = KataLettersCount.LetterCount("arithmetics");

            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void RunOrArrays()
        {
            int[] array1 = { 1, 2 };

            int[] array2 = { 4, 5, 6 };

            var result = Kata2.OrArrays(array1, array2, 3);

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}