using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame {
	//main eval function.  takes a parameter of lists of cards, which will be the players hand to evaluate
	public class HandEv {



		//		#region vars
		//		public bool IsRoyalFlush = false;
		//		public bool IsStraightFlush = false;
		//		public bool IsFourKind = false;
		//		public bool IsFullHouse = false;
		//		public bool IsFlush = false;
		//		public bool IsStraight = false;
		//		public bool IsThreeKind = false;
		//		public bool IsTwoPair = false;
		//		public bool IsPair = false;
		//		public bool IsHighCard = false;
		//		public int Rflush = 0;
		//		public int Sflush = 0;
		//		public int fourkind = 0;
		//		public int fullhouse = 0;
		//		public int straight = 0;
		//		public int flush = 0;
		//		public int threekind = 0;
		//		public int twopair = 0;
		//		public int pair = 0;
		//		public int highcard = 0;

		//		int numclub = 0;
		//		int numspade = 0;
		//		int numheart = 0;
		//		int numdiamond = 0;
		//		//int holder for face
		//		int numoface = 0;
		//		int numofking = 0;
		//		int numofqueen = 0;
		//		int numofjack = 0;
		//		int numoftens = 0;
		//		int numofnine = 0;
		//		int numofeight = 0;
		//		int numofseven = 0;
		//		int numofsix = 0;
		//		int numoffive = 0;
		//		int numoffour = 0;
		//		int numofthree = 0;
		//		int numoftwo = 0;

		//		Card[] tempcardarray = new Card[7];
		//		List<Card> phandcopy = new List<Card>();

		//		public HandEv() { }

		//		public HandEv(List<Card> phand) {
		//			//placeholer variables
		//			#region variables
		//			//int holder for suit
		//			numclub = 0;
		//			numspade = 0;
		//			numheart = 0;
		//			numdiamond = 0;
		//			//int holder for face
		//			numoface = 0;
		//			numofking = 0;
		//			numofqueen = 0;
		//			numofjack = 0;
		//			numoftens = 0;
		//			numofnine = 0;
		//			numofeight = 0;
		//			numofseven = 0;
		//			numofsix = 0;
		//			numoffive = 0;
		//			numoffour = 0;
		//			numofthree = 0;
		//			numoftwo = 0;

		//			//copies the hand to evaluate to a card array for manipulation
		//			phand.CopyTo(tempcardarray);

		//			//list to print
		//			Card[] tempforfinal = new Card[7];

		//			ClearStuff();
		//			//This is where a bulk of the issue is.  For instance, if i have a 3 of a kind, when i loop through the array
		//			//it finds 2 x two pairs, just check my logic, maybe i need to convert all of the regions into class methods?
		//			//
		//			//without checking for just isstraight && isflush
		//			#region RoyalFlush

		//			for (int i = 0; i < tempcardarray.Length; i++) {
		//				if (tempcardarray[i].GetFace() == Face.Ace) {
		//					numoface++;
		//					tempforfinal[i] = tempcardarray[i];
		//				}
		//				if (tempcardarray[i].GetFace() == Face.King) {
		//					numofking++;
		//					tempforfinal[i] = tempcardarray[i];
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Queen) {
		//					numofqueen++;
		//					tempforfinal[i] = tempcardarray[i];
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Jack) {
		//					numofjack++;
		//					tempforfinal[i] = tempcardarray[i];
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Ten) {
		//					numoftens++;
		//					tempforfinal[i] = tempcardarray[i];
		//				}
		//				//ClearStuff();
		//			}

		//			if (tempforfinal.Length < 5) {
		//				IsRoyalFlush = false;
		//				//dont increment the number of royal flushes because we didnt even have enough
		//				//potential cards in the array           
		//			} else {
		//				if (numoftens >= 1 && numofjack >= 1 && numofqueen >= 1 && numofking >= 1 && numoface >= 1) {
		//					if (tempforfinal[0].GetSuit() == tempforfinal[1].GetSuit()) {
		//						if (tempforfinal[1].GetSuit() == tempforfinal[2].GetSuit()) {
		//							if (tempforfinal[2].GetSuit() == tempforfinal[3].GetSuit()) {
		//								if (tempforfinal[3].GetSuit() == tempforfinal[4].GetSuit()) {
		//									Rflush++;
		//									IsRoyalFlush = true;
		//									straight--;
		//									IsStraight = false;
		//									flush--;
		//									IsFlush = false;
		//									tempforfinal = null;
		//								}
		//							}
		//						}
		//					}
		//				} else {
		//					IsRoyalFlush = false;
		//					ClearStuff();
		//				}
		//			}

		//			//ClearStuff();
		//			//done
		//			4kind
		//			for (int i = 0; i < tempcardarray.Length; i++) {
		//				if (tempcardarray[i].GetFace() == Face.Two) {
		//					numoftwo++;
		//					if (numoftwo == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Three) {
		//					numofthree++;
		//					if (numofthree == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Four) {
		//					numoffour++;
		//					if (numoffour == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Five) {
		//					numoffive++;
		//					if (numoffive == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Six) {
		//					numofsix++;
		//					if (numofsix == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Seven) {
		//					numofseven++;
		//					if (numofseven == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Eight) {
		//					numofeight++;
		//					if (numofeight == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Nine) {
		//					numofnine++;
		//					if (numofnine == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Ten) {
		//					numoftens++;
		//					if (numoftens == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Jack) {
		//					numofjack++;
		//					if (numofjack == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Queen) {
		//					numofqueen++;
		//					if (numofqueen == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.King) {
		//					numofking++;
		//					if (numofking == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Ace) {
		//					numoface++;
		//					if (numoface == 4) {
		//						IsFourKind = true;
		//						fourkind++;
		//					}
		//				}
		//			}
		//			#endregion
		//			//ClearStuff();
		//			//done
		//			#region Flush
		//			for (int i = 0; i < tempcardarray.Length; i++) {
		//				switch (tempcardarray[i].GetSuit()) {
		//					case Suit.Clubs:
		//						numclub++;
		//						break;
		//					case Suit.Diamonds:
		//						numdiamond++;
		//						break;
		//					case Suit.Hearts:
		//						numheart++;
		//						break;
		//					case Suit.Spades:
		//						numspade++;
		//						break;
		//				}
		//			}
		//			if (numclub >= 5) {
		//				IsFlush = true;
		//				flush++;
		//			}
		//			if (numdiamond >= 5) {
		//				IsFlush = true;
		//				flush++;
		//			}
		//			if (numheart >= 5) {
		//				IsFlush = true;
		//				flush++;
		//			}
		//			if (numspade >= 5) {
		//				IsFlush = true;
		//				flush++;
		//			}

		//			#endregion
		//			//since the array is sorted, well start at index 0 and check to 5, 1 then check  to 6 and 2 check to 7
		//			//this is going to determine the straight based on the first 3 cards because at 4 you only have a 4 card 
		//			//hand -  i know this is a problem because if i have a hand of  2, 3, 4, 5, 6, 6, 7 this fails the check
		//			//need to determine if the current face is equal to the next, hold the place in the check line and go to the
		//			//next element for comparison.  maybe i can fix this during the sorthand method??
		//			#region Straight
		//			if (tempcardarray[0].GetFace() == (tempcardarray[1].GetFace() - 1)) {
		//				if (tempcardarray[1].GetFace() == (tempcardarray[2].GetFace() - 1)) {
		//					if (tempcardarray[2].GetFace() == (tempcardarray[3].GetFace() - 1)) {
		//						if (tempcardarray[3].GetFace() == (tempcardarray[4].GetFace() - 1)) {
		//							IsStraight = true;
		//							straight++;
		//						}
		//					}
		//				}
		//			}
		//			if (tempcardarray[1].GetFace() == (tempcardarray[2].GetFace() - 1)) {
		//				if (tempcardarray[2].GetFace() == (tempcardarray[3].GetFace() - 1)) {
		//					if (tempcardarray[3].GetFace() == (tempcardarray[4].GetFace() - 1)) {
		//						if (tempcardarray[4].GetFace() == (tempcardarray[5].GetFace() - 1)) {
		//							IsStraight = true;
		//							straight++;
		//						}
		//					}
		//				}
		//			}
		//			if (tempcardarray[2].GetFace() == (tempcardarray[3].GetFace() - 1)) {
		//				if (tempcardarray[3].GetFace() == (tempcardarray[4].GetFace() - 1)) {
		//					if (tempcardarray[4].GetFace() == (tempcardarray[5].GetFace() - 1)) {
		//						if (tempcardarray[5].GetFace() == (tempcardarray[6].GetFace() - 1)) {
		//							IsStraight = true;
		//							straight++;
		//						}
		//					}
		//				}
		//			}
		//			#endregion
		//			//done
		//			#region 3kind
		//			for (int i = 0; i < tempcardarray.Length; i++) {
		//				if (tempcardarray[i].GetFace() == Face.Two) {
		//					if (numoftwo < 3) {
		//						numoftwo++;
		//					}
		//					if ((numoftwo == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Three) {
		//					if (numofthree < 3) {
		//						numofthree++;
		//					}
		//					if ((numofthree == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Four) {
		//					if (numoffour < 3) {
		//						numoffour++;
		//					}
		//					if ((numoffour == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Five) {
		//					if (numoffive < 3) {
		//						numoffive++;
		//					}
		//					if ((numoffive == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Six) {
		//					if (numofsix < 3) {
		//						numofsix++;
		//					}
		//					if ((numofsix == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = true;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Seven) {
		//					if (numofseven < 3) {
		//						numofseven++;
		//					}
		//					if ((numofseven == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Eight) {
		//					if (numofeight < 3) {
		//						numofeight++;
		//					}
		//					if ((numofeight == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Nine) {
		//					if (numofnine < 3) {
		//						numofnine++;
		//					}
		//					if ((numofnine == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Ten) {
		//					if (numoftens < 3) {
		//						numoftens++;
		//					}
		//					if ((numoftens == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Jack) {
		//					if (numofjack < 3) {
		//						numofjack++;
		//					}
		//					if ((numofjack == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Queen) {
		//					if (numofqueen < 3) {
		//						numofqueen++;
		//					}
		//					if ((numofqueen == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.King) {
		//					if (numofking < 3) {
		//						numofking++;
		//					}
		//					if ((numofking == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//				if (tempcardarray[i].GetFace() == Face.Ace) {
		//					if (numoface < 3) {
		//						numoface++;
		//					}
		//					if ((numoface == 3) && (threekind < 1)) {
		//						IsThreeKind = true;
		//						IsTwoPair = false;
		//						threekind++;
		//					}
		//				}
		//			}
		//			#endregion
		//			//done
		//			#region pair
		//			if (tempcardarray[0].GetFace() == tempcardarray[1].GetFace()) {
		//				IsPair = true;
		//				pair++;
		//			}
		//			if (tempcardarray[1].GetFace() == tempcardarray[2].GetFace()) {
		//				IsPair = true;
		//				pair++;
		//			}
		//			if (tempcardarray[2].GetFace() == tempcardarray[3].GetFace()) {
		//				IsPair = true;
		//				pair++;
		//			}
		//			if (tempcardarray[3].GetFace() == tempcardarray[4].GetFace()) {
		//				IsPair = true;
		//				pair++;
		//			}
		//			if (tempcardarray[4].GetFace() == tempcardarray[5].GetFace()) {
		//				IsPair = true;
		//				pair++;
		//			}
		//			if (tempcardarray[5].GetFace() == tempcardarray[6].GetFace()) {
		//				IsPair = true;
		//				pair++;
		//			}
		//			#endregion

		//			#region twopair
		//			if (pair == 2) {
		//				IsTwoPair = true;
		//				IsPair = false;

		//				if (twopair < 1) {
		//					twopair++;
		//				}
		//			}
		//			#endregion

		//			#region StraightFlush
		//			//should only be if(isstraight && isFlush)
		//			if (IsStraight && IsFlush) {
		//				IsStraightFlush = true;
		//				Sflush++;
		//				IsStraight = false;
		//				IsFlush = false;
		//			}
		//			#endregion


		//			#region FullHouse
		//			// should only be if(ispair && is3kind)
		//			if ((threekind == 1) && (pair == 1)) {
		//				fullhouse++;
		//				IsFullHouse = true;
		//			}
		//			#endregion

		//			#region highcard
		//			if ((IsRoyalFlush == false) && (IsStraight == false) && (IsFlush == false) && (IsStraightFlush == false) &&
		//				 (IsFullHouse == false) && (IsFourKind == false) && (IsPair == false) && (IsThreeKind == false)) {
		//				highcard = (int)tempcardarray[6].GetFace();
		//				IsHighCard = true;
		//			}

		//			#endregion
		//			//ClearStuff();

		//		}

		//		public void ClearStuff() {
		//			numoftwo = 0;
		//			numofthree = 0;
		//			numoffour = 0;
		//			numoffive = 0;
		//			numofsix = 0;
		//			numofseven = 0;
		//			numofeight = 0;
		//			numofnine = 0;
		//			numoftens = 0;
		//			numofjack = 0;
		//			numofqueen = 0;
		//			numofking = 0;
		//			numoface = 0;
		//		}

		//		//basically a debug function that gets the sorted array and prints it, then should print the winning hand
		//		//result with a +1 value
		//		public void PrintResults() {
		//			Card[] cardresults = new Card[7];

		//			for (int i = 0; i < tempcardarray.Length; i++) {
		//				Console.Write("\n {0} ", tempcardarray[i].GetFace().ToString());
		//				cardresults[i] = tempcardarray[i];
		//			}
		//			//Console.Write("\n Sorted.....");
		//			//SortHand(cardresults);
		//			if (IsHighCard) {
		//				Console.Write("\n High Card wins : {0}", cardresults[7].ToString());
		//			}
		//			if (IsPair) {
		//				Console.Write("\n Pair wins : {0}", pair);
		//			}
		//			if (IsTwoPair) {
		//				Console.Write("\n Two Pair wins : {0}", twopair);
		//			}
		//			if (IsThreeKind) {
		//				Console.Write("\n 3 of Kind wins : {0}", threekind);
		//			}
		//			if (IsStraight) {
		//				Console.Write("\n Straight wins : {0}", straight);
		//			}
		//			if (IsFlush) {
		//				Console.Write("\n Flush wins : {0}", flush);
		//			}
		//			if (IsFullHouse) {
		//				Console.Write("\n Boat wins : {0}", fullhouse);
		//			}
		//			if (IsFourKind) {
		//				Console.Write("\n 4 of Kind wins : {0}", fourkind);
		//			}
		//		}

		//		//sort the hand for the main eval method
		//		public Card[] SortHand(Card[] sortme) {
		//			Card[] temp = new Card[sortme.Length];
		//			Card[] temp2 = new Card[sortme.Length];

		//			sortme.CopyTo(temp, 0);

		//			//cool little linq method of sorting array instead of having to call an interface IComparer
		//			var sh = temp
		//				.OrderByDescending(g => g.GetFace());

		//			for (int i = 0; i < temp.Length; i++) {
		//				temp2[i] = sh.ElementAt(i);
		//			}
		//			//complete the ordering - ascending
		//			Array.Reverse(temp2);
		//			return temp2;
		//		}
	}
}