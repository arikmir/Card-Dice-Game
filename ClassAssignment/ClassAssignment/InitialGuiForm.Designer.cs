namespace ClassAssignment
{
    partial class InitialGuiForm
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
            this.Title_label1 = new System.Windows.Forms.Label();
            this.Select_game_groupBox1 = new System.Windows.Forms.GroupBox();
            this.Card_game_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Dice_game_radioButton1 = new System.Windows.Forms.RadioButton();
            this.Start_button1 = new System.Windows.Forms.Button();
            this.Exit_button2 = new System.Windows.Forms.Button();
            this.Select_game_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_label1
            // 
            this.Title_label1.AutoSize = true;
            this.Title_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label1.Location = new System.Drawing.Point(83, 27);
            this.Title_label1.Name = "Title_label1";
            this.Title_label1.Size = new System.Drawing.Size(279, 29);
            this.Title_label1.TabIndex = 0;
            this.Title_label1.Text = "INTERACTIVE GAMES";
            // 
            // Select_game_groupBox1
            // 
            this.Select_game_groupBox1.Controls.Add(this.Card_game_radioButton2);
            this.Select_game_groupBox1.Controls.Add(this.Dice_game_radioButton1);
            this.Select_game_groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_game_groupBox1.Location = new System.Drawing.Point(112, 96);
            this.Select_game_groupBox1.Name = "Select_game_groupBox1";
            this.Select_game_groupBox1.Size = new System.Drawing.Size(230, 128);
            this.Select_game_groupBox1.TabIndex = 1;
            this.Select_game_groupBox1.TabStop = false;
            this.Select_game_groupBox1.Text = "Select Game Type";
            this.Select_game_groupBox1.Enter += new System.EventHandler(this.Select_game_groupBox1_Enter);
            // 
            // Card_game_radioButton2
            // 
            this.Card_game_radioButton2.AutoSize = true;
            this.Card_game_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_game_radioButton2.Location = new System.Drawing.Point(45, 82);
            this.Card_game_radioButton2.Name = "Card_game_radioButton2";
            this.Card_game_radioButton2.Size = new System.Drawing.Size(97, 19);
            this.Card_game_radioButton2.TabIndex = 1;
            this.Card_game_radioButton2.Text = "Card Game";
            this.Card_game_radioButton2.UseVisualStyleBackColor = true;
            this.Card_game_radioButton2.CheckedChanged += new System.EventHandler(this.Card_game_radioButton2_CheckedChanged);
            // 
            // Dice_game_radioButton1
            // 
            this.Dice_game_radioButton1.AutoSize = true;
            this.Dice_game_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice_game_radioButton1.Location = new System.Drawing.Point(45, 40);
            this.Dice_game_radioButton1.Name = "Dice_game_radioButton1";
            this.Dice_game_radioButton1.Size = new System.Drawing.Size(96, 19);
            this.Dice_game_radioButton1.TabIndex = 0;
            this.Dice_game_radioButton1.Text = "Dice Game";
            this.Dice_game_radioButton1.UseVisualStyleBackColor = true;
            this.Dice_game_radioButton1.CheckedChanged += new System.EventHandler(this.Dice_game_radioButton1_CheckedChanged);
            // 
            // Start_button1
            // 
            this.Start_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button1.Location = new System.Drawing.Point(157, 254);
            this.Start_button1.Name = "Start_button1";
            this.Start_button1.Size = new System.Drawing.Size(106, 27);
            this.Start_button1.TabIndex = 2;
            this.Start_button1.Text = "START";
            this.Start_button1.UseVisualStyleBackColor = true;
            this.Start_button1.Click += new System.EventHandler(this.Start_button1_Click);
            // 
            // Exit_button2
            // 
            this.Exit_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button2.Location = new System.Drawing.Point(157, 324);
            this.Exit_button2.Name = "Exit_button2";
            this.Exit_button2.Size = new System.Drawing.Size(106, 26);
            this.Exit_button2.TabIndex = 3;
            this.Exit_button2.Text = "EXIT";
            this.Exit_button2.UseVisualStyleBackColor = true;
            this.Exit_button2.Click += new System.EventHandler(this.Exit_button2_Click);
            // 
            // InitialGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 424);
            this.Controls.Add(this.Exit_button2);
            this.Controls.Add(this.Start_button1);
            this.Controls.Add(this.Select_game_groupBox1);
            this.Controls.Add(this.Title_label1);
            this.Name = "InitialGuiForm";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.InitialGuiForm_Load);
            this.Select_game_groupBox1.ResumeLayout(false);
            this.Select_game_groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label1;
        private System.Windows.Forms.GroupBox Select_game_groupBox1;
        private System.Windows.Forms.RadioButton Card_game_radioButton2;
        private System.Windows.Forms.RadioButton Dice_game_radioButton1;
        private System.Windows.Forms.Button Start_button1;
        private System.Windows.Forms.Button Exit_button2;
    }
}

