using System;
using System.Collections.Generic;
using System.Linq;

namespace CardClasses
{
    public class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public Hand(Deck deck, int numberOfCards)
        {
            cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(deck.Deal());
            }
        }

        public int Count => cards.Count;

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card Discard(Card card)
        {
            if (cards.Remove(card))
            {
                return card;
            }
            return null;
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public bool HasCard(Card card)
        {
            return cards.Contains(card);
        }

        public bool HasCard(int value, int suit)
        {
            return cards.Any(c => c.Value == value && c.Suit == suit);
        }

        public bool HasCard(int value)
        {
            return cards.Any(c => c.Value == value);
        }

        public int IndexOf(Card card)
        {
            return cards.IndexOf(card);
        }

        public int IndexOf(int value, int suit)
        {
            return cards.FindIndex(c => c.Value == value && c.Suit == suit);
        }

        public int IndexOf(int value)
        {
            return cards.FindIndex(c => c.Value == value);
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
        }
    }
}
