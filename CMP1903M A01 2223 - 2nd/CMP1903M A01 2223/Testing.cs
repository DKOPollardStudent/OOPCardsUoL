using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

// David Kristian O. Pollard - 26527213

namespace CMP1903M_A01_2223
{
	class Testing // Program Testing Class
	{
		public Testing()
		{
			//Creates a pack object
			Pack CardDeck = new Pack();

			//Calls the shuffleCardPack method with each shuffle type
			Console.WriteLine("-=+=-Shuffles-=+=-");
			Console.WriteLine("What Shuffle would you like?:"); // Asks for User's Input of their Choice of Shuffle

			string ShuffleType; // Declares Variable as String 
			int Shuffle;  // Declares Variable as Integar 

			Console.WriteLine("1 = Fisher-Yates 2 = Riffle 3 = No Shuffle"); // Displays the Choices
			ShuffleType = Console.ReadLine();

			Console.WriteLine("");

			try // Error Handling
            {
				Shuffle = int.Parse(ShuffleType);

				if (Shuffle == 0 || Shuffle >= 4) // Checks if User Input is Valid 
				{
					Console.WriteLine("!! INVALID SHUFFLE TYPE - NO SHUFFLE SELECTED BY DEFAULT !!"); // Displays that Shuffle Type was invalid
				}

				else if (Shuffle == 1)
				{
					Pack.shuffleCardPack(1); // If User Inputs Choice 1 - Fisher-Yates 
					Console.WriteLine("-- FISHER-YATES SHUFFLE COMPLETED --");
				}
				else if (Shuffle == 2)
				{
					Pack.shuffleCardPack(2); // If User Inputs Choice 2 - Riffle
					Console.WriteLine("-- RIFFLE SHUFFLE COMPLETED --");
				}
				else if (Shuffle == 3)
				{
					Pack.shuffleCardPack(3); // If User Inputs Choice 3 - No Shuffle
					Console.WriteLine("-- NO SHUFFLE COMPLETED --");
				}
			}
			catch (FormatException) // If User Input is not an Integar, No Shuffle is Selected by Default
            { 
				Console.WriteLine($"!! {ShuffleType} IS NOT AN INTEGAR - NO SHUFFLE SELECTED BY DEFAULT !!"); // Displays message showing No Shuffle has been Selected by Default
			}

			// Simple Display of What Number Corresponds to What Value/Suit
			Console.WriteLine("");
			Console.WriteLine("-=+=-What Each Number Corresponds To-=+=-");
			Console.WriteLine("Suits = 1 (Club), 2 (Diamonds), 3 (Hearts), 4 (Spades)");
			Console.WriteLine("Values = 1 (Ace), 2-10, 11 (Jack), 12 (King), 13 (Queen)");
			Console.WriteLine("");

			// Calls the deal method
			Card DealtCard = Pack.Deal();

			Console.WriteLine("-=+=-Single Card Deal-=+=-"); // Deals One Card
			Console.WriteLine($"Suit = {DealtCard.CardSuit} : Value = {DealtCard.CardValue}"); // Displays the card that has been dealt

			Console.WriteLine("");

			// Calls the deal multiple method
			Console.WriteLine("-=+=-Multi-Card Deal-=+=-");

			Console.WriteLine("How many cards would you like to deal?:"); // Prompts User Input - How many cards they'd like to deal
			int DealAmount = Convert.ToInt32(Console.ReadLine());

			if (DealAmount == 0 || DealAmount > 52) // Checks if the User has Inputted an invalid amount
			{
				Console.WriteLine("!! INVALID CARD AMOUNT !!");
			}

			else if (DealAmount == 1 || DealAmount < 52) // Checks if the User has Inputted a valid amount
			{
				List<Card> cards = Pack.DealMultiple(DealAmount);
				Console.WriteLine($"-=+=-Dealing {DealAmount} Cards-=+=-"); 

				for (int i = 0; i < DealAmount; i++) // Checks how many Cards the User wants to deal and loops until it's dealt them all
				{
					Console.WriteLine($"Card {i} Suit = {cards[i].CardSuit} : Card {i} Value = {cards[i].CardValue}"); // Displays the card that has been dealt
				}
			}
		}
	}
}
