namespace DotAndBoxes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var moves = new int[][]
            {
                //new[] { 0, 1 },
                //new[] { 7, 8 },
                //new[] { 1, 2 },
                //new[] { 6, 7 },
                //new[] { 0, 3 },
                //new[] { 8, 5 },
                //new[] { 3, 4 },
                //new[] { 4, 1 },
                //new[] { 4, 5 },
                //new[] { 2, 5 },
                //new[] { 7, 4 },
                //new[] { 3, 6 }

new[] {23, 22},
new[] {13, 6},
new[] {45, 38},
new[] {2, 3},
new[] {43, 44},
new[] {41, 48},
new[] {24, 25},
new[] {11, 4},
new[] {28, 21},
new[] {18, 11},
new[] {19, 12},
new[] {37, 36},
new[] {43, 42},
new[] {7, 0},
new[] {14, 15},
new[] {47, 40},
new[] {30, 23},
new[] {16, 17},
new[] {15, 22},
new[] {10, 17},
new[] {45, 46},
new[] {24, 17},
new[] {28, 35},
new[] {32, 31},
new[] {27, 26},
new[] {14, 21},
new[] {36, 43},
new[] {30, 29},
new[] {18, 17},
new[] {30, 37},
new[] {19, 26},
new[] {35, 42},
new[] {18, 25},
new[] {15, 8},
new[] {34, 41},
new[] {3, 4},
new[] {16, 9},
new[] {20, 27},
new[] {19, 20},
new[] {29, 36},
new[] {12, 11},
new[] {39, 32},
new[] {25, 26},
new[] {34, 27},
new[] {2, 9},
new[] {13, 20},
new[] {29, 28},
new[] {38, 31},
new[] {5, 12},
new[] {31, 30},
new[] {40, 41},
new[] {18, 19},
new[] {36, 35},
new[] {23, 16},
new[] {1, 8},
new[] {22, 29},
new[] {1, 2},
new[] {5, 4},
new[] {40, 33},
new[] {7, 14},
new[] {21, 22},
new[] {34, 33},
new[] {44, 45},
new[] {47, 46},
new[] {38, 37},
new[] {10, 3},
new[] {7, 8},
new[] {47, 48},
new[] {9, 10},
new[] {12, 13},
new[] {11, 10},
new[] {32, 25},
new[] {16, 15},
new[] {24, 23},
new[] {33, 26},
new[] {5, 6},
new[] {46, 39},
new[] {0, 1},
new[] {33, 32},
new[] {8, 9},
new[] {24, 31},
new[] {40, 39},
new[] {37, 44},
new[] {38, 39}
            };
            var result = DnBRefSol.DotsAndBoxes(moves);

            //var result = DnB.DotsAndBoxes(moves);

            foreach (var item in result)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}