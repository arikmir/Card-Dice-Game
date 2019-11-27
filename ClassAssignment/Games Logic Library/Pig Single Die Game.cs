using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library
{
    //This class contains the game logic and the functionality of the Pig Single Die Game.
    public static class Pig_Single_Die_Game
    {
        private static Die die;
        private static int faceValue;
        private static int[] pointsTotal;
        private static string[] playersName;
        private static int win_num = 30;

        public static string current_player = "Player 1";
        public static int player1_total_score = 0;
        public static int player2_total_score = 0;
        public static int current_dice_num;

        public static void SetUpGame()
        {
            
        }

        public static bool PlayGame(int num)
        {
            if (num == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool HasWon(int num)
        {
            if (num >= win_num)
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

       public static string GetSecondPlayersName()
       {
            return "Player 2";
        }

       public static int GetPointsTotal(string nameofPlayer)
       {    if (nameofPlayer == "Player 1")
            {
                return player1_total_score;
            }
            else
            {
                return player2_total_score;
            }
       }

        public static int GetFaceValue()
        {
            Random ran = new Random();
            
            return ran.Next(1,7);
        }














    }
}
