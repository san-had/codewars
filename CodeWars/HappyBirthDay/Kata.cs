namespace HappyBirthDay
{
    public class Kata
    {
        public static string WomensAge(int age)
        {
            int inBase = age / 2;
            int calcAge = 20 + age % 2;

            return $"{age}? That's just {calcAge}, in base {inBase}!";
        }

        public static string WomensAge2(int age) =>
            $"{age}? That's just {20 + age % 2}, in base {age / 2}!";
    }
}