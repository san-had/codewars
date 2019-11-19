namespace General
{
    internal class Program
    {
        private static void Main()
        {
            //var result = WellIdeas.Well(new string[] { "bad", "bad", "bad" });

            //System.Console.WriteLine(result);

            //var result = WellIdeas.Well(new string[] { "good", "bad", "bad", "bad", "bad" });

            //System.Console.WriteLine(result);

            var result = WellIdeas.Well(new string[] { "good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good" });

            System.Console.WriteLine(result);
        }
    }
}