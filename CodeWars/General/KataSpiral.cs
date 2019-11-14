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

            do
            {
                MoveRight(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);
                if (startValue > lastValue)
                {
                    break;
                }
                MoveDown(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);
                if (startValue > lastValue)
                {
                    break;
                }
                MoveLeft(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);
                if (startValue > lastValue)
                {
                    break;
                }
                MoveUp(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);
                if (startValue > lastValue)
                {
                    break;
                }
            } while (true);

            return spiralData;
        }

        private static void MoveRight(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = colIndex; i < length; i++)
            {
                spiralData[rowIndex, i] = startValue;
                startValue++;
            }

            colIndex = length - 1;
            rowIndex++;
        }

        private static void MoveDown(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = rowIndex; i < length; i++)
            {
                spiralData[i, colIndex] = startValue;
                startValue++;
            }

            rowIndex = length;
            colIndex--;
        }

        private static void MoveLeft(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            length--;

            for (int i = colIndex; i >= startIndex; i--)
            {
                spiralData[rowIndex, i] = startValue;
                startValue++;
            }

            colIndex = startIndex;
        }

        private static void MoveUp(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            rowIndex--;
            startIndex++;

            for (int i = rowIndex; i >= startIndex; i--)
            {
                spiralData[i, colIndex] = startValue;
                startValue++;
            }

            colIndex++;
        }
    }
}