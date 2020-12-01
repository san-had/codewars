using System;
using System.Collections.Generic;
using System.IO;

namespace ExpenseReport
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputList = ReadReport();

            var resultList = GetTwo(inputList);

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }

            var finalResult = resultList[0] * resultList[1];

            Console.WriteLine();

            Console.WriteLine($"Eredmény: {resultList[0]} x {resultList[1]} = {finalResult.ToString()}");
        }

        private static List<int> GetTwo(List<int> inputList)
        {
            var result = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = 0; j < inputList.Count; j++)
                {
                    if (inputList[i] + inputList[j] == 2020)
                    {
                        result.Add(inputList[i]);
                        result.Add(inputList[j]);
                    }
                }
            }
            return result;
        }

        private static List<int> ReadReport()
        {
            var numbers = new List<int>();

            using (StreamReader reader = new StreamReader("expenseReport.txt"))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    numbers.Add(Int32.Parse(line));
                }
            }
            return numbers;
        }
    }
}