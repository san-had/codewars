namespace SportsLeague
{
    public class Kata
    {
        public static int[] ComputeRanks(int numberOfTeams, int[,] games)
        {
            int[] ranks = new int[numberOfTeams];

            for (int i = 0; i < games.GetLength(0); i++)
            {
                var team1Id = games[i, 0];
                var team2Id = games[i, 1];

                var team1Score = games[i, 2];
                var team2Score = games[i, 3];
            }

            return ranks;
        }

        private static IEnumerable<Team> CreateTeams(int numberOfTeams)
        {
            for (int i = 0; i < numberOfTeams; i++)
            {
                yield return new Team
                {
                    Id = i
                };
            }
        }
    }
}