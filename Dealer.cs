using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame {
	public class Dealer {

		Deck deck = new Deck();
		List<Player> players = new List<Player>();
		List<Card> dealerHand = new List<Card>();

		public void DealCardsToPlayers(int numPlayers) {
			if (CheckDeck()) {
				deck.Shuffle();

				for (int i = 0; i < numPlayers; i++) {
					players.Add(new Player(i));

					for (int j = 0; j < 2; j++) {
						players[i].AddCard(deck.GetCard(), j);
					}
				}
			} else {
				Console.WriteLine("Error not enough cards!");
			}
		}

		public void DealHouseCards() {
			if (CheckDeck()) {
				for (int i = 0; i < 5; i++) {
					dealerHand.Add(deck.GetCard());
				}
			} else {
				Console.WriteLine("Error not enough cards!");
			}

		}

		public void ShowHouseCards() {
			Console.WriteLine("\nDealer Cards:");
			Console.WriteLine(string.Join("\n", dealerHand));
		}

		public void ShowPlayerCards() {
			foreach (Player player in players) {
				Console.WriteLine("\n" + player.ToString());
			}
			CheckHand();
		}

		public bool CheckDeck() {
			if (deck.GetDeck().Count() >= 7)
				return true;
			return false;
		}

		public void CheckHand() {
			foreach (Player player in players) {
				List<Card> cards = new List<Card>(7);
				cards.AddRange(player.GetHand());
				cards.AddRange(dealerHand);
				CheckSuit(player, cards);
				Console.WriteLine();
				CheckFace(player, cards);
			}
		}

		public bool CheckSuit(Player player, List<Card> cards) {
			int sameSuite = 1;
			List<Card> match = new List<Card>();
			foreach (Card card in cards) {
				
				for (int i = 0; i < cards.Count(); i++) {
					if (card.SuitIsEqual(cards[i]) && !(card.FaceIsEqual(cards[i])) && !match.Contains(cards[i]) && !match.Contains(card)) {
						match.Add(cards[i]);
						match.Add(card);
						sameSuite++;
						Console.WriteLine(card.ToString() + " : " + cards[i].ToString());
					}
				}
				sameSuite = 1;
			}
			return false;
		}

		public bool CheckFace(Player player, List<Card> cards) {

			return false;
		}

		
	}
}