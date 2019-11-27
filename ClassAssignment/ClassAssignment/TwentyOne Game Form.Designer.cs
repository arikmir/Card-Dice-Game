namespace ClassAssignment
{
    partial class TwentyOne_Game_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Deal_button = new System.Windows.Forms.Button();
            this.Hit_button = new System.Windows.Forms.Button();
            this.Stand_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Test_button = new System.Windows.Forms.Button();
            this.BUSTED_DEALER_label = new System.Windows.Forms.Label();
            this.BUSTED_PLAYER_label = new System.Windows.Forms.Label();
            this.Dealer_label = new System.Windows.Forms.Label();
            this.Player_label = new System.Windows.Forms.Label();
            this.DEALER_POINTS_label = new System.Windows.Forms.Label();
            this.PLAYER_POINTS_label = new System.Windows.Forms.Label();
            this.dealerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DEALER_Games_won_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PLAYER_Games_won_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Game_won_DEALER = new System.Windows.Forms.Label();
            this.Game_won_PLAYER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deal_button
            // 
            this.Deal_button.Location = new System.Drawing.Point(28, 365);
            this.Deal_button.Name = "Deal_button";
            this.Deal_button.Size = new System.Drawing.Size(75, 23);
            this.Deal_button.TabIndex = 0;
            this.Deal_button.Text = "Deal";
            this.Deal_button.UseVisualStyleBackColor = true;
            this.Deal_button.Click += new System.EventHandler(this.Deal_button_Click);
            // 
            // Hit_button
            // 
            this.Hit_button.Location = new System.Drawing.Point(126, 365);
            this.Hit_button.Name = "Hit_button";
            this.Hit_button.Size = new System.Drawing.Size(75, 23);
            this.Hit_button.TabIndex = 1;
            this.Hit_button.Text = "Hit";
            this.Hit_button.UseVisualStyleBackColor = true;
            this.Hit_button.Click += new System.EventHandler(this.Hit_button_Click);
            // 
            // Stand_button
            // 
            this.Stand_button.Location = new System.Drawing.Point(225, 365);
            this.Stand_button.Name = "Stand_button";
            this.Stand_button.Size = new System.Drawing.Size(75, 23);
            this.Stand_button.TabIndex = 2;
            this.Stand_button.Text = "Stand";
            this.Stand_button.UseVisualStyleBackColor = true;
            this.Stand_button.Click += new System.EventHandler(this.Stand_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(319, 365);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Test_button
            // 
            this.Test_button.Location = new System.Drawing.Point(488, 336);
            this.Test_button.Name = "Test_button";
            this.Test_button.Size = new System.Drawing.Size(75, 23);
            this.Test_button.TabIndex = 4;
            this.Test_button.Text = "Test";
            this.Test_button.UseVisualStyleBackColor = true;
            this.Test_button.Visible = false;
            this.Test_button.Click += new System.EventHandler(this.Test_button_Click);
            // 
            // BUSTED_DEALER_label
            // 
            this.BUSTED_DEALER_label.AutoSize = true;
            this.BUSTED_DEALER_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUSTED_DEALER_label.ForeColor = System.Drawing.Color.Red;
            this.BUSTED_DEALER_label.Location = new System.Drawing.Point(67, 19);
            this.BUSTED_DEALER_label.Name = "BUSTED_DEALER_label";
            this.BUSTED_DEALER_label.Size = new System.Drawing.Size(81, 20);
            this.BUSTED_DEALER_label.TabIndex = 5;
            this.BUSTED_DEALER_label.Text = "BUSTED";
            // 
            // BUSTED_PLAYER_label
            // 
            this.BUSTED_PLAYER_label.AutoSize = true;
            this.BUSTED_PLAYER_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUSTED_PLAYER_label.ForeColor = System.Drawing.Color.Red;
            this.BUSTED_PLAYER_label.Location = new System.Drawing.Point(67, 299);
            this.BUSTED_PLAYER_label.Name = "BUSTED_PLAYER_label";
            this.BUSTED_PLAYER_label.Size = new System.Drawing.Size(81, 20);
            this.BUSTED_PLAYER_label.TabIndex = 6;
            this.BUSTED_PLAYER_label.Text = "BUSTED";
            // 
            // Dealer_label
            // 
            this.Dealer_label.AutoSize = true;
            this.Dealer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dealer_label.Location = new System.Drawing.Point(216, 19);
            this.Dealer_label.Name = "Dealer_label";
            this.Dealer_label.Size = new System.Drawing.Size(62, 20);
            this.Dealer_label.TabIndex = 7;
            this.Dealer_label.Text = "Dealer";
            // 
            // Player_label
            // 
            this.Player_label.AutoSize = true;
            this.Player_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_label.Location = new System.Drawing.Point(216, 299);
            this.Player_label.Name = "Player_label";
            this.Player_label.Size = new System.Drawing.Size(58, 20);
            this.Player_label.TabIndex = 8;
            this.Player_label.Text = "Player";
            // 
            // DEALER_POINTS_label
            // 
            this.DEALER_POINTS_label.AutoSize = true;
            this.DEALER_POINTS_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEALER_POINTS_label.Location = new System.Drawing.Point(321, 19);
            this.DEALER_POINTS_label.Name = "DEALER_POINTS_label";
            this.DEALER_POINTS_label.Size = new System.Drawing.Size(73, 20);
            this.DEALER_POINTS_label.TabIndex = 10;
            this.DEALER_POINTS_label.Text = "POINTS";
            this.DEALER_POINTS_label.Click += new System.EventHandler(this.DEALER_POINTS_label_Click);
            // 
            // PLAYER_POINTS_label
            // 
            this.PLAYER_POINTS_label.AutoSize = true;
            this.PLAYER_POINTS_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYER_POINTS_label.Location = new System.Drawing.Point(321, 299);
            this.PLAYER_POINTS_label.Name = "PLAYER_POINTS_label";
            this.PLAYER_POINTS_label.Size = new System.Drawing.Size(73, 20);
            this.PLAYER_POINTS_label.TabIndex = 11;
            this.PLAYER_POINTS_label.Text = "POINTS";
            this.PLAYER_POINTS_label.Click += new System.EventHandler(this.PLAYER_POINTS_label_Click);
            // 
            // dealerTableLayoutPanel
            // 
            this.dealerTableLayoutPanel.ColumnCount = 8;
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.dealerTableLayoutPanel.Location = new System.Drawing.Point(12, 61);
            this.dealerTableLayoutPanel.Name = "dealerTableLayoutPanel";
            this.dealerTableLayoutPanel.RowCount = 1;
            this.dealerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dealerTableLayoutPanel.Size = new System.Drawing.Size(580, 92);
            this.dealerTableLayoutPanel.TabIndex = 12;
            // 
            // playerTableLayoutPanel
            // 
            this.playerTableLayoutPanel.ColumnCount = 8;
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.playerTableLayoutPanel.Location = new System.Drawing.Point(12, 183);
            this.playerTableLayoutPanel.Name = "playerTableLayoutPanel";
            this.playerTableLayoutPanel.RowCount = 1;
            this.playerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerTableLayoutPanel.Size = new System.Drawing.Size(580, 92);
            this.playerTableLayoutPanel.TabIndex = 13;
            this.playerTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // DEALER_Games_won_label
            // 
            this.DEALER_Games_won_label.AutoSize = true;
            this.DEALER_Games_won_label.Location = new System.Drawing.Point(485, 19);
            this.DEALER_Games_won_label.Name = "DEALER_Games_won_label";
            this.DEALER_Games_won_label.Size = new System.Drawing.Size(63, 13);
            this.DEALER_Games_won_label.TabIndex = 14;
            this.DEALER_Games_won_label.Text = "Games won";
            this.DEALER_Games_won_label.Click += new System.EventHandler(this.DEALER_Games_won_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PLAYER_Games_won_label
            // 
            this.PLAYER_Games_won_label.AutoSize = true;
            this.PLAYER_Games_won_label.Location = new System.Drawing.Point(485, 299);
            this.PLAYER_Games_won_label.Name = "PLAYER_Games_won_label";
            this.PLAYER_Games_won_label.Size = new System.Drawing.Size(63, 13);
            this.PLAYER_Games_won_label.TabIndex = 16;
            this.PLAYER_Games_won_label.Text = "Games won";
            this.PLAYER_Games_won_label.Click += new System.EventHandler(this.PLAYER_Games_won_label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Aces with value 1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Game_won_DEALER
            // 
            this.Game_won_DEALER.AutoSize = true;
            this.Game_won_DEALER.Location = new System.Drawing.Point(555, 19);
            this.Game_won_DEALER.Name = "Game_won_DEALER";
            this.Game_won_DEALER.Size = new System.Drawing.Size(13, 13);
            this.Game_won_DEALER.TabIndex = 20;
            this.Game_won_DEALER.Text = "0";
            this.Game_won_DEALER.Click += new System.EventHandler(this.Game_won_DEALER_Click);
            // 
            // Game_won_PLAYER
            // 
            this.Game_won_PLAYER.AutoSize = true;
            this.Game_won_PLAYER.Location = new System.Drawing.Point(558, 298);
            this.Game_won_PLAYER.Name = "Game_won_PLAYER";
            this.Game_won_PLAYER.Size = new System.Drawing.Size(13, 13);
            this.Game_won_PLAYER.TabIndex = 21;
            this.Game_won_PLAYER.Text = "0";
            this.Game_won_PLAYER.Click += new System.EventHandler(this.Games_won_PLAYER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TwentyOne_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Game_won_PLAYER);
            this.Controls.Add(this.Game_won_DEALER);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PLAYER_Games_won_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DEALER_Games_won_label);
            this.Controls.Add(this.playerTableLayoutPanel);
            this.Controls.Add(this.dealerTableLayoutPanel);
            this.Controls.Add(this.PLAYER_POINTS_label);
            this.Controls.Add(this.DEALER_POINTS_label);
            this.Controls.Add(this.Player_label);
            this.Controls.Add(this.Dealer_label);
            this.Controls.Add(this.BUSTED_PLAYER_label);
            this.Controls.Add(this.BUSTED_DEALER_label);
            this.Controls.Add(this.Test_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Stand_button);
            this.Controls.Add(this.Hit_button);
            this.Controls.Add(this.Deal_button);
            this.Name = "TwentyOne_Game_Form";
            this.Text = "TwentyOne_Game_Form";
            this.Load += new System.EventHandler(this.TwentyOne_Game_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deal_button;
        private System.Windows.Forms.Button Hit_button;
        private System.Windows.Forms.Button Stand_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Test_button;
        private System.Windows.Forms.Label BUSTED_DEALER_label;
        private System.Windows.Forms.Label BUSTED_PLAYER_label;
        private System.Windows.Forms.Label Dealer_label;
        private System.Windows.Forms.Label Player_label;
        private System.Windows.Forms.Label DEALER_POINTS_label;
        private System.Windows.Forms.Label PLAYER_POINTS_label;
        private System.Windows.Forms.TableLayoutPanel dealerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel playerTableLayoutPanel;
        private System.Windows.Forms.Label DEALER_Games_won_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PLAYER_Games_won_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Game_won_DEALER;
        private System.Windows.Forms.Label Game_won_PLAYER;
        private System.Windows.Forms.Label label1;
    }
}