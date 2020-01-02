using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Kata
    {
        private static readonly Dictionary<string, int> cardValues = SetupCardValues();

        public static int ScoreHand(string[] cards)
        {
            int values = 0;

            int numberOfAces = cards.Count(x => x == "A");

            foreach (var card in cards.Where(x => x != "A"))
            {
                values += cardValues[card];
            }

            for (int i = 0; i < numberOfAces; i++)
            {
                if (values < 21)
                {
                    if (21 - values >= 11)
                    {
                        values += 11;
                    }
                    else
                    {
                        values += 1;
                    }
                }
                else
                {
                    values += 1;
                }
            }

            return values;
        }

        private static Dictionary<string, int> SetupCardValues()
        {
            var cardValues = new Dictionary<string, int>();

            for (int i = 2; i < 11; i++)
            {
                cardValues.Add(i.ToString(), i);
            }

            cardValues.Add("J", 10);
            cardValues.Add("Q", 10);
            cardValues.Add("K", 10);

            return cardValues;
        }
    }
}