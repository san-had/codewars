namespace SportsLeague
{
    public class Team
    {
        public int Id { get; set; }

        public int For { get; set; }

        public int Against { get; set; }

        public int GD
        {
            get
            {
                return (For - Against);
            }
        }

        public int Points { get; set; }
    }
}