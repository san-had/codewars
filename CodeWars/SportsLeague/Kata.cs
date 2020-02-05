using System.Collections.Generic;
using System.Linq;

namespace SportsLeague
{
    public class Kata
    {
        public static int[] ComputeRanks(int numberOfTeams, int[,] games)
        {
            int[] ranks = new int[numberOfTeams];

            var teams = CreateTeams(numberOfTeams).ToList();

            for (int i = 0; i < games.GetLength(0); i++)
            {
                var team1 = teams[games[i, 0]];
                var team2 = teams[games[i, 1]];

                var team1Score = games[i, 2];
                var team2Score = games[i, 3];

                UpdateTeam(team1, team1Score, team2Score);
                UpdateTeam(team2, team2Score, team1Score);
            }

            UpdateTeamRanks(teams);

            foreach (var team in teams)
            {
                System.Console.WriteLine($"{team.Id} {team.For} {team.Against} {team.GD} {team.Points} {team.Rank}");
            }

            return UpdateRanks(teams).ToArray<int>();
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

        private static void UpdateTeam(Team team, int vor, int against)
        {
            team.For += vor;
            team.Against += against;

            team.Points += vor == against ? 1 : vor > against ? 2 : 0;
        }

        private static void UpdateTeamRanks(List<Team> teams)
        {
            int rank = 1;
            var sortedTeams = teams
               .OrderByDescending(t => t.Points)
                .ThenByDescending(x => x.GD)
                .ThenByDescending(x => x.For)
                .ToArray();
            int sortedTeamsLength = sortedTeams.Count();
            for (int index = 0; index < sortedTeamsLength; index++)
            {
                var teamIndex = sortedTeams[index].Id;
                teams[teamIndex].Rank = rank;
                var nextIsEqual = (index + 1 < sortedTeamsLength) && IsEqual(sortedTeams[index], sortedTeams[index + 1]);
                if (nextIsEqual)
                {
                    var nextTeamIndex = sortedTeams[index + 1].Id;
                    teams[nextTeamIndex].Rank = rank;
                    index++;
                    rank++;
                }
                rank++;
            }
        }

        private static bool IsEqual(Team teamA, Team teamB)
        {
            if (teamA.Points == teamB.Points && teamA.GD == teamB.GD && teamA.For == teamB.For)
            {
                return true;
            }
            return false;
        }

        private static IEnumerable<int> UpdateRanks(List<Team> teams)
        {
            foreach (var team in teams)
            {
                yield return team.Rank;
            }
        }
    }
}