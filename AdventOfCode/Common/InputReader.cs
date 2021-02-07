using System.Collections.Generic;
using System.IO;

namespace Common
{
    public class InputReader
    {
        private const string inputFile = "input.txt";

        public List<string> ReadInput()
        {
            var lines = new List<string>();

            using (StreamReader reader = new StreamReader(inputFile))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}