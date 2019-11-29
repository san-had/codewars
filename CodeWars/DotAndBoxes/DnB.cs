using System;
using System.Collections.Generic;

namespace DotAndBoxes
{
    public class DnB
    {
        public static int[] DotsAndBoxes(int[][] moves)
        {
            var result = new int[2] { 3, 1 };

            var length = 3;

            var square1 = CreateSquare(length);

            return result;
        }

        private static List<Square> CreateSquares(int length)
        {
        }

        private static Square CreateSquare(int length)
        {
            var side1 = Tuple.Create(0, 1);
            var side2 = Tuple.Create(1, 4);
            var side3 = Tuple.Create(3, 4);
            var side4 = Tuple.Create(0, 3);

            var square = new Square()
            { Sides = { side1, side2, side3, side4 } };

            return square;
        }
    }

    internal class Square
    {
        public List<Tuple<int, int>> Sides { get; set; }
    }
}