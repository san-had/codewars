using System;
using System.Collections.Generic;

namespace CodeWars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = "563289";

            //string input = Console.ReadLine();

            string output = GetOrderedOutput(input);

            Console.WriteLine(output);
        }

        private static string GetOrderedOutput(string input)
        {
            string result = string.Empty;

            var intList = new List<int>();

            foreach (var digit in input)
            {
                intList.Add(digit);
            }

            return result;
        }
    }
}