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

            SetupForMoveDown(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue);
            MoveDown(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            SetupForMoveLeft(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue);
            MoveLeft(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            SetupForMoveUp(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue);
            MoveUp(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);

            //do
            //{
            //    //SetupForMoveDown(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue);
            //    //MoveDown(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);
            //    //if (startValue > lastValue)
            //    //{
            //    //    break;
            //    //}

            // //SetupForMoveLeft(ref rowIndex, ref colIndex, ref startIndex, ref length, ref
            // startValue); //MoveLeft(ref rowIndex, ref colIndex, ref startIndex, ref length, ref
            // startValue, spiralData); //if (startValue > lastValue) //{ // break; //}
            // SetupForMoveUp(ref rowIndex, ref colIndex, ref startIndex, ref length, ref
            // startValue);
            //MoveUp(ref rowIndex, ref colIndex, ref startIndex, ref length, ref
            // startValue, spiralData); //if (startValue > lastValue) //{ // break; //}
            //    //SetupForMoveRight(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue);
            //    //MoveRight(ref rowIndex, ref colIndex, ref startIndex, ref length, ref startValue, spiralData);
            //    //if (startValue > lastValue)
            //    //{
            //    //    break;
            //    //}
            //} while (true);

            return spiralData;
        }

        private static void MoveRightFirst(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = startIndex; i < length; i++)
            {
                spiralData[rowIndex, i] = startValue;
                startValue++;
            }
        }

        private static void SetupForMoveDown(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue)
        {
            length--;
            colIndex = length;
            startIndex++;
        }

        private static void MoveDown(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = startIndex; i <= length; i++)
            {
                spiralData[i, colIndex] = startValue;
                startValue++;
            }
        }

        private static void SetupForMoveLeft(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue)
        {
            rowIndex = length;
            colIndex--;
            startIndex = colIndex;
        }

        private static void MoveLeft(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = startIndex; i >= length - startIndex - 1; i--)
            {
                spiralData[rowIndex, i] = startValue;
                startValue++;
            }
        }

        private static void SetupForMoveUp(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue)
        {
            rowIndex--;
            startIndex = rowIndex;
            length--;
            colIndex = colIndex - length;
        }

        private static void MoveUp(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = startIndex; i > startIndex - length; i--)
            {
                spiralData[i, colIndex] = startValue;
                startValue++;
            }
        }

        private static void SetupForMoveRight(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue)
        {
        }

        private static void MoveRight(ref int rowIndex, ref int colIndex, ref int startIndex, ref int length, ref int startValue, int[,] spiralData)
        {
            for (int i = startIndex; i < length; i++)
            {
                spiralData[rowIndex, i] = startValue;
                startValue++;
            }
        }
    }
}