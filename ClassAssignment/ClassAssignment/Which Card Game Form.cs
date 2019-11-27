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
    public partial class WhichCardGameForm : Form
    {
        public WhichCardGameForm()
        {
            InitializeComponent();
        }

        private void Which_Card_Game_Form_Load(object sender, EventArgs e)
        {

        }

        private void Select_Card_Game_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_Card_Game_comboBox1.SelectedIndexChanged += Select_Card_Game_comboBox1_SelectedIndexChanged;

            if (Select_Card_Game_comboBox1.Text== "Solitaire")
            {
                Solitaire_Game_Form solitaire = new Solitaire_Game_Form();
                solitaire.Show();
                Closer();
            }
            else if (Select_Card_Game_comboBox1.Text == "Twenty -One")
            {
                TwentyOne_Game_Form twentyOne = new TwentyOne_Game_Form();
                twentyOne.Show();
                Closer();
            }
        }

        public void Closer()
        {
            Exit_Card_Games_button1.Enabled = true;
            Select_Card_Game_comboBox1.Text = null;
        }

        private void Exit_Card_Games_button1_Click(object sender, EventArgs e)
        {

           DialogResult result = (MessageBox.Show("Do you really want to quit?", "Quit?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question));

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
           
            }
        }

        private void WhichCardGame_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
