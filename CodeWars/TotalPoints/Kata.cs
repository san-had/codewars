namespace TotalPoints
{
    public static class Kata
    {
        public static int TotalPoints(string[] games)
        {
            int totalPoints = 0;
            foreach (var game in games)
            {
                var scores = game.Split(':');
                int score1 = int.Parse(scores[0]);
                int score2 = int.Parse(scores[1]);
                if (score1 == score2)
                {
                    totalPoints++;
                    continue;
                }
                if (score1 > score2)
                {
                    totalPoints += 3;
                }
            }
            return totalPoints;
        }
    }
}