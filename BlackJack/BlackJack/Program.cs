using System;

namespace BlackJack
{

    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            BJHand playerHand = new BJHand(deck, 2);
            BJHand dealerHand = new BJHand(deck, 2);

            int playerWins = 0;
            int dealerWins = 0;

            while (true)
            {
                Console.WriteLine("Your hand:");
                Console.WriteLine(playerHand);
                Console.WriteLine($"Score: {playerHand.GetScore()}");

                Console.WriteLine("Dealer's hand:");
                Console.WriteLine(dealerHand.GetCard(0));
                Console.WriteLine("Hidden Card");

                bool playerTurn = true;
                while (playerTurn && !playerHand.IsBusted())
                {
                    Console.WriteLine("Do you want to HIT or STAND?");
                    string choice = Console.ReadLine().ToUpper();
                    if (choice == "HIT")
                    {
                        playerHand.AddCard(deck.Draw());
                        Console.WriteLine("Your hand:");
                        Console.WriteLine(playerHand);
                        Console.WriteLine($"Score: {playerHand.GetScore()}");
                        if (playerHand.IsBusted())
                        {
                            Console.WriteLine("You busted!");
                            dealerWins++;
                            playerTurn = false;
                        }
                    }
                    else if (choice == "STAND")
                    {
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please choose HIT or STAND.");
                    }
                }

                if (!playerHand.IsBusted())
                {
                    Console.WriteLine("Dealer's turn:");
                    while (dealerHand.GetScore() <= 16)
                    {
                        dealerHand.AddCard(deck.Draw());
                        Console.WriteLine("Dealer's hand:");
                        Console.WriteLine(dealerHand);
                        Console.WriteLine($"Score: {dealerHand.GetScore()}");
                    }

                    if (dealerHand.IsBusted())
                    {
                        Console.WriteLine("Dealer busted! You win!");
                        playerWins++;
                    }
                    else
                    {
                        Console.WriteLine("Dealer's hand:");
                        Console.WriteLine(dealerHand);
                        Console.WriteLine($"Score: {dealerHand.GetScore()}");

                        if (playerHand.GetScore() > dealerHand.GetScore())
                        {
                            Console.WriteLine("You win!");
                            playerWins++;
                        }
                        else if (playerHand.GetScore() < dealerHand.GetScore())
                        {
                            Console.WriteLine("Dealer wins!");
                            dealerWins++;
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                        }
                    }
                }

                Console.WriteLine($"Player wins: {playerWins}, Dealer wins: {dealerWins}");
                Console.WriteLine("Do you want to play another hand? (yes/no)");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "yes")
                {
                    break;
                }

                deck = new Deck();
                playerHand = new BJHand(deck, 2);
                dealerHand = new BJHand(deck, 2);
            }
        }
    }
}