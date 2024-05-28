using System;

namespace CardClasses
{
    public class Card
    {
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public override bool Equals(object obj)
        {
            if (obj is Card card)
            {
                return Value == card.Value && Suit == card.Suit;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Suit);
        }

        public override string ToString()
        {
            string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            return $"{values[Value]} of {suits[Suit]}";
        }
    }
}
