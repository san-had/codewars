namespace OrArrays
{
    internal class Kata
    {
        public static int[] OrArrays(int[] array1, int[] array2, int d = 0)
        {
            var length = array1.Length >= array2.Length ? array1.Length : array2.Length;

            var orArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                int orElement;

                if (i > array1.Length - 1)
                {
                    orElement = d | array2[i];
                }
                else if (i > array2.Length - 1)
                {
                    orElement = array1[i] | d;
                }
                else
                {
                    orElement = array1[i] | array2[i];
                }

                orArray[i] = orElement;
            }

            return orArray;
        }
    }
}