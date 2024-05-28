using System;
using System.Collections.Generic;

namespace CardClasses
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card Deal()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty.");
            }

            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        public int Count => cards.Count;
    }
}
