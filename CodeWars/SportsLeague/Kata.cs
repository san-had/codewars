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
            //int point = teams.Max(t => t.Points);
            //do
            //{
            //    var selectedTeams = teams.Where(t => t.Points == point);
            //    if (selectedTeams.Count() == 1)
            //    {
            //        int teamIndex = selectedTeams.First().Id;
            //        teams[teamIndex].Rank = rank;
            //    }
            //    else
            //    {
            //        int gd = selectedTeams.Max(t => t.GD);
            //        var selectedTeamsGD = selectedTeams.Where(t => t.GD == gd);
            //        if (selectedTeamsGD.Count() == 1)
            //        {
            //            int teamIndex = selectedTeamsGD.First().Id;
            //            teams[teamIndex].Rank = rank;
            //        }
            //    }
            //} while (true);

            foreach (var team in teams.OrderByDescending(t => t.Points).ThenByDescending(x => x.GD))
            {
                var teamIndex = team.Id;
                teams[teamIndex].Rank = rank;
                rank++;
            }

            foreach (var team in teams.GroupBy(t => t.Points))
            {
            }
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