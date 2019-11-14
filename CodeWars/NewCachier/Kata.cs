using System.Collections.Generic;

namespace NewCachier
{
    public static class Kata
    {
        public static string GetOrder(string input)
        {
            var orderedItemList = GetItemList(input);

            return string.Join(" ", orderedItemList);
        }

        private static List<string> GetItemList(string order)
        {
            var orderedItemList = new List<string>();

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

            foreach (var item in menuItems)
            {
                while (order.Contains(item.ToLower()))
                {
                    int index = order.IndexOf(item.ToLower());
                    orderedItemList.Add(item);
                    order = order.Remove(index, item.Length);
                }
            }

            return orderedItemList;
        }
    }
}