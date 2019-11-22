namespace General
{
    public class IntroToArt
    {
        private const string Asterisk = "*";
        private const string Space = " ";

        public static string[] GetW(int height)
        {
            const int directionLength = 4;

            var rowArray = CreateArray(height);

            bool isFirstRow = true;

            for (int i = 0; i < directionLength; i++)
            {
                if (i != 0)
                {
                    isFirstRow = false;
                }

                if (i % 2 == 0)
                {
                    MoveDown(isFirstRow, height, rowArray);
                }
                else
                {
                    MoveUp(height, rowArray);
                }
            }

            return rowArray;
        }

        private static void MoveDown(bool isFirstRow, int height, string[] rowArray)
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 && !isFirstRow)
                {
                    continue;
                }
                AddOneCharToEachRowDown(height, i, rowArray);
            }
        }

        private static void AddOneCharToEachRowDown(int height, int i, string[] rowArray)
        {
            for (int j = 0; j < height; j++)
            {
                if (j == i)
                {
                    rowArray[j] += Asterisk;
                }
                else
                {
                    rowArray[j] += Space;
                }
            }
        }

        private static void MoveUp(int height, string[] rowArray)
        {
            for (int i = height - 2; i >= 0; i--)
            {
                AddOneCharToEachRowUp(height, i, rowArray);
            }
        }

        private static void AddOneCharToEachRowUp(int height, int i, string[] rowArray)
        {
            for (int j = height - 1; j >= 0; j--)
            {
                if (j == i)
                {
                    rowArray[j] += Asterisk;
                }
                else
                {
                    rowArray[j] += Space;
                }
            }
        }

        private static string[] CreateArray(int height)
        {
            string row = string.Empty;

            var stringArray = new string[height];

            for (int i = 0; i < height; i++)
            {
                stringArray[i] = row;
            }

            return stringArray;
        }
    }
}