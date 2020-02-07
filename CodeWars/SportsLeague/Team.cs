using System;
using System.Diagnostics.CodeAnalysis;

namespace SportsLeague
{
    public class Team : IComparable<Team>
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

        public int Rank { get; set; }

        public int CompareTo([AllowNull] Team other)
        {
            if (other == null)
            {
                throw new ArgumentException($"{nameof(other)} is null.");
            }

            int result = CompareValues(Points, other.Points);

            if (result != 0)
            {
                return result;
            }

            result = CompareValues(GD, other.GD);

            if (result != 0)
            {
                return result;
            }

            result = CompareValues(For, other.For);

            return result;
        }

        private int CompareValues(int a, int b)
        {
            return a < b ? 1 : a > b ? -1 : 0;
        }
    }
}