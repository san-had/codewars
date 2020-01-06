using System;

namespace General
{
    public class Program
    {
        private static void Main()
        {
            var integers = GenerateRange.GenerateRangeOfIntegeres(1, 10, 3);

            foreach (var item in integers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}