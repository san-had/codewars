namespace General
{
    public class IntroToArt2
    {
        private const string Asterisk = "*";
        private const string Space = " ";

        public static string[] GetW(int height)
        {
            const int directionLength = 4;

            var rowArray = CreateArray(height);

            int rowIndex = 0;
            bool isDown = true;
            int downCounter = 0;

            do
            {
                MoveOneStep(height, rowIndex, rowArray);
                if (rowIndex == height)
                {
                    isDown = false;

                    rowIndex--;
                }
                if (rowIndex == 0)
                {
                    isDown = true;
                    downCounter++;
                }
                if (isDown)
                {
                    rowIndex++;
                }
                else
                {
                    rowIndex--;
                }
            } while (downCounter < 3);

            return rowArray;
        }

        private static void MoveOneStep(int height, int rowIndex, string[] rowArray)
        {
            if (height == rowIndex)
            {
                return;
            }
            for (int i = 0; i < height; i++)
            {
                if (i == rowIndex)
                {
                    rowArray[i] += Asterisk;
                }
                else
                {
                    rowArray[i] += Space;
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