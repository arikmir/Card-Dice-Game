namespace ClassAssignment
{
    partial class Single_Pig_Game_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Whose_Turn_to_label = new System.Windows.Forms.Label();
            this.Player_1_textbox = new System.Windows.Forms.TextBox();
            this.Player_2_textbox = new System.Windows.Forms.TextBox();
            this.Player_1_label = new System.Windows.Forms.Label();
            this.Player_2_label = new System.Windows.Forms.Label();
            this.Roll_button1 = new System.Windows.Forms.Button();
            this.Hold_button2 = new System.Windows.Forms.Button();
            this.Another_Pig_Game_groupBox1 = new System.Windows.Forms.GroupBox();
            this.No_another_Pig_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Yes_Another_pig_radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Another_Pig_Game_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(138, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Whose_Turn_to_label
            // 
            this.Whose_Turn_to_label.AutoSize = true;
            this.Whose_Turn_to_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Whose_Turn_to_label.Location = new System.Drawing.Point(21, 93);
            this.Whose_Turn_to_label.Name = "Whose_Turn_to_label";
            this.Whose_Turn_to_label.Size = new System.Drawing.Size(102, 13);
            this.Whose_Turn_to_label.TabIndex = 1;
            this.Whose_Turn_to_label.Text = "Player 1 Roll Die";
            this.Whose_Turn_to_label.Click += new System.EventHandler(this.Whose_Turn_to_label_Click);
            // 
            // Player_1_textbox
            // 
            this.Player_1_textbox.Location = new System.Drawing.Point(418, 86);
            this.Player_1_textbox.Name = "Player_1_textbox";
            this.Player_1_textbox.Size = new System.Drawing.Size(100, 20);
            this.Player_1_textbox.TabIndex = 3;
            this.Player_1_textbox.Text = "0";
            this.Player_1_textbox.TextChanged += new System.EventHandler(this.Player_1_textbox_TextChanged);
            // 
            // Player_2_textbox
            // 
            this.Player_2_textbox.Location = new System.Drawing.Point(418, 132);
            this.Player_2_textbox.Name = "Player_2_textbox";
            this.Player_2_textbox.Size = new System.Drawing.Size(100, 20);
            this.Player_2_textbox.TabIndex = 4;
            this.Player_2_textbox.Text = "0";
            this.Player_2_textbox.TextChanged += new System.EventHandler(this.Player_2_textbox_TextChanged);
            // 
            // Player_1_label
            // 
            this.Player_1_label.AutoSize = true;
            this.Player_1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_1_label.Location = new System.Drawing.Point(326, 93);
            this.Player_1_label.Name = "Player_1_label";
            this.Player_1_label.Size = new System.Drawing.Size(86, 13);
            this.Player_1_label.TabIndex = 5;
            this.Player_1_label.Text = "Player 1 Total";
            // 
            // Player_2_label
            // 
            this.Player_2_label.AutoSize = true;
            this.Player_2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_2_label.Location = new System.Drawing.Point(326, 139);
            this.Player_2_label.Name = "Player_2_label";
            this.Player_2_label.Size = new System.Drawing.Size(86, 13);
            this.Player_2_label.TabIndex = 6;
            this.Player_2_label.Text = "Player 2 Total";
            // 
            // Roll_button1
            // 
            this.Roll_button1.BackColor = System.Drawing.Color.Lime;
            this.Roll_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll_button1.Location = new System.Drawing.Point(48, 216);
            this.Roll_button1.Name = "Roll_button1";
            this.Roll_button1.Size = new System.Drawing.Size(75, 23);
            this.Roll_button1.TabIndex = 7;
            this.Roll_button1.Text = "Roll";
            this.Roll_button1.UseVisualStyleBackColor = false;
            this.Roll_button1.Click += new System.EventHandler(this.Roll_button1_Click);
            // 
            // Hold_button2
            // 
            this.Hold_button2.BackColor = System.Drawing.Color.Red;
            this.Hold_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hold_button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Hold_button2.Location = new System.Drawing.Point(138, 216);
            this.Hold_button2.Name = "Hold_button2";
            this.Hold_button2.Size = new System.Drawing.Size(75, 23);
            this.Hold_button2.TabIndex = 8;
            this.Hold_button2.Text = "Hold";
            this.Hold_button2.UseVisualStyleBackColor = false;
            this.Hold_button2.Click += new System.EventHandler(this.Hold_button2_Click);
            // 
            // Another_Pig_Game_groupBox1
            // 
            this.Another_Pig_Game_groupBox1.Controls.Add(this.No_another_Pig_radioButton2);
            this.Another_Pig_Game_groupBox1.Controls.Add(this.Yes_Another_pig_radioButton1);
            this.Another_Pig_Game_groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Another_Pig_Game_groupBox1.Location = new System.Drawing.Point(310, 216);
            this.Another_Pig_Game_groupBox1.Name = "Another_Pig_Game_groupBox1";
            this.Another_Pig_Game_groupBox1.Size = new System.Drawing.Size(208, 133);
            this.Another_Pig_Game_groupBox1.TabIndex = 9;
            this.Another_Pig_Game_groupBox1.TabStop = false;
            this.Another_Pig_Game_groupBox1.Text = "Another Game?";
            // 
            // No_another_Pig_radioButton2
            // 
            this.No_another_Pig_radioButton2.AutoSize = true;
            this.No_another_Pig_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_another_Pig_radioButton2.Location = new System.Drawing.Point(41, 81);
            this.No_another_Pig_radioButton2.Name = "No_another_Pig_radioButton2";
            this.No_another_Pig_radioButton2.Size = new System.Drawing.Size(43, 19);
            this.No_another_Pig_radioButton2.TabIndex = 1;
            this.No_another_Pig_radioButton2.TabStop = true;
            this.No_another_Pig_radioButton2.Text = "No";
            this.No_another_Pig_radioButton2.UseVisualStyleBackColor = true;
            this.No_another_Pig_radioButton2.CheckedChanged += new System.EventHandler(this.No_another_Pig_radioButton2_CheckedChanged);
            // 
            // Yes_Another_pig_radioButton1
            // 
            this.Yes_Another_pig_radioButton1.AutoSize = true;
            this.Yes_Another_pig_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes_Another_pig_radioButton1.Location = new System.Drawing.Point(41, 44);
            this.Yes_Another_pig_radioButton1.Name = "Yes_Another_pig_radioButton1";
            this.Yes_Another_pig_radioButton1.Size = new System.Drawing.Size(48, 19);
            this.Yes_Another_pig_radioButton1.TabIndex = 0;
            this.Yes_Another_pig_radioButton1.TabStop = true;
            this.Yes_Another_pig_radioButton1.Text = "Yes";
            this.Yes_Another_pig_radioButton1.UseVisualStyleBackColor = true;
            this.Yes_Another_pig_radioButton1.CheckedChanged += new System.EventHandler(this.Yes_Another_pig_radioButton1_CheckedChanged);
            // 
            // Single_Pig_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 367);
            this.Controls.Add(this.Another_Pig_Game_groupBox1);
            this.Controls.Add(this.Hold_button2);
            this.Controls.Add(this.Roll_button1);
            this.Controls.Add(this.Player_2_label);
            this.Controls.Add(this.Player_1_label);
            this.Controls.Add(this.Player_2_textbox);
            this.Controls.Add(this.Player_1_textbox);
            this.Controls.Add(this.Whose_Turn_to_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Single_Pig_Game_Form";
            this.Text = "Single Die Pig";
            this.Load += new System.EventHandler(this.Single_Pig_Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Another_Pig_Game_groupBox1.ResumeLayout(false);
            this.Another_Pig_Game_groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Whose_Turn_to_label;
        private System.Windows.Forms.TextBox Player_1_textbox;
        private System.Windows.Forms.TextBox Player_2_textbox;
        private System.Windows.Forms.Label Player_1_label;
        private System.Windows.Forms.Label Player_2_label;
        private System.Windows.Forms.Button Roll_button1;
        private System.Windows.Forms.Button Hold_button2;
        private System.Windows.Forms.GroupBox Another_Pig_Game_groupBox1;
        private System.Windows.Forms.RadioButton No_another_Pig_radioButton2;
        private System.Windows.Forms.RadioButton Yes_Another_pig_radioButton1;
    }
}