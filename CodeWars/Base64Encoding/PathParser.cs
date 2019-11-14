using System;
using System.IO;

namespace Base64Encoding
{
    public class PathParser
    {
        private const string pciwebapiPath = @"pci.webapi";

        public static string ChangePath(string inputPath)
        {
            var folderArray = inputPath.Split("\\");

            var length = Array.IndexOf(folderArray, "pcicore") + 1;

            var newPathArray = new string[length];

            Array.Copy(folderArray, newPathArray, length);

            string outputPath = Path.Combine(string.Join('\\', newPathArray), pciwebapiPath);

            return outputPath;
        }
    }
}