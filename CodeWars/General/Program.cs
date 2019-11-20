namespace General
{
    internal class Program
    {
        private static void Main()
        {
            var height = 3;

            var result = IntroToArt.GetW(height);

            Display(result);
        }

        private static void Display(string[] intoArt)
        {
            foreach (var row in intoArt)
            {
                System.Console.WriteLine(row);
            }
        }
    }
}