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
    public partial class Which_Dice_Game_Form : Form
    {
        public Which_Dice_Game_Form()
        {
            InitializeComponent();
        }

        private void Which_Dice_Game_Form_Load(object sender, EventArgs e)
        {

        }

        private void Single_Die_Pig_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Single_Pig_Game_Form singledie = new Single_Pig_Game_Form();

            if (Single_Die_Pig_radioButton1.Checked)
            {
                singledie.Show();
            }
        }

        private void Two_Dice_Pig_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pig_With_Two_Dice_Form twodice = new Pig_With_Two_Dice_Form();

            if (Two_Dice_Pig_radioButton2.Checked)
            {
                twodice.Show();
            }
        }

        private void Select_Pig_To_Play_groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Exit_Dice_Game_button1_Click(object sender, EventArgs e)
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
    }
       
    }

