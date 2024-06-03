using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> cards;
        private static readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        private static readonly int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        public Deck()
        {
            cards = new List<Card>();
            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card(value, suit));
                }
            }
            Shuffle();
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

        public Card Draw()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("Deck is empty");
            }
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}