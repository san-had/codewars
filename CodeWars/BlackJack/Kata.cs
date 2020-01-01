using System.Collections.Generic;

namespace BlackJack
{
    public class Kata
    {
        private static readonly Dictionary<string, int> cardValuesA1 = SetupCardValues(1);

        private static readonly Dictionary<string, int> cardValuesA11 = SetupCardValues(11);

        public static int ScoreHand(string[] cards)
        {
            int valueWithA1 = 0;

            int valueWithA11 = 0;

            foreach (var card in cards)
            {
                valueWithA1 += cardValuesA1[card];
                valueWithA11 += cardValuesA11[card];
            }

            int below21 = 21 - valueWithA1;

            int above21 = valueWithA11 - 21;

            return below21 <= above21 ? valueWithA1 : valueWithA11;
        }

        private static Dictionary<string, int> SetupCardValues(int aValue)
        {
            var cardValues = new Dictionary<string, int>();

            for (int i = 2; i < 11; i++)
            {
                cardValues.Add(i.ToString(), i);
            }

            cardValues.Add("J", 10);
            cardValues.Add("Q", 10);
            cardValues.Add("K", 10);
            cardValues.Add("A", aValue);

            return cardValues;
        }
    }
}