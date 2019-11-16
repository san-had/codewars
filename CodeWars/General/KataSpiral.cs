namespace General
{
    public class KataSpiral
    {
        public static int[,] CreateSpiral(int n)
        {
            var spiralData = new int[n, n];

            int rowIndex = 0;

            int colIndex = 0;

            int length = n;

            int startValue = 0;

            int lastValue = n * n;

            int round = 0;

            MoveRightFirst(ref rowIndex, ref colIndex, ref length, ref startValue, spiralData);

            do
            {
                if (startValue == lastValue)
                {
                    break;
                }

                MoveDown(ref rowIndex, ref colIndex, round, ref length, ref startValue, spiralData);

                if (startValue == lastValue)
                {
                    break;
                }

                MoveLeft(ref rowIndex, ref colIndex, round, ref length, ref startValue, spiralData);

                if (startValue == lastValue)
                {
                    break;
                }

                MoveUp(ref rowIndex, ref colIndex, round, ref length, ref startValue, spiralData);

                if (startValue == lastValue)
                {
                    break;
                }

                MoveRight(ref rowIndex, ref colIndex, round, ref length, ref startValue, spiralData);

                round += 2;
            } while (true);

            return spiralData;
        }

        private static void MoveRightFirst(ref int rowIndex, ref int colIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length;
            while (counter > 0)
            {
                startValue++;
                spiralData[rowIndex, colIndex] = startValue;
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
                startValue++;
                spiralData[rowIndex, colIndex] = startValue;
                counter--;
            }
        }

        private static void MoveLeft(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 1 - roundCounter;

            while (counter > 0)
            {
                colIndex--;
                startValue++;
                spiralData[rowIndex, colIndex] = startValue;
                counter--;
            }
        }

        private static void MoveUp(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 2 - roundCounter;

            while (counter > 0)
            {
                rowIndex--;
                startValue++;
                spiralData[rowIndex, colIndex] = startValue;
                counter--;
            }
        }

        private static void MoveRight(ref int rowIndex, ref int colIndex, int roundCounter, ref int length, ref int startValue, int[,] spiralData)
        {
            int counter = length - 2 - roundCounter;

            while (counter > 0)
            {
                colIndex++;
                startValue++;
                spiralData[rowIndex, colIndex] = startValue;
                counter--;
            }
        }
    }
}