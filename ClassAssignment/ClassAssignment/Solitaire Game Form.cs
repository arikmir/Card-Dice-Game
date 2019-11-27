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
using Low_Level_Objects_Library;

namespace ClassAssignment
{
   
    public partial class Solitaire_Game_Form : Form
    {
        //current location
        public System.Drawing.Point p1_now = new System.Drawing.Point();
        public System.Drawing.Point p2_now = new System.Drawing.Point();
        //prevoius location
        public System.Drawing.Point p_pre = new System.Drawing.Point();
      
        public bool Is_mousedown;

        //check current select
        public bool Is_discard_selected=false;
        public bool Is_panel1_selected =false;
        public bool Is_panel2_selected = false;
        public bool Is_panel3_selected = false;
        public bool Is_panel4_selected = false;
        public bool Is_panel5_selected = false;
        public bool Is_panel6_selected = false;
        public bool Is_panel7_selected = false;
        public bool Is_suit1_selected = false;
        public bool Is_suit2_selected = false;
        public bool Is_suit3_selected = false;
        public bool Is_suit4_selected = false;

        //how many cards should be displayed in each panel
        public int num_shown_panel1 = 1;
        public int num_shown_panel2 = 1;
        public int num_shown_panel3 = 1;
        public int num_shown_panel4 = 1;
        public int num_shown_panel5 = 1;
        public int num_shown_panel6 = 1;
        public int num_shown_panel7 = 1;

        public void reset_is_select()
        {
            Is_discard_selected = false;
        Is_panel1_selected = false;
        Is_panel2_selected = false;
        Is_panel3_selected = false;
        Is_panel4_selected = false;
        Is_panel5_selected = false;
         Is_panel6_selected = false;
         Is_panel7_selected = false;
        Is_suit1_selected = false;
         Is_suit2_selected = false;
        Is_suit3_selected = false;
        Is_suit4_selected = false;
        }
        public Solitaire_Game_Form()
        {
            InitializeComponent();
            Solitaire_Game.SetUpGame();
            Display7table(1);
            Display7table(2);
            Display7table(3);
            Display7table(4);
            Display7table(5);
            Display7table(6);
            Display7table(7);
            Displaydraw(false);
            Displaydiscard();

            Is_discard_selected = false;
        }

        private void Displaydraw(bool empty)
        {
            Drawcard_Pile_pictureBox1.Controls.Clear();          
            if (empty == true)
            {
                Drawcard_Pile_pictureBox1.Image = null;
            }
            else
            {
                Drawcard_Pile_pictureBox1.Image = Games.Images.GetBackOfCardImage();
            }
        }

        private void Displaydiscard()
        {
            CardPile dis = Solitaire_Game.get_discardPile();
             if (dis.GetCount() > 0)
            {
                Discard_Pile_pictureBox1.Image = Games.Images.GetCardImage(dis.GetLastCardInPile());
            } else if (dis.GetCount() == 0)
            {
                Discard_Pile_pictureBox1.Image = null;
            }

        }

        private void Displaysuit(int num)
        {
            num--;
            CardPile[] suit = Solitaire_Game.get_suitPiles();
            if (num == 0)
            {
                Suit_Pile1_pictureBox.Image = Games.Images.GetCardImage(suit[num].GetLastCardInPile());
            }
            else if (num == 1)
            {
                Suit_Pile2_pictureBox.Image = Games.Images.GetCardImage(suit[num].GetLastCardInPile());
            }
            else if (num == 2)
            {
                Suit_Pile3_pictureBox.Image = Games.Images.GetCardImage(suit[num].GetLastCardInPile());
            }
            else if (num == 3)
            {
                Suit_Pile4_pictureBox.Image = Games.Images.GetCardImage(suit[num].GetLastCardInPile());
            }         
        }

