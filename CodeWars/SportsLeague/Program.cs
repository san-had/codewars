namespace SportsLeague
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberOfTeams = 6;
            string expectedResult = "4,4,6,3,1,2";
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

            int numberOfTeams2 = 6;
            string expectedResult2 = "2,3,4,1,5,6";
            int[,] games2 = new int[,]
             {
                {0, 5, 2, 0 },
                {1, 4, 2, 2 },
                {2, 3, 1, 3 },
                {1, 5, 0, 0 },
                {2, 0, 2, 1 },
                {3, 4, 3, 1 }
             };

            int numberOfTeams3 = 4;
            string expectedResult3 = "3,1,1,3";
            int[,] games3 = new int[,]
              {
                {0, 3, 1, 1 },
                {1, 2, 2, 2 },
                {1, 3, 2, 0 },
                {2, 0, 2, 0 }
              };

            int numberOfTeams4 = 10;
            string expectedResult4 = "1,1,1,1,1,1,1,1,1,1";
            int[,] games4 = new int[,]
              {
              };

            int numberOfTeams5 = 8;
            string expectedResult5 = "1,2,2,2,2,2,2,8";
            int[,] games5 = new int[,]
              {
                {0, 7, 2, 0 }
              };

            var ranks = Kata.ComputeRanks(numberOfTeams5, games5);

            Display(ranks);

            System.Console.WriteLine(expectedResult5);
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