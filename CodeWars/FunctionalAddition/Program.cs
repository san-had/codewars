namespace FunctionalAddition
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result = Kata.Add(1)(3);

            System.Console.WriteLine(result);

            var result2 = Kata.Add(-208)(3);

            System.Console.WriteLine(result2);
        }
    }
}