        private void Display7table( int i)
        {
            TableLayoutPanel tableLayoutPanel;
          
            int num_shown;

            Hand[] hand = Solitaire_Game.get_tableauPiles();
            if (i == 1)
            {
                tableLayoutPanel = tableLayoutPanel1;
                num_shown = num_shown_panel1;
            }
            else if (i == 2)
            {
                num_shown = num_shown_panel2;
                tableLayoutPanel = tableLayoutPanel2;
            }
            else if (i == 3)
            {
                num_shown = num_shown_panel3;
                tableLayoutPanel = tableLayoutPanel3;
            }
            else if (i == 4)
            {
                num_shown = num_shown_panel4;
                tableLayoutPanel = tableLayoutPanel4;
            }
            else if (i == 5)
            {
                num_shown = num_shown_panel5;
                tableLayoutPanel = tableLayoutPanel5;
            }
            else if (i == 6)
            {
                num_shown = num_shown_panel6;
                tableLayoutPanel = tableLayoutPanel6;
            }
            else
            {
                num_shown = num_shown_panel7;
                tableLayoutPanel = tableLayoutPanel7;
            }
             tableLayoutPanel.Controls.Clear();
            i--;

            if (hand[i].GetCount() == 0)
            {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = null;
            }
            else { 
            for (int j=0; j< hand[i].GetCount()- num_shown; j++ )
                {
                    // Construct a PictureBox object.
                    PictureBox pictureBox = new PictureBox();
                    // Set the PictureBox to use all of its space
                    pictureBox.Dock = DockStyle.Fill;
                    // Remove spacing around the PictureBox. (Default is 3 pixels.)
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Image = Games.Images.GetBackOfCardImage();
                // Add the PictureBox object to the tableLayoutPanel.
               
                tableLayoutPanel.Controls.Add(pictureBox);
                
              
                }
            for (int j = hand[i].GetCount() - num_shown; j< hand[i].GetCount();j++ )
            {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Games.Images.GetCardImage(hand[i].GetCard(j));
                tableLayoutPanel.Controls.Add(pictureBox);
            }
            }

        }
        // End DisplayGuiHand

        private void Drawcard_Pile_pictureBox1_Click(object sender, EventArgs e)
        {
            CardPile draw = Solitaire_Game.get_drawPile();

            if (Solitaire_Game.Draw_Card() == true)

            {
                Displaydraw(false);
            }
            else
            {
                Displaydraw(true);
            }
            Displaydiscard();
            reset_is_select();
        }
     
        private void return_to_prevoius_location()
        {

        }

        private void Solitaire_Game_Form_MouseUp(object sender, MouseEventArgs e)
        {
           
               
        }

        private void Discard_Pile_pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (Is_panel_selected()>0 |
                Is_suit1_selected == true |
                 Is_suit2_selected == true |
                  Is_suit3_selected == true |
                   Is_suit4_selected == true 
                )
            {
                MessageBox.Show("Cannot place card onto Discard Pile");
                reset_is_select();
            }
            else {
                reset_is_select();
                Is_discard_selected = true;
            }
        }

        private void Solitaire_Game_Form_Load(object sender, EventArgs e)
        {

        }

        private void Solitaire_Game_Form_MouseClick(object sender, MouseEventArgs e)
        {
          //  MessageBox.Show("x:" + e.Location.X + "  y:" + e.Location.Y);
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            // MessageBox.Show("x:" + e.Location.X + "  y:" + e.Location.Y);
            if (Is_discard_selected == true)
            {
                Hand[] h = Solitaire_Game.get_tableauPiles();
                if (h[0].GetCount() == 0)
                { num_shown_panel1=1; }
                if (Solitaire_Game.Move_Card(1) == true)
                {
                    Display7table(1);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a=Is_panel_selected()) > 0)
            {
                if (a != 1)
                {
                    if (Solitaire_Game.PanelToPanel(a, 1))
                    {
                        num_shown_panel1++;
                        reduce_num(a);
                    }
                    else
                    {
                        MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(1);
                }
                else {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel1_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel1_selected = true;
            }
        }

        private void tableLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.Move_Card(2) == true)
                {
                    num_shown_panel2++;
                    Display7table(2);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                if (a != 2)
                {

                    if (Solitaire_Game.PanelToPanel(a, 2))
                    {
                        reduce_num(a);
                        num_shown_panel2++;
                    }
                    else
                    {
                        MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(2);
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel2_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel2_selected = true;
            }
        }

        private void tableLayoutPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.Move_Card(3) == true)
                {
                    num_shown_panel3++;
                    Display7table(3);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                if (a != 3)
                {
                    if (Solitaire_Game.PanelToPanel(a, 3))
                    {
                        reduce_num(a);
                        num_shown_panel3++;
                    }
                    else
                    {
                        MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(3);
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel3_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel3_selected = true;
            }
        }

        private void tableLayoutPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.Move_Card(4) == true)
                {
                    num_shown_panel4++;
                    Display7table(4);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                if (a != 4)
                {
                    if (Solitaire_Game.PanelToPanel(a, 4))
                    {
                        reduce_num(a);
                        num_shown_panel4++;
                    }
                    else
                    {
                        MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(4);
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel4_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel4_selected = true;
            }
        }

        private void tableLayoutPanel5_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.Move_Card(5) == true)
                {
                    
                    num_shown_panel5++;
                    Display7table(5);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                if (a != 5)
                {

                    if (Solitaire_Game.PanelToPanel(a, 5))
                    {
                        reduce_num(a);
                        num_shown_panel5++;
                    }
                    else
                    {
                        MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(5);
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel5_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel5_selected = true;
            }
        }

        private void tableLayoutPanel6_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.Move_Card(6) == true)
                {
                    num_shown_panel6++;
                    Display7table(6);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                if (a != 6)
                {

                    if (Solitaire_Game.PanelToPanel(a, 6))
                    {
                        reduce_num(a);
                        num_shown_panel6++;
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(6);
                }
                else
                {
                    MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel6_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel6_selected = true;
            }
        }

        private void tableLayoutPanel7_MouseClick(object sender, MouseEventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.Move_Card(7) == true)
                {
                    num_shown_panel7++;
                    Display7table(7);
                    Displaydiscard();
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                Is_discard_selected = false;
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                if (a != 7)
                {

                    if (Solitaire_Game.PanelToPanel(a, 7))
                    {
                        reduce_num(a);
                        num_shown_panel7++;
                    }
                    else

                    {
                        MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    }
                    reset_is_select();
                    Display7table(a);
                    Display7table(7);
                }
                else
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                    reset_is_select();
                    Is_panel7_selected = true;
                }
            }
            else
            {
                reset_is_select();
                Is_panel7_selected = true;
            }
           
        }
        public int Is_panel_selected()
        {
            int a;
            if (Is_panel1_selected)
            {
                a = 1;
            }
            else if (Is_panel2_selected)
            {
                a = 2;
            }
            else if (Is_panel3_selected)
            {
                a = 3;
            }
            else if (Is_panel4_selected)
            {
                a = 4;
            }
            else if (Is_panel5_selected)
            {
                a = 5;
            }
            else if (Is_panel6_selected)
            {
                a = 6;
            }
            else if (Is_panel7_selected)
            {
                a = 7;
            }
            else
            {
                a = 0;
            }
            reset_is_select();
            return a;
        }

