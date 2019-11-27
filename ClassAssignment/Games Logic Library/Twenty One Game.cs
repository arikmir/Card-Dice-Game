using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library
{
    //This class contains the game logic and the functionality of the Twenty-One Game.
    public static class Twenty_One_Game
    {
        //0 is dealer, 1 is player
        private static CardPile cardpile = new CardPile();
        private static Hand[] hand = new Hand[2];
        private static int[] totalPoints = new int [2];
        public static int[] numOfGamesWon = new int[2];
        private static int[] numOfUserAcesWithValueOne = new int[2];

        public static void SetUpGame()
        {
            cardpile = new CardPile();
            hand[0] = null;
            hand[1] = null;
            totalPoints[0] = 0;
            totalPoints[1] = 0;
            numOfGamesWon[0] = 0;
            numOfGamesWon[1] = 0;
            numOfUserAcesWithValueOne[0] = 0;
            numOfUserAcesWithValueOne[1] = 0;
            cardpile = new CardPile(true);
            cardpile.Shuffle();
            hand[0] = new Hand(cardpile.DealCards(2));
            hand[1] = new Hand(cardpile.DealCards(2));       
        }
        
        public static Card DealOneCardTo(int who)
        {
            Card a = cardpile.DealOneCard();
            hand[who].Add(a);
            CalculateHandTotal(who);
            return a;
        }

        // Method compare()
        //This method compares the total points between the player and the dealer to decide who won.
        private static int compare()
        {
            if (GetTotalPoints(0) > GetTotalPoints(1))
            {
               // numOfGamesWon[0]++;
                return 0;
            }
            else if (GetTotalPoints(0) < GetTotalPoints(1))
            {
              //  numOfGamesWon[1]++;
                return 1;
            }
            else {
                return 2;
            }
        }

        //  Method checkvalue(a)
        //This method checks the face value of the cards, and returns the equivalent numerical values of those cards.
        private static int checkvalue(Card a)
        {
            switch (a.GetFaceValue().ToString())
            {
                case "Ace": return 11;
                case "Two": return 2;
                case "Three": return 3;
                case "Four": return 4;
                case "Five": return 5;
                case "Six": return 6;
                case "Seven": return 7;
                case "Eight": return 8;
                case "Nine": return 9;
                case "Ten": return 10;
                case "Jack": return 10;
                case "Queen": return 10;
                case "King": return 10;
                default: return 0;
            }
        }

        public static int CalculateHandTotal(int who)
        {
            int sum=0;
            int num_of_ace = 0;
            foreach (Card a in hand[who])
            {
                sum += checkvalue(a);
            }

            if (who == 1) // if player
            {
                num_of_ace = GetNumOfUserAcesWithValueOne(who);
                sum -= num_of_ace * 10;
            }
            
            totalPoints[who] = sum;

            return sum;
        }
        public static bool PlayForDealer()
        {
            if (GetTotalPoints(0) < 17)
            {
                DealOneCardTo(0);
                if (GetTotalPoints(0) > 21)
                {
                    //numOfGamesWon[1]++;
                    return false;
                }
                else if (GetTotalPoints(0) == 21)
                {
                   // numOfGamesWon[0]++;
                    return false;
                }
            }
            return true;
        }
        public static Hand GetHand(int who)
        {
            return hand[who];
        }

        public static int GetTotalPoints(int who)
        {
            return totalPoints[who];
        }

        public static int GetNumOfGamesWon(int who)
        {
            return numOfGamesWon[who];
        }

        public static int GetNumOfUserAcesWithValueOne(int who)
        {
            return numOfUserAcesWithValueOne[who];
        }

        public static void IncrementNumOfUserAcesWithValueOne(int who)
        {
            numOfUserAcesWithValueOne[who]++;
        }
    }
}
