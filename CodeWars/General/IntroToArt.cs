namespace General
{
    public class IntroToArt
    {
        public static string[] GetW(int height)
        {
            const int directionLength = 4;

            var rowArray = CreateArray(height);

            for (int i = 0; i < directionLength; i++)
            {
                if (i % 2 == 0)
                {
                    MoveDown(height, rowArray);
                }
                else
                {
                    MoveUp(height, rowArray);
                }
            }

            //var result = new string[]
            //{
            //    "*   *   *",
            //    " * * * * ",
            //    "  *   *  "
            //};

            //return result;

            return rowArray;
        }

        private static void MoveDown(int height, string[] rowArray)
        {
            for (int i = 0; i < height; i++)
            {
                AddOneCharToEachRowDown(height, i, rowArray);
            }
        }

        private static void AddOneCharToEachRowDown(int height, int i, string[] rowArray)
        {
            for (int j = 0; j < height; j++)
            {
                if (j == i)
                {
                    rowArray[j] += "D";
                }
                else
                {
                    rowArray[j] += " ";
                }
            }
        }

        private static void MoveUp(int height, string[] rowArray)
        {
            for (int i = height - 1; i >= 0; i--)
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
                    rowArray[j] += "U";
                }
                else
                {
                    rowArray[j] += " ";
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