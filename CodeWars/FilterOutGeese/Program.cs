using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterOutGeese
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] unfiltered = { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" };

            var filtered = GooseFilter(unfiltered);

            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            string[] geese = { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese);
        }
    }
}