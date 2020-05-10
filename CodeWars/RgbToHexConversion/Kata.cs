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
            if (input < 0)
            {
                input = 0;
            }

            return input > 255 ? "FF" : input.ToString("X2");
        }
    }
}