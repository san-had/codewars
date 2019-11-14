using System.Linq;
using static System.Math;

namespace OrArrays
{
    internal static class ArrayExtension
    {
        public static int ValueOrDefault(this int[] array, int index, int def)
        {
            return array.Length > index ? array[index] : def;
        }
    }

    internal class Kata2
    {
        public static int[] OrArrays(int[] array1, int[] array2, int d = 0)
        {
            return Enumerable.Range(0, Max(array1.Length, array2.Length))
                .Select(index => array1.ValueOrDefault(index, d) | array2.ValueOrDefault(index, d))
                .ToArray();
        }
    }
}