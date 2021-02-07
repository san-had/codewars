using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Trajectory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputReader = new InputReader();

            var lines = inputReader.ReadInput();

            Tuple<int, int>[] slopes =
            {
                Tuple.Create(1,1),
                Tuple.Create(3,1),
                Tuple.Create(5,1),
                Tuple.Create(7,1),
                Tuple.Create(1,2)
            };

            var treeNumbers = new List<long>();

            foreach (var slope in slopes)
            {
                treeNumbers.Add(GetTreeNumbers(slope, lines));
            }

            foreach (var treeNumber in treeNumbers)
            {
                Console.WriteLine(treeNumber);
            }

            long result = treeNumbers.Aggregate((long)1, (a, b) => a * b);

            Console.WriteLine($"Result: {result}");
        }

        private static long GetTreeNumbers(Tuple<int, int> slope, List<string> lines)
        {
            long treeCounter = 0;
            int columnIndex = 0;

            for (int rowIndex = slope.Item2; rowIndex < lines.Count; rowIndex += slope.Item2)
            {
                columnIndex += slope.Item1;
                string row = lines[rowIndex];
                while (columnIndex >= row.Length)
                {
                    row += row;
                }
                if (row[columnIndex] == '#')
                {
                    treeCounter++;
                }
            }

            return treeCounter;
        }
    }
}