namespace General
{
    public class KataSpiral
    {
        public static int[,] CreateSpiral(int n)
        {
            var spiralData = new int[n, n];

            int rowIndex = 0;

            int colIndex = 0;

            int startIndex = 0;

            int length = n;

            int startValue = 1;

            int lastValue = n * n;

            int roundCounter = 0;

            MoveRightFirst(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            do
            {
                if (startValue > lastValue)
                {
                    break;
                }

                MoveDown(ref rowIndex, ref colIndex, roundCounter, ref length, ref startValue, spiralData);

                if (startValue > lastValue)
                {
                    break;
                }

                MoveLeft(ref rowIndex, ref colIndex, roundCounter, ref length, ref startValue, spiralData);

                if (startValue > lastValue)
                {
                    break;
                }

                MoveUp(ref rowIndex, ref colIndex, roundCounter, ref length, ref startValue, spiralData);

                if (startValue > lastValue)
                {
                    break;
                }

                MoveRight(ref rowIndex, ref colIndex, roundCounter, ref length, ref startValue, spiralData);

                roundCounter += 2;
            } while (true);

            return spiralData;
        }

        private static void MoveRightFirst(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length;
            while (counter > 0)
            {
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                colIndex++;
                counter--;
            }
            colIndex--;
        }

        private static void MoveDown(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 1 - roundCounter;

            while (counter > 0)
            {
                rowIndex++;
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                counter--;
            }
        }

        private static void MoveLeft(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 1 - roundCounter;

            while (counter > 0)
            {
                colIndex--;
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                counter--;
            }
        }

        private static void MoveUp(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 2 - roundCounter;

            while (counter > 0)
            {
                rowIndex--;
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                counter--;
            }
        }

        private static void MoveRight(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 2 - roundCounter;

            while (counter > 0)
            {
                colIndex++;
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                counter--;
            }
        }
    }
}