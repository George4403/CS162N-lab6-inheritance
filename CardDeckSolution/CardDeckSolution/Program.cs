using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHand();
        }

        static void TestHand()
        {
            Deck deck = new Deck();
            deck.Shuffle();

            // Create a hand with 5 cards from the deck
            Hand hand = new Hand(deck, 5);

            // Display the hand
            Console.WriteLine("Initial hand:");
            Console.WriteLine(hand);

            // Add a card to the hand
            Card newCard = new Card(10, 3); // 10 of Hearts
            hand.AddCard(newCard);
            Console.WriteLine("Hand after adding 10 of Hearts:");
            Console.WriteLine(hand);

            // Discard a card from the hand
            Card discardedCard = hand.Discard(newCard);
            Console.WriteLine($"Discarded card: {discardedCard}");
            Console.WriteLine("Hand after discarding 10 of Hearts:");
            Console.WriteLine(hand);

            // Get a card based on its index
            Card cardAtIndex0 = hand.GetCard(0);
            Console.WriteLine($"Card at index 0: {cardAtIndex0}");

            // Check if the hand has a specific card
            bool hasCard = hand.HasCard(cardAtIndex0);
            Console.WriteLine($"Does the hand have {cardAtIndex0}? {hasCard}");

            // Check if the hand has a card with a specific value and suit
            bool hasSpecificCard = hand.HasCard(cardAtIndex0.Value, cardAtIndex0.Suit);
            Console.WriteLine($"Does the hand have a card with value {cardAtIndex0.Value} and suit {cardAtIndex0.Suit}? {hasSpecificCard}");

            // Check if the hand has a card with a specific value
            bool hasValueCard = hand.HasCard(cardAtIndex0.Value);
            Console.WriteLine($"Does the hand have a card with value {cardAtIndex0.Value}? {hasValueCard}");

            // Determine the index of a specific card
            int indexOfCard = hand.IndexOf(cardAtIndex0);
            Console.WriteLine($"Index of {cardAtIndex0}: {indexOfCard}");

            // Determine the index of a card with a specific value and suit
            int indexOfSpecificCard = hand.IndexOf(cardAtIndex0.Value, cardAtIndex0.Suit);
            Console.WriteLine($"Index of card with value {cardAtIndex0.Value} and suit {cardAtIndex0.Suit}: {indexOfSpecificCard}");

            // Determine the index of a card with a specific value
            int indexOfValueCard = hand.IndexOf(cardAtIndex0.Value);
            Console.WriteLine($"Index of card with value {cardAtIndex0.Value}: {indexOfValueCard}");

            // Display the final state of the hand
            Console.WriteLine("Final hand:");
            Console.WriteLine(hand);
        }
    }
}
