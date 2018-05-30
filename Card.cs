using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame {

	public class Card {
		private enum Suit {
			Hearts = 1, Diamonds = 2, Spades = 3, Clubs = 4
		}

		private enum Face {
			Ace = 14, King = 13, Queen = 12, Jack = 11, Ten = 10, Nine = 9, Eight = 8, Seven = 7, Six = 6,
			Five = 5, Four = 4, Three = 3, Two = 2
		}

		private Suit suit;
		private Face face;

		public Card() { }

		public Card(int f, int s) {
			suit = (Suit)s;
			face = (Face)f;
		}

		public string GetSuit() {
			return suit.ToString();
		}

		public string GetFace() {
			return face.ToString();
		}

		public bool SuitIsEqual(Card card) {
			if (card.GetSuit().Equals(this.GetSuit()))
				return true;
			return false;
		}

		public bool FaceIsEqual(Card card) {
			if (card.GetFace().Equals(this.GetFace()))
				return true;
			return false;
		}

		public override string ToString() {
			return String.Format("{0} of {1} ", face.ToString(), suit.ToString());
		}
	}
}