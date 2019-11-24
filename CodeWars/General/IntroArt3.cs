using System.Text;

namespace General
{
    public class IntroArt3
    {
        private const char Asterisk = '*';
        private const char Space = ' ';

        public static string[] GetW(int height)
        {
            if (height < 2)
            {
                return new string[0];
            }

            var rowArray = CreateArray(height);

            MoveTwoStars(rowArray);

            return rowArray;
        }

        private static void MoveTwoStars(string[] rowArray)
        {
            var height = rowArray.Length;

            int firstStarPosition = 0;
            int secondStarPosition = 2 * height - 2;

            for (int i = 0; i < height; i++)
            {
                rowArray[i] = DrawAsterisks(rowArray[i], ref firstStarPosition, ref secondStarPosition);
                firstStarPosition++;
                secondStarPosition++;
            }

            for (int i = height - 2; i >= 0; i--)
            {
                rowArray[i] = DrawAsterisks(rowArray[i], ref firstStarPosition, ref secondStarPosition);
                firstStarPosition++;
                secondStarPosition++;
            }
        }

        private static string DrawAsterisks(string row, ref int firstStarPosition, ref int secondStarPosition)
        {
            var rowBuilder = new StringBuilder(row);
            rowBuilder.Replace(Space, Asterisk, firstStarPosition, 1);
            rowBuilder.Replace(Space, Asterisk, secondStarPosition, 1);
            return rowBuilder.ToString();
        }

        private static string[] CreateArray(int height)
        {
            var rowLength = 4 * height - 3;

            string row = new string(' ', rowLength);

            var stringArray = new string[height];

            for (int i = 0; i < height; i++)
            {
                stringArray[i] = row;
            }

            return stringArray;
        }
    }
}