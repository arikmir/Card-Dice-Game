using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;
using Games;
namespace ClassAssignment
{
    public partial class TwentyOne_Game_Form : Form
    {
        int i = 1;
        int card_index = 0;
        int number_of_ace = 0;
        public TwentyOne_Game_Form()
        {
            InitializeComponent();
        }

        private void TwentyOne_Game_Form_Load(object sender, EventArgs e)
        {
            this.Deal_button.Enabled = true;
            this.Hit_button.Enabled = false;
            this.Stand_button.Enabled = false;
            this.BUSTED_DEALER_label.Enabled = false;
            this.BUSTED_PLAYER_label.Enabled = false;
            this.Test_button.Enabled = false;
            this.BUSTED_DEALER_label.Visible = false;
            this.BUSTED_PLAYER_label.Visible = false;
        }
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand)
            {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Games.Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void Test_button_Click(object sender, EventArgs e)
        {
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;
            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();
            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));
            DisplayGuiHand(testHandForDealer, dealerTableLayoutPanel);
            DisplayGuiHand(testHandForPlayer, playerTableLayoutPanel);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {

            ResetTotals();
           
        }
        public  void ResetTotals()
        {
            this.Close();

        }

        private void Deal_button_Click(object sender, EventArgs e)
        {

            Twenty_One_Game.SetUpGame();
            DisplayGuiHand(Twenty_One_Game.GetHand(0), dealerTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(1), playerTableLayoutPanel);
            this.Deal_button.Enabled = false;
            this.Hit_button.Enabled = true;
            this.Stand_button.Enabled = true;
            this.BUSTED_DEALER_label.Visible = false;
            this.BUSTED_PLAYER_label.Visible = false;

            for (card_index = 0; card_index < Twenty_One_Game.GetHand(1).GetCount(); card_index++)
            {
                if (Twenty_One_Game.GetHand(1).GetCard(card_index).GetFaceValue().ToString() == "Ace")
                {
                    DialogResult result = MessageBox.Show("Count Ace as one?", "You Got An Ace", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // If the user clicked the Yes button
                    if (result == DialogResult.Yes)
                    {
                        Twenty_One_Game.IncrementNumOfUserAcesWithValueOne(1);
                        number_of_ace++;
                        this.label1.Text = number_of_ace.ToString();
                    }
                }
            }

            int dealer_points = Twenty_One_Game.CalculateHandTotal(0);
            int player_points = Twenty_One_Game.CalculateHandTotal(1);
            show_points(dealer_points, player_points);
            check_if_player_points_exceeds_limit(player_points);
            
        }
        private void win(int a)
        {
            if (a == 0)
            {
                BUSTED_DEALER_label.Visible = false;
                BUSTED_PLAYER_label.Visible = true;
                Twenty_One_Game.numOfGamesWon[0]= Twenty_One_Game.numOfGamesWon[0]+1;
                label2.Text = Twenty_One_Game.GetNumOfGamesWon(0).ToString();
                MessageBox.Show("House won! Better luck next time.");
            }
            else if (a == 1)
            {
                BUSTED_DEALER_label.Visible = true;
                BUSTED_PLAYER_label.Visible = false;
                Twenty_One_Game.numOfGamesWon[1] = Twenty_One_Game.numOfGamesWon[1]+1;
                label4.Text = Twenty_One_Game.GetNumOfGamesWon(1).ToString();
                MessageBox.Show("Player 1 won! Better luck next time.");
            }
            else {
                MessageBox.Show("It is a draw");
            }
            Twenty_One_Game.SetUpGame();


            this.Deal_button.Enabled = true;
            this.Hit_button.Enabled = false;
            this.Stand_button.Enabled = false;
            this.BUSTED_DEALER_label.Visible = false;
            this.BUSTED_PLAYER_label.Visible = false;
            i = 1;
        }
        private void Hit_button_Click(object sender, EventArgs e)
        {
            Twenty_One_Game.DealOneCardTo(1);
            DisplayGuiHand(Twenty_One_Game.GetHand(0), dealerTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(1), playerTableLayoutPanel);

            for (; card_index < Twenty_One_Game.GetHand(1).GetCount(); card_index++)
            {
                if (Twenty_One_Game.GetHand(1).GetCard(card_index).GetFaceValue().ToString() == "Ace")
                {
                    DialogResult result = MessageBox.Show("Count Ace as one?", "You Got An Ace", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // If the user clicked the Yes button
                    if (result == DialogResult.Yes)
                    {
                        Twenty_One_Game.IncrementNumOfUserAcesWithValueOne(1);
                        number_of_ace ++;
                        this.label1.Text = number_of_ace.ToString();
                    }
                }
            }

            int dealer_points = Twenty_One_Game.CalculateHandTotal(0);
            int player_points = Twenty_One_Game.CalculateHandTotal(1);
            show_points(dealer_points, player_points);
            check_if_player_points_exceeds_limit(player_points);
        }

        private void Stand_button_Click(object sender, EventArgs e)
        {
            int dealer_points = Twenty_One_Game.CalculateHandTotal(0);
            int player_points = Twenty_One_Game.CalculateHandTotal(1);
            show_points(dealer_points, player_points);


            while (dealer_points < 17)
            {
                Twenty_One_Game.DealOneCardTo(0);
                DisplayGuiHand(Twenty_One_Game.GetHand(0), dealerTableLayoutPanel);
                DisplayGuiHand(Twenty_One_Game.GetHand(1), playerTableLayoutPanel);

                dealer_points = Twenty_One_Game.CalculateHandTotal(0);
                show_points(dealer_points, player_points);
                check_if_dealer_points_exceeds_limit(dealer_points);
            }

            if (dealer_points < 21)
            {
                decide_the_winner(dealer_points, player_points);
            }
        }

        private void decide_the_winner(int dealer_points, int player_points)
        {
            reset_buttons();
            if (dealer_points == player_points)
            {
                MessageBox.Show("It's a tie!");
            }
            else if (dealer_points > player_points)
            {
                increment_game_won_dealer();
                MessageBox.Show("Dealer won!");
            }
            else
            {
                increment_game_won_player();
                MessageBox.Show("Player won!");
            }
        }

        private void increment_game_won_dealer()
        {
            int current_value = Convert.ToInt32(Game_won_DEALER.Text);
            current_value++;
            Game_won_DEALER.Text = current_value.ToString();
        }

        private void increment_game_won_player()
        {
            int current_value = Convert.ToInt32(Game_won_PLAYER.Text);
            current_value++;
            Game_won_PLAYER.Text = current_value.ToString();
        }

        private void show_points(int dealer_points, int player_points)
        {
            
            DEALER_POINTS_label.Text = dealer_points.ToString();
            PLAYER_POINTS_label.Text = player_points.ToString();    
        }

        private void check_if_player_points_exceeds_limit(int player_points)
        {
            if (player_points > 21)
            {
                reset_buttons();
                increment_game_won_dealer();
                this.BUSTED_PLAYER_label.Enabled = true;
                this.BUSTED_DEALER_label.Visible = false;
                this.BUSTED_PLAYER_label.Visible = true;
                MessageBox.Show("Dealer won!");

            }
        }

        private void check_if_dealer_points_exceeds_limit(int dealer_points)
        {
            if (dealer_points > 21)
            {
                reset_buttons();
                increment_game_won_player();
                this.BUSTED_DEALER_label.Enabled = true;
                this.BUSTED_DEALER_label.Visible = true;
                this.BUSTED_PLAYER_label.Visible = false;
                MessageBox.Show("Player won!");
            }
        }

        private void reset_buttons()
        {
            this.Deal_button.Enabled = true;
            this.Hit_button.Enabled = false;
            this.Stand_button.Enabled = false;
            number_of_ace = 0;
            this.label1.Text = number_of_ace.ToString();
        }

        private void DEALER_POINTS_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void PLAYER_Games_won_label_Click(object sender, EventArgs e)
        {

        }

        private void DEALER_Games_won_label_Click(object sender, EventArgs e)
        {

        }

        private void Game_won_DEALER_Click(object sender, EventArgs e)
        {

        }

        private void Games_won_PLAYER_Click(object sender, EventArgs e)
        {

        }

        private void PLAYER_POINTS_label_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
