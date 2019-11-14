using System;

namespace BirdMountain
{
    internal class Program
    {
        public static void DisplayMountain(char[][] mountain)
        {
            for (int i = 0; i < mountain.GetLength(0); i++)
            {
                for (int j = 0; j < mountain[i].GetLength(0); j++)
                {
                    Console.Write(mountain[i][j]);
                }
                Console.WriteLine();
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char[][] mountain =
            {
                  "^^^^^^        ".ToCharArray(),
                  " ^^^^^^^^     ".ToCharArray(),
                  "  ^^^^^^^     ".ToCharArray(),
                  "  ^^^^^       ".ToCharArray(),
                  "  ^^^^^^^^^^^ ".ToCharArray(),
                  "  ^^^^^^      ".ToCharArray(),
                  "  ^^^^        ".ToCharArray()
            };

            Console.WriteLine(mountain.Rank);

            DisplayMountain(mountain);

            var height = Kata.peakHeight(mountain);

            Console.WriteLine(height);
        }
    }
}