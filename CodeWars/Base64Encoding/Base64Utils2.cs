using System;
using System.Text;

namespace Base64Encoding
{
    public class Base64Utils2
    {
        private static readonly char[] Base64Lookup = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '/'
        };

        public static string ToBase64(string inputString)
        {
            var octets = GetOctets(inputString);

            return GetBase64Chars(octets);
        }

        public static string FromBase64(string base64String)
        {
            var sextets = GetSextets(base64String.Replace("=", string.Empty));

            return GetDecodedChars(sextets);
        }

        private static string GetDecodedChars(string sextets)
        {
            var sextetLength = sextets.Length;

            StringBuilder decodedCharCollector = new StringBuilder();

            for (int i = 0; i < sextetLength; i += 8)
            {
                if (!(sextetLength - i < 8))
                {
                    int charCode = Convert.ToInt32(sextets.Substring(i, 8), 2);
                    decodedCharCollector.Append((char)charCode);
                }
            }

            return decodedCharCollector.ToString();
        }

        private static string GetSextets(string base64String)
        {
            StringBuilder sextetCollector = new StringBuilder();

            foreach (var ch in base64String)
            {
                var sextet = string.Join(string.Empty, Base64Lookup).IndexOf(ch);

                var sextetBinary = Convert.ToString(sextet, 2).PadLeft(6, '0');

                sextetCollector.Append(sextetBinary);
            }

            return sextetCollector.ToString();
        }

        private static string GetBase64Chars(string octets)
        {
            var binaryLength = octets.Length;

            StringBuilder sbBase64Collector = new StringBuilder();

            StringBuilder base64CharBinaryCollector = new StringBuilder();

            for (int i = 0; i < binaryLength; i += 6)
            {
                char convertedChar;

                if (binaryLength - i < 6)
                {
                    base64CharBinaryCollector.Append(octets.Substring(i));
                    var length = 6 - base64CharBinaryCollector.Length;

                    for (int j = 0; j < length; j++)
                    {
                        base64CharBinaryCollector.Append("0");
                    }
                    convertedChar = ConvertToBase64Char(base64CharBinaryCollector.ToString());
                    sbBase64Collector.Append(convertedChar.ToString());
                    base64CharBinaryCollector.Clear();
                }
                else
                {
                    convertedChar = ConvertToBase64Char(octets.Substring(i, 6));
                    sbBase64Collector.Append(convertedChar.ToString());
                }
            }

            if (sbBase64Collector.Length % 4 != 0)
            {
                if (sbBase64Collector.Length % 4 == 2)
                {
                    sbBase64Collector.Append("==");
                }
                else
                {
                    sbBase64Collector.Append("=");
                }
            }

            return sbBase64Collector.ToString();
        }

        private static string GetOctets(string inputString)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(inputString);

            StringBuilder sbBinary = new StringBuilder();

            foreach (byte b in bytes)
            {
                var binary = Convert.ToString(b, 2).PadLeft(8, '0');
                sbBinary.Append(binary);
            }
            return sbBinary.ToString();
        }

        private static char ConvertToBase64Char(string binaryInput)
        {
            return Base64Lookup[Convert.ToInt32(binaryInput, 2)];
        }
    }
}