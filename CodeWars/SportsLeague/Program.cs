namespace SportsLeague
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberOfTeams = 6;
            int[,] games = new int[,]
            {
                {0, 5, 2, 2 },
                {1, 4, 0, 2 },
                {2, 3, 1, 2 },
                {1, 5, 2, 2 },
                {2, 0, 1, 1 },
                {3, 4, 1, 1 },
                {2, 5, 0, 2 },
                {3, 1, 1, 1 },
                {4, 0, 2, 0 }
            };

            var ranks = Kata.ComputeRanks(numberOfTeams, games);

            Display(ranks);
        }

        private static void Display(int[] ranks)
        {
            for (int i = 0; i < ranks.Length; i++)
            {
                System.Console.WriteLine($"Team{i.ToString()} has rank:{ranks[i].ToString()}");
            }
        }
    }
}