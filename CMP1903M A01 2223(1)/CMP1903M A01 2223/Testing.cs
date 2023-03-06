using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// David Kristian O. Pollard - 26527213

namespace CMP1903M_A01_2223
{
	class Testing
	{
		public Testing()
		{
			//Creates a pack object
			Pack card_pack = new Pack();

			//Calls the shuffleCardPack method with each shuffle type
			Console.WriteLine("-=+=-Shuffles-=+=-");

			Console.WriteLine("What Shuffle would you like?:"); // Asks for User's Input of their Choice of Shuffle
			Console.WriteLine("1 = Fisher-Yates 2 = Riffle 3 = No Shuffle"); // Displays the Choices
			int Shuffle = Convert.ToInt32(Console.ReadLine());

			if (Shuffle == 0 && Shuffle >= 4) // Checks if User Input is Valid 
			{
				Console.WriteLine("Invalid Shuffle Type"); // Displays that Shuffle Type was invalid
			}

			else if (Shuffle == 1)
			{
				Pack.shuffleCardPack(1); // If User Inputs Choice 1 - Fisher-Yates 
				Console.WriteLine("Successfully shuffled via Fisher-Yates Shuffle");
			}
			else if (Shuffle == 2)
			{
				Pack.shuffleCardPack(2); // If User Inputs Choice 2 - Riffle
				Console.WriteLine("Successfully shuffled via Riffle Shuffle");
			}
			else if (Shuffle == 3)
			{
				Pack.shuffleCardPack(3); // If User Inputs Choice 3 - No Shuffle
				Console.WriteLine("No Shuffle complete");
			}

			Console.WriteLine("");

			// Calls the deal method
			Card dealt_card = Pack.deal();

			Console.WriteLine("-=+=-Single Card Deal-=+=-"); // Deals One Card
			Console.WriteLine($"Dealt Card's Suit: {dealt_card.CardSuit}, Dealt Card's Value: {dealt_card.CardValue}"); // Displays the card that has been dealt

			Console.WriteLine("");

			// Calls the deal multiple method
			Console.WriteLine("-=+=-Multi-Card Deal-=+=-");

			Console.WriteLine("How many cards would you like to deal?:"); // Prompts User Input - How many cards they'd like to deal
			int DealAmount = Convert.ToInt32(Console.ReadLine());

			if (DealAmount == 0 || DealAmount > 52) // Checks if the User has Inputted an invalid amount
			{
				Console.WriteLine("Invalid Card Amount");
			}

			else if (DealAmount == 1 || DealAmount < 52) // Checks if the User has Inputted a valid amount
			{
				List<Card> cards = Pack.dealCard(DealAmount);
				Console.WriteLine($"-=+=-Dealing {DealAmount} Cards-=+=-");

				// Checks what is returned
				for (int i = 0; i < DealAmount; i++)
				{
					Console.WriteLine($"Card number {i}'s Suit: {cards[i].CardSuit}, Card number {i}'s Value: {cards[i].CardValue}"); // Displays the card that has been dealt
				}
			}
		}
	}
}