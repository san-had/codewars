namespace BirdMountain
{
    public class Kata
    {
        public static int peakHeight(char[][] mountain)
        {
            char pattern = ' ';
            char nextPattern;
            int count;
            int peakHeight = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i != 0)
                {
                    pattern = char.Parse(i.ToString());
                }
                var tempNextPattern = i + 1;
                nextPattern = char.Parse(tempNextPattern.ToString());
                count = putChar(mountain, pattern, nextPattern);
                if (count == 0)
                {
                    peakHeight = i;
                    break;
                }
            }

            Program.DisplayMountain(mountain);

            return peakHeight;
        }

        private static int putChar(char[][] mountain, char boundaryChar, char newChar)
        {
            var rowMax = mountain.GetUpperBound(0);

            int count = 0;

            for (int i = 0; i < rowMax; i++)
            {
                var columnMax = mountain[i].GetLength(0);
                for (int j = 0; j < columnMax; j++)
                {
                    if (mountain[i][j] == '^')
                    {
                        if (i == 0 || j == 0 || i == rowMax || j == columnMax)
                        {
                            mountain[i][j] = newChar;
                            count++;
                            continue;
                        }

                        if (mountain[i - 1][j] == boundaryChar || mountain[i][j - 1] == boundaryChar ||
                             mountain[i + 1][j] == boundaryChar || mountain[i][j + 1] == boundaryChar)
                        {
                            mountain[i][j] = newChar;
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}