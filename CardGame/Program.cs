// See https://aka.ms/new-console-template for more information
using CardGame;

// Poker
PokerDeck pokerDeck = new PokerDeck();

var hand = pokerDeck.DealCards();
Console.WriteLine("Poker:");
foreach (var card in hand)
{
    Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
}

// BlackJack
BlackJackDeck blackJackDeck = new BlackJackDeck();

hand = blackJackDeck.DealCards();
Console.WriteLine();
Console.WriteLine("BlackJack:");
foreach (var card in hand)
{
    Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
}

Console.ReadLine();



