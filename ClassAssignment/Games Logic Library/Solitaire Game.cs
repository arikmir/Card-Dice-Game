using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library
{
    //This class contains the game logic and the functionality of the Solitaire Game.
    public static class Solitaire_Game
    {
        private static CardPile drawPile = new CardPile();
        private static CardPile discardPile = new CardPile();
        private static Hand[] tableauPiles = new Hand[7];
        private static CardPile[] suitPiles = new CardPile[4];


        //Method SetUpGame()
        //This method sets up the Solitaire game everytime initially.
        public static void SetUpGame()
        {
            drawPile = new CardPile(true);
            discardPile = new CardPile();
            tableauPiles[0] = new Hand();
            tableauPiles[1] = new Hand();
            tableauPiles[2] = new Hand();
            tableauPiles[3] = new Hand();
            tableauPiles[4] = new Hand();
            tableauPiles[5] = new Hand();
            tableauPiles[6] = new Hand();
            suitPiles[0] = new CardPile();
            suitPiles[1] = new CardPile();
            suitPiles[2] = new CardPile();
            suitPiles[3] = new CardPile();
            drawPile.Shuffle();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    tableauPiles[i].Add(drawPile.DealOneCard());
                }
            }
        }

        //Method get_drawPile()
        //This method uses the CardPile to set up the Draw Pile.
        public static CardPile get_drawPile()
        {
            return drawPile;
        }

        //Method get_discardPile()
        //This method uses the CardPile to set up the Discard Pile.
        public static CardPile get_discardPile()
        {
            return discardPile;
        }

        //Method get_tableauPiles()
        //Uses the array of Hand to function the Tableau Piles.
        public static Hand[] get_tableauPiles()
        {
            return tableauPiles;
        }

        //Method get_suitPiles()
        //Uses the array of CardPile to add cards to the Suit Piles in later stage.
        public static CardPile[] get_suitPiles()
        {
            return suitPiles;
        }

        //Method Draw_Card()
        //Draws the cards from the cardPile.
        public static bool Draw_Card()
        {
            if (drawPile.GetCount() == 0)
            {
                return false;
            }
            else
            { discardPile.Add(drawPile.DealOneCard());
                return true;
            }
        }

        //Method Check_Position(card1, card2)
        // Checks the values of the cards by comparing between them to decide which one's bigger between two cards.
        public static bool Check_Position(Card card1, Card card2)
        {
            if (checkvalue(card1) - checkvalue(card2)==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method DistoSuit(num). 
        //This method moves the Ace card from the Discard pile to the Suit Piles.
        public static bool DisToSuit(int num)
        {
            num--;
            // if discard not null
            if (discardPile.GetCount() == 0)
            {
                return false;
            }
            //if ace
            if (checkvalue(discardPile.GetLastCardInPile()) == 1
                && suitPiles[num].GetCount()==0
                )
            {
                suitPiles[num].Add(discardPile.DealLastOneCard());

                return true;
            }
            //if not ace
            else 
            {
                    // if suit is null
                    if (suitPiles[num].GetCount() == 0)
                    {
                    return false;
                    }
                    //if facevalue is the same and value difference is 1
                    if (Check_Position(suitPiles[num].GetLastCardInPile(), discardPile.GetLastCardInPile())
                        && suitPiles[num].GetLastCardInPile().GetSuit().Equals(discardPile.GetLastCardInPile().GetSuit())
                        )
                    {
                        suitPiles[num].Add(discardPile.DealLastOneCard());
                        return true;
                    }
                return false;
              }
        }
     
        //Method Move_Card(num)
        // This method moves the cards from the Discard Pile to the Tableau Panels.
        public static bool Move_Card( int num)
        {
            num--;
            //if table is null
            if (tableauPiles[num].GetCount() == 0)
            {
                tableauPiles[num].Add(discardPile.DealLastOneCard());
                return true;
            }
            //if table is not null, compare the value
            else if (Check_Position(tableauPiles[num].GetCard(tableauPiles[num].GetCount() - 1), discardPile.GetLastCardInPile()))
            {
                tableauPiles[num].Add(discardPile.DealLastOneCard());
                return true;
            } 
            else {
                return false;
            }
        }

        //Method PanelToSuit(num1, num2)
        //This method will move the cards from the Tableau Piles to the Suit Piles.
        public static bool PanelToSuit(int num1, int num2)
        {
            num1--;
            num2--;
            //if panel is null, return false.
            if (tableauPiles[num1].GetCount()==0)
            {
                return false;
            }
            //if ace
            if (checkvalue(tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1)) == 1
               && suitPiles[num2].GetCount() == 0
               )
            {
                suitPiles[num2].Add(tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1));
                tableauPiles[num1].RemoveAt(tableauPiles[num1].GetCount() - 1);

                return true;
            }
            //if not ace and suit is null
            else if (checkvalue(tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1)) != 1
                && suitPiles[num2].GetCount() == 0
                )
            {
                return false;
            }
            //if not ace check shape and value
            else if (tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1).GetSuit().Equals(suitPiles[num2].GetLastCardInPile().GetSuit())
                &&
                Check_Position(tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1), suitPiles[num2].GetLastCardInPile()))
            {
                suitPiles[num2].Add(tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1));
                tableauPiles[num1].RemoveAt(tableauPiles[num1].GetCount() - 1);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method PanelToPanel(num1, num2)
        //The function of this method is to move the cards between the Tableau Piles.
        public static bool PanelToPanel(int num1, int num2)
        {
            num1--;
            num2--;
            //check if num1table is null
            if (tableauPiles[num1].GetCount()==0)
            {
                return false;
            }
            if (Check_Position( tableauPiles[num2].GetCard(tableauPiles[num2].GetCount() - 1), tableauPiles[num1].GetCard(tableauPiles[num1].GetCount() - 1)))
            {
                tableauPiles[num2].Add(tableauPiles[num1].GetCard(tableauPiles[num1].GetCount()-1));
                tableauPiles[num1].RemoveAt(tableauPiles[num1].GetCount() - 1);
                return true;
            }
            else {

                return false;
            }
        }

        //Mehtod checkvalue(a)
        //This method checks the numerical values of the cards by reading their face value.
        public static int checkvalue(Card a)
        {
            switch (a.GetFaceValue().ToString())
            {
                case "Ace": return 1;
                case "Two": return 2;
                case "Three": return 3;
                case "Four": return 4;
                case "Five": return 5;
                case "Six": return 6;
                case "Seven": return 7;
                case "Eight": return 8;
                case "Nine": return 9;
                case "Ten": return 10;
                case "Jack": return 11;
                case "Queen": return 12;
                case "King": return 13;
                default: return 0;
            }
        }
    }
}
