using System;

namespace BlackJack 
{
    public class Card
    {
        public int Value { get; set; }
        public string Suit { get; set; }

        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Card otherCard)
            {
                return Value == otherCard.Value && Suit == otherCard.Suit;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Suit);
        }
    }
}