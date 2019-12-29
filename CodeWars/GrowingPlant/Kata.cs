namespace GrowingPlant
{
    public class Kata
    {
        public static int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int days = 0;
            int currentHeight = 0;

            do
            {
                if (days != 0)
                {
                    currentHeight -= downSpeed;
                }
                days++;
                currentHeight += upSpeed;
            } while (currentHeight < desiredHeight);

            return days;
        }
    }
}