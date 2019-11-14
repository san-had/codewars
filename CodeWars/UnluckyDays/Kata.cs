using System;
using System.Linq;

namespace UnluckyDays
{
    public class Kata
    {
        public static int UnluckyDays(int year)
        {
            int unluckyDays = 0;
            for (int month = 1; month <= 12; month++)
            {
                var thirteen = new DateTime(year, month, 13);
                if (thirteen.DayOfWeek == DayOfWeek.Friday)
                {
                    unluckyDays++;
                }
            }

            return unluckyDays;
        }

        public static int UnluckyDays2(int year) =>
            Enumerable.Range(1, 12)
                .Count(month => new DateTime(year, month, 13).DayOfWeek == DayOfWeek.Friday);

        public static int UnluckyDays3(int year) =>
            Enumerable.Range(1, 12)
                .Select(month => new DateTime(year, month, 13))
                .Count(dt => dt.DayOfWeek == DayOfWeek.Friday);
    }
}