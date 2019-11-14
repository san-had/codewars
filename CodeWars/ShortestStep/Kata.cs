namespace ShortestStep
{
    public class Kata
    {
        public static int ShortestStepsToNum(int num)
        {
            int step = 0;

            while (num > 1)
            {
                if (num % 2 == 1)
                {
                    num--;
                }
                else
                {
                    num /= 2;
                }

                //               num = num % 2 == 1 ? num - 1 : num / 2;

                step++;
            }

            return step;
        }
    }
}