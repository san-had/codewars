namespace SportsLeague
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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

            //var games =  [[0, 5, 2, 2]];   // Team 0 - Team 5 => 2:2
            //            //[1, 4, 0, 2],   // Team 1 - Team 4 => 0:2
            //            //[2, 3, 1, 2],   // Team 2 - Team 3 => 1:2
            //            //[1, 5, 2, 2],   // Team 1 - Team 5 => 2:2
            //            //[2, 0, 1, 1],   // Team 2 - Team 0 => 1:1
            //            //[3, 4, 1, 1],   // Team 3 - Team 4 => 1:1
            //            //[2, 5, 0, 2],   // Team 2 - Team 5 => 0:2
            //            //[3, 1, 1, 1],   // Team 3 - Team 1 => 1:1
            //            //[4, 0, 2, 0]]   // Team 4 - Team 0 => 2:0
        }
    }
}