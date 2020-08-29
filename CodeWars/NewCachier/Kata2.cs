using System.Linq;
using System.Text.RegularExpressions;

namespace NewCachier
{
    public static class Kata2
    {
        public static string GetOrder(string input)
        {
            var menuItems = new string[]
             {
                "Burger",
                "Fries",
                "Chicken",
                "Pizza",
                "Sandwich",
                "Onionrings",
                "Milkshake",
                "Coke",
             };

            var order = menuItems
                .Where(item => input.Contains(item.ToLower()))
                .Select(i => Repeater(i, input));

            return string.Join(" ", order);
        }

        private static string Repeater(string menuItem, string input)
        {
            var count = Regex.Matches(input, menuItem.ToLower()).Count();
            return string.Join(" ", Enumerable.Repeat(menuItem, count));
        }
    }
}