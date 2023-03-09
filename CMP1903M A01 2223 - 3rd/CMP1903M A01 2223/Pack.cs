using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

// David Kristian O. Pollard - 26527213

namespace CMP1903M_A01_2223
{
    class Pack // Pack Class 
    {
        public static List<Card> Deck = new List<Card>();
        
        public Pack() // Creates Card Pack
        {
            for (int suit = 1; suit <= 4; suit++) // Loops through Suits
            {
                for (int value = 1; value <= 13; value++) // Loops through Values
                {
                    Card card = new Card // Creates a new card
                    {
                        CardValue = value, // Assigns it a Value and Suit
                        CardSuit = suit
                    };
                    Deck.Add(card); // Adds it to the Card Deck
                }
            }
        }
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Shuffles the pack based on the type of shuffle

            if (typeOfShuffle == 1) // Fisher-Yates Shuffle
            {
                Random rnd = new Random();
                Card temp;
                for (int i = 0; i <= 52; i++)
                {
                    int PickCard = rnd.Next(0, 52 - i); // Picks a card at random from the pack
                    temp = Deck[PickCard]; // Stores card in a temp variable
                    Deck.RemoveAt(PickCard); // Removes the card from the pack
                    Deck.Add(temp); // Puts the card at the end of the pack
                }
                return true;
            }
            else if (typeOfShuffle == 2) // Riffle Shuffle
            {
                Card temp;
                for (int i = 0; i <= 25; i++)  // Splits the Card Pack in half
                {
                    temp = Deck[0]; // Takes the card from the top half of the pack
                    Deck.RemoveAt(0); // Removes the card from the top half of the pack
                    Deck.Add(temp); // Adds the card to the bottom half of the pack
                    temp = Deck[25 - i]; // Takes the card from the bottom half of the pack
                    Deck.RemoveAt(25 - i); // Removes the card from the bottom half of the pack
                    Deck.Add(temp); // Adds the card to the top half of the pack
                }
                return true;
            }
            else if (typeOfShuffle == 3) // No Shuffle - Cards Remain the Same
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect type of shuffle"); // Displays if Type of Shuffle is not 1, 2 or 3 
                return false;
            }

        }

        public static Card Deal()
        {
            // Deals One Card
            Card DealCard = Deck[51]; // Takes the last card from the pack
            Deck.RemoveAt(51); // Removes it from the pack

            return DealCard; // Deals that one card
        }

        public static List<Card> DealMultiple(int amount)
        {
            // Multiple Card Deal
            List<Card> Cards = new List<Card>(); // Creates a new list of Cards

            int PackSize = Deck.Count(); 

            for (int i = 0; i < amount; i++) // Deals the number of cards specified by 'amount'
            {
                Cards.Add(Deck[PackSize - i - 1]); // Adds the Card to the list
                Deck.RemoveAt(PackSize - i - 1); // Removes the Card from the Deck
            }
            return Cards;
        }

    }
}