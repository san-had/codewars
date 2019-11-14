using System;

namespace Base64Encoding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string testPath = @"d:\sandbox\pcinc\pcicore\pcitests\csdpconfigfile.config";

            //string configFilePath = PathParser.ChangePath(testPath);

            //System.Console.WriteLine(configFilePath);

            var encodedString = Base64Utils2.ToBase64("this is a string!!");

            // var encodedString = "ZWU=";

            Console.WriteLine(encodedString);

            Console.WriteLine(Base64Utils2.FromBase64(encodedString));
        }
    }
}