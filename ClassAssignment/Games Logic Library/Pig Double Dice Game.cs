using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library
{
    //This class contains the game logic and the functionality of the Pig Double Dice Game.
    
    public static class Pig_Double_Die_Game
    {
        private static Die[] die = new Die[2];
        private static int[] faceValue= new int [2];
        private static int[] pointsTotal = new int[2];
        private static string[] playersName = new string[2];
        private static int win_num = 100;
        public static bool is_other;

        public static string current_player = "Player 1";
        public static int current_dice_sum = 0;


        public static void SetUpGame()
        {

        }

        public static bool PlayGame()
        {
            if (faceValue[0] == 1 && faceValue[1] == 1  )
            {
                current_dice_sum = 25;
                faceValue[0] = 0;
                faceValue[1] = 0;
                return false;

            }
            else if (faceValue[0] == 1 || faceValue[1] == 1)
            {
                current_dice_sum = 0;
                faceValue[0] = 0;
                faceValue[1] = 0;
                return true;
            }
            else if(faceValue[0] == 2 && faceValue[1] == 2)
            {
                current_dice_sum = 8;
                 faceValue[0] = 0;
                faceValue[1] = 0;
                return false;
            }
            else if (faceValue[0] == 3 && faceValue[1] == 3)
            {
                current_dice_sum = 12;
                  faceValue[0] = 0;
                faceValue[1] = 0;
                return false;
            }
            else if (faceValue[0] == 4 && faceValue[1] == 4)
            {
                current_dice_sum = 16;
                 faceValue[0] = 0;
                faceValue[1] = 0;
                return false;
            }
            else if (faceValue[0] == 5 && faceValue[1] == 5)
            {
                current_dice_sum = 20;
                 faceValue[0] = 0;
                faceValue[1] = 0;
                return false;
            }
            else if (faceValue[0] == 6 && faceValue[1] == 6)
            {
                current_dice_sum = 24;
                 faceValue[0] = 0;
                faceValue[1] = 0;
                return false;
            }
            else
            {         
                current_dice_sum = faceValue[0] + faceValue[1];
                faceValue[0] = 0;
                faceValue[1] = 0;
                return false;
            }
        }

        public static bool HasWon()
        {
            if (pointsTotal[0] >= win_num)
            {
                return true;
            } else if (pointsTotal[1] >= win_num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetFirstPlayersName()
        {
            return "Player 1";
        }

        public static string GetNextPlayersName()
        {
            return "Player 2";
        }

        public static int GetPointsTotal(string nameofPlayer)
        {
            if (nameofPlayer == "Player 1")
            {
                pointsTotal[0] += current_dice_sum ;
                return pointsTotal[0];
            }
            else
            {
                pointsTotal[1] += current_dice_sum;
                return pointsTotal[1];
            }
        }

        public static int[] GetFaceValue()
        {
            Random ran = new Random();
            faceValue[0] = ran.Next(1,7);
            faceValue[1] = ran.Next(1, 7);
            return faceValue;
        }
    }
}
