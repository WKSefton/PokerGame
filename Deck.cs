using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame {
	//deck class
	public class Deck {

		private List<Card> deck = new List<Card>(52);
		private Random rand = new Random();

		public Deck() {
			InitializeDeck();
		}

		private void InitializeDeck() {
			for (int i = 1; i < 5; i++) {
				for (int j = 2; j < 15; j++) {
					deck.Add(new Card(j, i));
				}
			}
		}

		private void SwapCards(int i, int k) {
			if (i != k) {
				Card tempi = deck[i];
				deck[i] = deck[k];
				deck[k] = tempi;
			}
		}

		public void Shuffle() {
			Random rand = new Random();
			int value = rand.Next(1000) + 500;
			while (value > 0) {
				SwapCards(rand.Next(deck.Count()-1), rand.Next(deck.Count()-1));
				value--;
			}
		}

		public List<Card> GetDeck() {
			return deck;
		}

		public Card GetCard() {
			Card card = deck.First();
			deck.RemoveAt(0);
			return card;
		}

		public void ResetDeck() {
			deck.Clear();
			InitializeDeck();
		}

		public override string ToString() {
			return deck.ToString();
		}
	}
}