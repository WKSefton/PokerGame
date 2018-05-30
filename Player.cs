using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame {

	public class Player {

		private List<Card> myHand = new List<Card>(2);
		private PlayerName pName;

		private enum PlayerName { PlayerOne = 0, PlayerTwo = 1, PlayerThree = 2, PlayerFour = 3 }

		public Player() {
		}

		public Player(int i) {
			pName = (PlayerName)i;
		}

		public List<Card> GetHand() {
			return myHand;
		}

		public void AddCard(Card card, int i) {
			myHand.Insert(i, card);
		}

		public string GetName() {
			return pName.ToString();
		}

		public override string ToString() {
			return pName.ToString() + " Cards\n" + string.Join("\n", myHand);
		}
	}
}