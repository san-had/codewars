namespace DotAndBoxes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var moves = new int[][]
            {
                new[] { 0, 1 },
                new[] { 7, 8 },
                new[] { 1, 2 },
                new[] { 6, 7 },
                new[] { 0, 3 },
                new[] { 8, 5 },
                new[] { 3, 4 },
                new[] { 4, 1 },
                new[] { 4, 5 },
                new[] { 2, 5 },
                new[] { 7, 4 },
                new[] { 3, 6 }
            };
            var result = DnB.DotsAndBoxes(moves);

            foreach (var item in result)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}