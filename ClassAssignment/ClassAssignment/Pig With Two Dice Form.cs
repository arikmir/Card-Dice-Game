using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;
namespace ClassAssignment
{
    public partial class Pig_With_Two_Dice_Form : Form
    {
        public int time_count = 0;
        public Pig_With_Two_Dice_Form()
        {
            InitializeComponent();
            Yes_Another_pig_radioButton1.Enabled = false;
            No_another_Pig_radioButton2.Enabled = false;
            timer1.Interval = 100;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Roll_button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void Hold_button2_Click(object sender, EventArgs e)
        {
            if (Pig_Double_Die_Game.current_dice_sum == 0)
            {

            } else{
                if (Pig_Double_Die_Game.current_player == "Player 1")
                {
                    Player_1_textbox.Text = Pig_Double_Die_Game.GetPointsTotal("Player 1").ToString();
                    Pig_Double_Die_Game.current_player = "Player 2";
                    Whose_Turn_to_label.Text = "Player 2 Roll Die";

                    if (Pig_Double_Die_Game.HasWon() == true)
                    {
                        MessageBox.Show("Player 1 has won!");
                        Yes_Another_pig_radioButton1.Enabled = true;
                        No_another_Pig_radioButton2.Enabled = true;
                    }

                    Pig_Double_Die_Game.current_dice_sum = 0;
                }
                else
                {
                    Player_2_textbox.Text = Pig_Double_Die_Game.GetPointsTotal("Player 2").ToString();
                    Pig_Double_Die_Game.current_player = "Player 1";
                    Whose_Turn_to_label.Text = "Player 1 Roll Die";

                    if (Pig_Double_Die_Game.HasWon() == true)
                    {
                        MessageBox.Show("Player 2 has won!");
                        Yes_Another_pig_radioButton1.Enabled = true;
                        No_another_Pig_radioButton2.Enabled = true;
                    }

                    Pig_Double_Die_Game.current_dice_sum = 0;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_count == 10)
            {
                time_count = 0;
                timer1.Stop();
                if (Pig_Double_Die_Game.PlayGame() == true)
                {
                    MessageBox.Show("Sorry you have thrown a 1\n Your turn is over!\n");
                    if (Pig_Double_Die_Game.current_player == "Player 1")
                    {
                        Whose_Turn_to_label.Text = "Player 2 Roll Die";
                        Pig_Double_Die_Game.current_player = "Player 2";
                        Pig_Double_Die_Game.current_dice_sum = 0;
                    }
                    else
                    {
                        Whose_Turn_to_label.Text = "Player 1 Roll Die";
                        Pig_Double_Die_Game.current_player = "Player 1";
                        Pig_Double_Die_Game.current_dice_sum = 0;
                    }
                }
                else
                {
                   
                }
            }
            else
            {
                time_count++;              
                pictureBox1.Image = Games.Images.GetDieImage(Pig_Double_Die_Game.GetFaceValue()[0]);
                pictureBox2.Image = Games.Images.GetDieImage(Pig_Double_Die_Game.GetFaceValue()[1]);
            }
        }

        private void Yes_Another_pig_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void No_another_Pig_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pig_With_Two_Dice_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
