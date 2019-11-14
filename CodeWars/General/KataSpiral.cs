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

            MoveRightFirst(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            MoveDown(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            //MoveLeft(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            //MoveUp(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            //MoveRight(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

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

        private static void MoveDown(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            rowIndex++;

            int counter = length - 1;

            while (counter > 0)
            {
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                rowIndex++;
                counter--;
            }
        }

        private static void MoveLeft(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            colIndex--;

            int counter = length - 1;

            while (counter > 0)
            {
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                colIndex--;
                counter--;
            }
        }

        private static void MoveUp(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            rowIndex--;

            int counter = length - 2;

            while (counter > 0)
            {
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                rowIndex--;
                counter--;
            }
        }

        private static void MoveRight(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            colIndex++;
            int counter = length - 2;

            while (counter > 0)
            {
                spiralData[rowIndex, colIndex] = startValue;
                startValue++;
                colIndex++;
            }
        }
    }
}