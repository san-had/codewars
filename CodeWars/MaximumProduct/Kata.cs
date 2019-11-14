namespace MaximumProduct
{
    public class Kata
    {
        public static int AdjacentElementProducts(int[] array)
        {
            int result = 0;

            for (int index = 0; index < array.Length - 1; index++)
            {
                int product = array[index] * array[index + 1];
                if (index == 0 || product > result)
                {
                    result = product;
                }
            }

            return result;
        }
    }
}