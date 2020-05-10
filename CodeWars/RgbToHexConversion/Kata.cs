using System;

namespace RgbToHexConversion
{
    public class Kata
    {
        public static string Rgb(int r, int g, int b)
        {
            return HexConverter(r) + HexConverter(g) + HexConverter(b);
        }

        private static string HexConverter(int input)
        {
            return Math.Clamp(input, 0, 255).ToString("X2");
        }
    }
}