using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

// David Kristian O. Pollard - 26527213

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
        //Initialise the card pack here
        public Pack()
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card card = new Card
                    {
                        CardValue = value,
                        CardSuit = suit
                    };
                    pack.Add(card);
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
                    int card_pick = rnd.Next(0, 52 - i); // Picks a card at random from the pack
                    temp = pack[card_pick]; // Stores card in a temp variable
                    pack.RemoveAt(card_pick); // Removes the card from the pack
                    pack.Add(temp); // Puts the card at the end of the pack
                }
                return true;
            }
            else if (typeOfShuffle == 2) // Riffle Shuffle
            {
                Card temp;
                for (int i = 0; i <= 25; i++)  // Splits the Card Pack in half
                {
                    temp = pack[0]; 
                    pack.RemoveAt(0);
                    pack.Add(temp);
                    temp = pack[25 - i]; 
                    pack.RemoveAt(25 - i);
                    pack.Add(temp);
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

        public static Card deal()
        {
            // Deals One Card
            Card deal_card = pack[51]; // Takes the last card from the pack
            pack.RemoveAt(51); // Removes it from the pack
            return deal_card; // Deals that one card

        }

        public static List<Card> dealCard(int amount)
        {
            // Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>(); 
            int size = pack.Count(); 
            for (int i = 0; i < amount; i++) 
            {
                cards.Add(pack[size - i - 1]);
                pack.RemoveAt(size - i - 1);
            }
            return cards;
        }

    }
}