using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment
{
    public partial class InitialGuiForm : Form
    {
        public InitialGuiForm()
        {
            InitializeComponent();
            Start_button1.Enabled = false;
            Start_button1.Visible = true;
        }

        private void Select_game_groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dice_game_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Start_button1.Enabled = true;
            Start_button1.Visible = true;
        }

        private void Card_game_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Start_button1.Enabled = true;
            Start_button1.Visible = true;
        }

        private void Start_button1_Click(object sender, EventArgs e)
        {
            if (Dice_game_radioButton1.Checked)
            {
               Which_Dice_Game_Form Gameform= new Which_Dice_Game_Form();
                Gameform.Show();
            }
            else
            {
                WhichCardGameForm Gameform2 = new WhichCardGameForm();
                Gameform2.Show();
            }
        }

        private void Exit_button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You Very Much For Playing. ");
            base.Dispose();
        }

        private void InitialGuiForm_Load(object sender, EventArgs e)
        {

        }
    }

}
