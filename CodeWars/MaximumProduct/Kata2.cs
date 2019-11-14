using System.Linq;

namespace MaximumProduct
{
    public class Kata2
    {
        public static int AdjacentElementProducts(int[] array) =>

            Enumerable.Range(0, array.Length - 1)
                .Select(index => array[index] * array[index + 1])
                .ToList().Max();
    }
}