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
            var squares = new List<Square>();
            var rowIndex = 0;
            var squareCounter = 0;
            var maxSquares = (int)Math.Pow((length - 1), 2);

            do
            {
                if (rowIndex == 0)
                {
                    for (int i = 0; i < length; i++)
                    {
                        squares.Add(CreateSquare(i, length));
                        squareCounter++;
                    }
                    rowIndex++;
                }
                for (int i = rowIndex * length; i < 2 * rowIndex * length - 1; i++)
                {
                    squares.Add(CreateSquare(i, length));
                    squareCounter++;
                }
                rowIndex++;
            } while (squareCounter < maxSquares);

            return squares;
        }

        private static Square CreateSquare(int st, int length)
        {
            var side1 = Tuple.Create(st, st + 1);
            var side2 = Tuple.Create(st + 1, st + 1 + length);
            var side3 = Tuple.Create(st + length, st + length + 1);
            var side4 = Tuple.Create(st, st + length);

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