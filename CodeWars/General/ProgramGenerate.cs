using System;

namespace General
{
    public class ProgramGenerate
    {
        private static void MainGenerate()
        {
            var integers = GenerateRange.GenerateRangeOfIntegeres(1, 10, 3);

            foreach (var item in integers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}