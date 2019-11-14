using System.Collections.Generic;

namespace Nullable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int>();
            var str = "original";
            PassReferenceByValue(out list, ref str);
        }

        private static void PassReferenceByValue(out List<int> list, ref string str)
        {
            //list.Add(1);
            list = new List<int>(new[] { 2 });
            str = "modified";
        }
    }

    internal struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;

            Y = y;
        }
    }
}