using System.Linq;

namespace Exercise
{
    internal class Program
    {
        private static void Main()
        {
            int[] numbers = { 1, 2, 3 };

            string[] words = { "One", "Two", "Three" };

            var zipped = numbers.Zip(words, (a1, a2) => string.Concat($"{a2} : {a1.ToString()}"));

            foreach (var item in zipped)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}