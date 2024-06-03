namespace BlackJack
{

    public class BJHand : Hand
    {
        public BJHand() : base()
        {
        }

        public BJHand(Deck deck, int numCards) : base()
        {
            for (int i = 0; i < numCards; i++)
            {
                AddCard(deck.Draw());
            }
        }

        public bool HasAce()
        {
            foreach (var card in cards)
            {
                if (card.Value == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetScore()
        {
            int score = 0;
            int aceCount = 0;
            foreach (var card in cards)
            {
                if (card.Value >= 10)
                {
                    score += 10;
                }
                else
                {
                    score += card.Value;
                }

                if (card.Value == 1)
                {
                    aceCount++;
                }
            }

            while (aceCount > 0 && score + 10 <= 21)
            {
                score += 10;
                aceCount--;
            }

            return score;
        }

        public bool IsBusted()
        {
            return GetScore() > 21;
        }
    }
}