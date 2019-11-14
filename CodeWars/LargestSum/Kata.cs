namespace LargestSum
{
    public static class Kata
    {
        public static int LargestSum(int[] arr)
        {
            int arrLength = arr.Length;
            int largestSumm = 0;
            int currentLargestSumm = 0;

            for (int i = 0; i < arrLength; i++)
            {
                currentLargestSumm += arr[i];

                if (largestSumm < currentLargestSumm)
                {
                    largestSumm = currentLargestSumm;
                }

                if (currentLargestSumm < 0)
                {
                    currentLargestSumm = 0;
                }
            }
            return largestSumm;
        }
    }
}