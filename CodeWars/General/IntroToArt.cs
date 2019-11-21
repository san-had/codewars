namespace General
{
    public class IntroToArt
    {
        public static string[] GetW(int height)
        {
            var rowArray = CreateArray(height);

            for (int i = 0; i < height; i++)
            {
                rowArray[i] = "*";
            }

            //var result = new string[]
            //{
            //    "*   *   *",
            //    " * * * * ",
            //    "  *   *  "
            //};

            //return result;

            return rowArray;
        }

        private static string[] CreateArray(int height)
        {
            string row = string.Empty;

            var stringArray = new string[height];

            for (int i = 0; i < height; i++)
            {
                stringArray[i] = row;
            }

            return stringArray;
        }
    }
}