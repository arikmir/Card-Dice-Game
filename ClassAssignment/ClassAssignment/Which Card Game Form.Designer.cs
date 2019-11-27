namespace ClassAssignment
{
    partial class WhichCardGameForm
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
            this.Select_Dice_Game_To_play_label1 = new System.Windows.Forms.Label();
            this.Select_Card_Game_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Exit_Card_Games_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Select_Dice_Game_To_play_label1
            // 
            this.Select_Dice_Game_To_play_label1.AutoSize = true;
            this.Select_Dice_Game_To_play_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Dice_Game_To_play_label1.Location = new System.Drawing.Point(115, 37);
            this.Select_Dice_Game_To_play_label1.Name = "Select_Dice_Game_To_play_label1";
            this.Select_Dice_Game_To_play_label1.Size = new System.Drawing.Size(189, 20);
            this.Select_Dice_Game_To_play_label1.TabIndex = 0;
            this.Select_Dice_Game_To_play_label1.Text = "Select A Game to Play";
            // 
            // Select_Card_Game_comboBox1
            // 
            this.Select_Card_Game_comboBox1.FormattingEnabled = true;
            this.Select_Card_Game_comboBox1.Items.AddRange(new object[] {
            "Solitaire",
            "Twenty -One"});
            this.Select_Card_Game_comboBox1.Location = new System.Drawing.Point(147, 105);
            this.Select_Card_Game_comboBox1.Name = "Select_Card_Game_comboBox1";
            this.Select_Card_Game_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.Select_Card_Game_comboBox1.TabIndex = 1;
            this.Select_Card_Game_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Select_Card_Game_comboBox1_SelectedIndexChanged);
            // 
            // Exit_Card_Games_button1
            // 
            this.Exit_Card_Games_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Card_Games_button1.Location = new System.Drawing.Point(147, 232);
            this.Exit_Card_Games_button1.Name = "Exit_Card_Games_button1";
            this.Exit_Card_Games_button1.Size = new System.Drawing.Size(116, 31);
            this.Exit_Card_Games_button1.TabIndex = 2;
            this.Exit_Card_Games_button1.Text = "EXIT";
            this.Exit_Card_Games_button1.UseVisualStyleBackColor = true;
            this.Exit_Card_Games_button1.Click += new System.EventHandler(this.Exit_Card_Games_button1_Click);
            // 
            // Which_Card_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 378);
            this.Controls.Add(this.Exit_Card_Games_button1);
            this.Controls.Add(this.Select_Card_Game_comboBox1);
            this.Controls.Add(this.Select_Dice_Game_To_play_label1);
            this.Name = "WhichCardGameForm";
            this.Text = "Card Games";
            this.Load += new System.EventHandler(this.Which_Card_Game_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Select_Dice_Game_To_play_label1;
        private System.Windows.Forms.ComboBox Select_Card_Game_comboBox1;
        private System.Windows.Forms.Button Exit_Card_Games_button1;
    }
}