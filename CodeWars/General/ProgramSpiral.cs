using System;

namespace General
{
    public class ProgramSpiral
    {
        private static void Main2()
        {
            int N = 4;

            var spiralArray = KataSpiral.CreateSpiral(N);

            DisplaySpiral(spiralArray);
        }

        private static void DisplaySpiral(int[,] spiralArray)
        {
            var dimension = spiralArray.GetLength(0);

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Console.Write($"{spiralArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}