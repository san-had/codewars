using System;

namespace BoxUnbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Point p = new Point();

            IPoint i1 = p;
            IPoint i2 = i1;
            i1.X = 1;
            p.X = 5;
            Console.WriteLine(i1.X);
        }
    }

    internal interface IPoint
    {
        int X { get; set; }

        int Y { get; set; }
    }

    internal struct Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}