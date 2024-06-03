using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Hand
    {
        protected List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int Count => cards.Count;

        public Card GetCard(int index)
        {
            if (index < 0 || index >= cards.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            return cards[index];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var card in cards)
            {
                sb.AppendLine(card.ToString());
            }
            return sb.ToString();
        }
    }
}