        public void reduce_num(int a)
        {
            if (a == 1)
            {
                if (num_shown_panel1 > 1)
                { num_shown_panel1--; }
            }
            else if (a == 2)
            {
                if (num_shown_panel2 > 1)
                { num_shown_panel2--; }
            }
            else if (a == 3)
            {
                if (num_shown_panel3 > 1)
                { num_shown_panel3--; }
            }
            else if (a == 4)
            {
                if (num_shown_panel4 > 1)
                { num_shown_panel4--; }
            }
            else if (a == 5)
            {
                if (num_shown_panel5 > 1)
                { num_shown_panel5--; }
            }
            else if (a == 6)
            {
                if (num_shown_panel6 > 1)
                { num_shown_panel6--; }
            }
            else if (a == 7)
            {
                if (num_shown_panel7 > 1)
                { num_shown_panel7--; }
            }
            else
            { }

        }
        private void Suit_Pile1_pictureBox_Click(object sender, EventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.DisToSuit(1) == false)
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(1);
                    Displaydiscard();
                }
            } else if (( a=Is_panel_selected())>0)
            {
                
                if (Solitaire_Game.PanelToSuit(a, 1) == false)
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(1);
                    reduce_num(1);
                    Display7table(a);

                }
            }
            reset_is_select();
        }
      
        private void Suit_Pile2_pictureBox_Click(object sender, EventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.DisToSuit(2) == false)
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(2);
                    Displaydiscard();
                }
            }
            else if ((a = Is_panel_selected()) > 0)
            {
               
                if (Solitaire_Game.PanelToSuit(a, 2) == false)
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(2);
                    reduce_num(2);
                    Display7table(a);

                }
            }
            reset_is_select();
        }

        private void Suit_Pile3_pictureBox_Click(object sender, EventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.DisToSuit(3) == false)
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(3);
                    reduce_num(3);
                    Displaydiscard();
                }
            }
            else if ((a = Is_panel_selected()) > 0)
            {
               
                if (Solitaire_Game.PanelToSuit(a, 3) == false)
                {
                    MessageBox.Show("ERROP - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(3);
                    reduce_num(4);
                    Display7table(a);

                }
            }
            reset_is_select();
        }

        private void Suit_Pile4_pictureBox_Click(object sender, EventArgs e)
        {
            int a;
            if (Is_discard_selected == true)
            {
                if (Solitaire_Game.DisToSuit(4) == false)
                {
                    MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(4);
                    Displaydiscard();
                }
            }
            else if ((a = Is_panel_selected()) > 0)
            {
                
                if (Solitaire_Game.PanelToSuit(a, 4) == false)
                {
                    MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                }
                else
                {
                    Displaysuit(4);
                    Display7table(a);
                }
            }
            reset_is_select();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
