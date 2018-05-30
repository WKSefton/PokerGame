using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame {

	class Program {

		public void PlayGame() {

		}


		static void Main(string[] args) {

			Dealer testDeal = new Dealer();
			testDeal.DealCardsToPlayers(3);
			testDeal.DealHouseCards();
			
			testDeal.ShowPlayerCards();
			testDeal.ShowHouseCards();

			//            //main eval object
			//            HandEv eval;
			//            //uses default constructor
			//            HandEv sorter;
			//            //deck object
			//            Deck d = new Deck();


			//            List<Card> hcards = new List<Card>();

			//            //shuffle the deck
			//            d.Shuffle();
			//            //pokerstars uses a 3 player format
			//            Player p1 = new Player();
			//            Player p2 = new Player();
			//            Player p3 = new Player();



			//            List<Player> players = new List<Player>();

			//            players.Add(p1);
			//            players.Add(p2);
			//            players.Add(p3);

			//            //deal two cards to each player
			//            foreach (Player p in players)
			//            {
			//                d.DealCardsToPlayers(p);    
			//            }
			//            //debug
			//            Console.WriteLine("P1 : {0} and {1}\nP2 : {2} and {3}\nP3 : {4} and {5}\n", p1.hand[0], p1.hand[1], p2.hand[0], p2.hand[1], p3.hand[0], p3.hand[1]);

			//            Console.Write("House Cards : ");
			//            //deal flop river and turn
			//            foreach (Card c in d.DealHouseCards())
			//            {
			//                Console.Write("{0} ", c.ToString());
			//                hcards.Add(c);
			//            }

			//            Console.Write("\n");
			//            //compilation of players hands
			//            List<Card> p1comp = new List<Card>();
			//            List<Card> p2comp = new List<Card>();
			//            List<Card> p3comp = new List<Card>();

			//            foreach (Card c in p1.hand)
			//            {
			//                p1comp.Add(c);
			//            }
			//            foreach (Card c in hcards)
			//            {
			//                p1comp.Add(c);
			//            }

			//            foreach (Card c in p2.hand)
			//            {
			//                p2comp.Add(c);
			//            }
			//            foreach (Card c in hcards)
			//            {
			//                p2comp.Add(c);
			//            }

			//            foreach (Card c in p3.hand)
			//            {
			//                p3comp.Add(c);
			//            }
			//            foreach (Card c in hcards)
			//            {
			//                p3comp.Add(c);
			//            }

			//            Console.Write("\nPlayer 3 Hand");

			//            //debug testing on p3
			//            foreach (Card c in p3comp)
			//            {
			//                Console.Write("\n{0} ", c.ToString());
			//            }
			//            Console.Write("\n");
			//            Console.Write("\nCards left in deck = {0} ", d.NumofCards.ToString());

			//            //sort before evaluation
			//            sorter = new HandEv();
			//            Card[] p1tosort;
			//            Card[] p1sorted;
			//            p1tosort = p1comp.ToArray();
			//            p1sorted = sorter.SortHand(p1tosort);
			//            p1comp.Clear();
			//            for (int i = 0; i < p1sorted.Length; i++)
			//            {
			//                p1comp.Add(p1sorted[i]);
			//            }

			//            //evaluate the hand
			//            eval = new HandEv(p1comp);

			//            //print results
			//            eval.PrintResults();
			//            //eval = new HandEv(p2comp);
			//            //eval.PrintResults();
			//            //eval = new HandEv(p3comp);
			//            //Console.Write("\n Player 3's hand read successfully ");
			//            //eval.PrintResults();
			//            Console.ReadKey();         
		}
	}
}
