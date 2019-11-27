namespace ClassAssignment
{
    partial class Which_Dice_Game_Form
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
            this.Select_Pig_To_Play_groupBox1 = new System.Windows.Forms.GroupBox();
            this.Two_Dice_Pig_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Single_Die_Pig_radioButton1 = new System.Windows.Forms.RadioButton();
            this.Exit_Dice_Game_button1 = new System.Windows.Forms.Button();
            this.Select_Pig_To_Play_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Select_Pig_To_Play_groupBox1
            // 
            this.Select_Pig_To_Play_groupBox1.Controls.Add(this.Two_Dice_Pig_radioButton2);
            this.Select_Pig_To_Play_groupBox1.Controls.Add(this.Single_Die_Pig_radioButton1);
            this.Select_Pig_To_Play_groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Pig_To_Play_groupBox1.Location = new System.Drawing.Point(65, 75);
            this.Select_Pig_To_Play_groupBox1.Name = "Select_Pig_To_Play_groupBox1";
            this.Select_Pig_To_Play_groupBox1.Size = new System.Drawing.Size(242, 140);
            this.Select_Pig_To_Play_groupBox1.TabIndex = 0;
            this.Select_Pig_To_Play_groupBox1.TabStop = false;
            this.Select_Pig_To_Play_groupBox1.Text = "Select A Pig to Play";
            this.Select_Pig_To_Play_groupBox1.Enter += new System.EventHandler(this.Select_Pig_To_Play_groupBox1_Enter);
            // 
            // Two_Dice_Pig_radioButton2
            // 
            this.Two_Dice_Pig_radioButton2.AutoSize = true;
            this.Two_Dice_Pig_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two_Dice_Pig_radioButton2.Location = new System.Drawing.Point(55, 81);
            this.Two_Dice_Pig_radioButton2.Name = "Two_Dice_Pig_radioButton2";
            this.Two_Dice_Pig_radioButton2.Size = new System.Drawing.Size(109, 19);
            this.Two_Dice_Pig_radioButton2.TabIndex = 1;
            this.Two_Dice_Pig_radioButton2.Text = "Two Dice Pig";
            this.Two_Dice_Pig_radioButton2.UseVisualStyleBackColor = true;
            this.Two_Dice_Pig_radioButton2.CheckedChanged += new System.EventHandler(this.Two_Dice_Pig_radioButton2_CheckedChanged);
            // 
            // Single_Die_Pig_radioButton1
            // 
            this.Single_Die_Pig_radioButton1.AutoSize = true;
            this.Single_Die_Pig_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single_Die_Pig_radioButton1.Location = new System.Drawing.Point(55, 41);
            this.Single_Die_Pig_radioButton1.Name = "Single_Die_Pig_radioButton1";
            this.Single_Die_Pig_radioButton1.Size = new System.Drawing.Size(117, 19);
            this.Single_Die_Pig_radioButton1.TabIndex = 0;
            this.Single_Die_Pig_radioButton1.Text = "Single Die Pig";
            this.Single_Die_Pig_radioButton1.UseVisualStyleBackColor = true;
            this.Single_Die_Pig_radioButton1.CheckedChanged += new System.EventHandler(this.Single_Die_Pig_radioButton1_CheckedChanged);
            // 
            // Exit_Dice_Game_button1
            // 
            this.Exit_Dice_Game_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Dice_Game_button1.Location = new System.Drawing.Point(120, 249);
            this.Exit_Dice_Game_button1.Name = "Exit_Dice_Game_button1";
            this.Exit_Dice_Game_button1.Size = new System.Drawing.Size(109, 33);
            this.Exit_Dice_Game_button1.TabIndex = 1;
            this.Exit_Dice_Game_button1.Text = "EXIT";
            this.Exit_Dice_Game_button1.UseVisualStyleBackColor = true;
            this.Exit_Dice_Game_button1.Click += new System.EventHandler(this.Exit_Dice_Game_button1_Click);
            // 
            // Which_Dice_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 318);
            this.Controls.Add(this.Exit_Dice_Game_button1);
            this.Controls.Add(this.Select_Pig_To_Play_groupBox1);
            this.Name = "Which_Dice_Game_Form";
            this.Text = "Dice Games";
            this.Load += new System.EventHandler(this.Which_Dice_Game_Form_Load);
            this.Select_Pig_To_Play_groupBox1.ResumeLayout(false);
            this.Select_Pig_To_Play_groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Select_Pig_To_Play_groupBox1;
        private System.Windows.Forms.RadioButton Two_Dice_Pig_radioButton2;
        private System.Windows.Forms.RadioButton Single_Die_Pig_radioButton1;
        private System.Windows.Forms.Button Exit_Dice_Game_button1;
    }
}