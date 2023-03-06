using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// David Kristian O. Pollard - 26527213

namespace CMP1903M_A01_2223
{
	class Card // Card Class
	{
		private int Value; // Fields
		private int Suit;
		public int CardValue
		{
			get 
			{ 
				return Value;
			} 
			set
			{
				if (1 <= value && value <= 13) // Checks if Value: numbers 1 - 13
				{
					Value = value; // Sets Value
				} 
				else
				{ 
					Console.WriteLine("Card Value is to between 1-13."); 
				} 
			}
		}
		public int CardSuit
		{
			get 
			{
				return Suit; 
			}
			set
			{
				if (1 <= value && value <= 4) // Checks if Suit: numbers 1 - 4
				{
					Suit = value; // Sets Suit
				} 
				else 
				{ 
					Console.WriteLine("Card Suit is to between 1-4."); } 
			}
		}
	}
}