using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassAssignment
{
    public partial class Single_Pig_Game_Form : Form
    {
      
        public Single_Pig_Game_Form()
        {
            InitializeComponent();
            Yes_Another_pig_radioButton1.Enabled = false;
            No_another_Pig_radioButton2.Enabled = false;
        }

        private void Single_Pig_Game_Form_Load(object sender, EventArgs e)
        {

        }

        private void Roll_button1_Click(object sender, EventArgs e)
        {
            Games_Logic_Library.Pig_Single_Die_Game.current_dice_num = Games_Logic_Library.Pig_Single_Die_Game.GetFaceValue();
            pictureBox1.Image = Games.Images.GetDieImage(Games_Logic_Library.Pig_Single_Die_Game.GetFaceValue());
            if (Games_Logic_Library.Pig_Single_Die_Game.PlayGame(Games_Logic_Library.Pig_Single_Die_Game.current_dice_num) == true)
            {
                MessageBox.Show("Sorry you have thrown a 1\n Your turn is over!\n Your score reverts to 0");
                if (Games_Logic_Library.Pig_Single_Die_Game.current_player == "Player 1")
                {
                    Games_Logic_Library.Pig_Single_Die_Game.player1_total_score = 0;
                    Player_1_textbox.Text="0";
                    Games_Logic_Library.Pig_Single_Die_Game.current_player = "Player 2";
                    Whose_Turn_to_label.Text = "Player 2 Roll Die";
                }
                else {
                    Games_Logic_Library.Pig_Single_Die_Game.player2_total_score = 0;
                    Player_2_textbox.Text = "0";
                    Games_Logic_Library.Pig_Single_Die_Game.current_player = "Player 1";
                    Whose_Turn_to_label.Text = "Player 1 Roll Die";
                }
            }    
            else
            {
                
            }
        }

        private void Hold_button2_Click(object sender, EventArgs e)
        {
            if (Games_Logic_Library.Pig_Single_Die_Game.current_player == "Player 1")
            {
                Games_Logic_Library.Pig_Single_Die_Game.player1_total_score = Games_Logic_Library.Pig_Single_Die_Game.player1_total_score + Games_Logic_Library.Pig_Single_Die_Game.current_dice_num;
                Player_1_textbox.Text = Games_Logic_Library.Pig_Single_Die_Game.player1_total_score.ToString();
                Games_Logic_Library.Pig_Single_Die_Game.current_player = "Player 2";
                Whose_Turn_to_label.Text = "Player 2 Roll Die";
                Games_Logic_Library.Pig_Single_Die_Game.current_dice_num = 0;
                if (Games_Logic_Library.Pig_Single_Die_Game.HasWon(Games_Logic_Library.Pig_Single_Die_Game.player1_total_score) == true)
                {
                    MessageBox.Show("Player 1 has won!");
                    Yes_Another_pig_radioButton1.Enabled = true;
                    No_another_Pig_radioButton2.Enabled = true;
                }
            }
            else
            {
                Games_Logic_Library.Pig_Single_Die_Game.player2_total_score = Games_Logic_Library.Pig_Single_Die_Game.player2_total_score + Games_Logic_Library.Pig_Single_Die_Game.current_dice_num;
                Player_2_textbox.Text = Games_Logic_Library.Pig_Single_Die_Game.player2_total_score.ToString();
                Games_Logic_Library.Pig_Single_Die_Game.current_player = "Player 1";
                Whose_Turn_to_label.Text = "Player 1 Roll Die";
                Games_Logic_Library.Pig_Single_Die_Game.current_dice_num = 0;
                if (Games_Logic_Library.Pig_Single_Die_Game.HasWon(Games_Logic_Library.Pig_Single_Die_Game.player2_total_score) == true)
                {
                    MessageBox.Show("Player 2 has won!");
                    Yes_Another_pig_radioButton1.Enabled = true;
                    No_another_Pig_radioButton2.Enabled = true;
                }
            }
           
        }

        public void reset()
        {
            Yes_Another_pig_radioButton1.Enabled = false;
            No_another_Pig_radioButton2.Enabled = false;
            Player_1_textbox.Text = "0";
            Player_2_textbox.Text = "0";
            Whose_Turn_to_label.Text = "Player 1 Roll Die";
            Games_Logic_Library.Pig_Single_Die_Game.player1_total_score = 0;
            Games_Logic_Library.Pig_Single_Die_Game.player2_total_score = 0;
            Games_Logic_Library.Pig_Single_Die_Game.current_player = "Player 1";
        }

        private void Yes_Another_pig_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void No_another_Pig_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Whose_Turn_to_label_Click(object sender, EventArgs e)
        {

        }

        private void Player_1_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Player_2_textbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
