using System;
using System.Collections.Generic;

namespace DotAndBoxes
{
    public class DnB
    {
        public static int[] DotsAndBoxes(int[][] moves)
        {
            var result = new int[2] { 0, 0 };

            var length = 3;

            var squares = CreateSquares(length);

            int playerIndex = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                var score = FindMove(squares, moves[i]);
                if (score > 0)
                {
                    result[playerIndex] += score;
                }
                else
                {
                    playerIndex = playerIndex == 0 ? ++playerIndex : --playerIndex;
                }
            }

            return result;
        }

        private static int FindMove(List<Square> squares, int[] move)
        {
            if (move[0] > move[1])
            {
                move = swap(move);
            }

            var squareIndex = 0;

            var sideIndex = 0;

            int score = 0;

            Tuple<int, int> inputSide;

            inputSide = Tuple.Create(move[0], move[1]);

            //var sides = squares
            //    .SelectMany(x => x.Sides)
            //    .Where(x => x.Item1 == inputSide.Item1 && x.Item2 == inputSide.Item2);

            for (int i = 0; i < squares.Count; i++)
            {
                for (int j = 0; j < squares[i].Sides.Count; j++)
                {
                    if (inputSide.Item1 == squares[i].Sides[j].Item1 && inputSide.Item2 == squares[i].Sides[j].Item2)
                    {
                        squareIndex = i;
                        sideIndex = j;
                        if (RemoveSide(squares, squareIndex, sideIndex))
                        {
                            score++;
                        }
                    }
                }
            }
            return score;
        }

        private static bool RemoveSide(List<Square> squares, int squareIndex, int sideIndex)
        {
            bool isScore = false;

            var square = squares[squareIndex];

            square.Sides.Remove(square.Sides[sideIndex]);

            if (square.Sides.Count == 0)
            {
                isScore = true;
            }
            return isScore;
        }

        private static int[] swap(int[] move)
        {
            var tmp = new int[2];
            tmp[0] = move[1];
            tmp[1] = move[0];
            return tmp;
        }

        private static List<Square> CreateSquares(int length)
        {
            var square1 = CreateSquare1(length);

            var square2 = CreateSquare2(length);

            var square3 = CreateSquare3(length);

            var square4 = CreateSquare4(length);

            var squares = new List<Square>
            {
                square1, square2, square3, square4
            };

            return squares;
        }

        private static Square CreateSquare1(int length)
        {
            var side1 = Tuple.Create(0, 1);
            var side2 = Tuple.Create(1, 4);
            var side3 = Tuple.Create(3, 4);
            var side4 = Tuple.Create(0, 3);

            var square = new Square()
            { Sides = new List<Tuple<int, int>>() { side1, side2, side3, side4 } };

            return square;
        }

        private static Square CreateSquare2(int length)
        {
            var side1 = Tuple.Create(1, 2);
            var side2 = Tuple.Create(1, 4);
            var side3 = Tuple.Create(4, 5);
            var side4 = Tuple.Create(2, 5);

            var square = new Square()
            { Sides = new List<Tuple<int, int>>() { side1, side2, side3, side4 } };

            return square;
        }

        private static Square CreateSquare3(int length)
        {
            var side1 = Tuple.Create(3, 4);
            var side2 = Tuple.Create(3, 6);
            var side3 = Tuple.Create(4, 7);
            var side4 = Tuple.Create(6, 7);

            var square = new Square()
            { Sides = new List<Tuple<int, int>>() { side1, side2, side3, side4 } };

            return square;
        }

        private static Square CreateSquare4(int length)
        {
            var side1 = Tuple.Create(4, 5);
            var side2 = Tuple.Create(4, 7);
            var side3 = Tuple.Create(5, 8);
            var side4 = Tuple.Create(7, 8);

            var square = new Square()
            { Sides = new List<Tuple<int, int>>() { side1, side2, side3, side4 } };

            return square;
        }
    }

    internal class Square
    {
        public List<Tuple<int, int>> Sides { get; set; }
    }
}