namespace General
{
    internal class Program
    {
        private static void Main()
        {
            var height = 5;

            var result = IntroArt5.GetW(height);

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