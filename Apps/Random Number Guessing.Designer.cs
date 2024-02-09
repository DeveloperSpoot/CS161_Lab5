namespace CS161_Lab5.Apps
{
    partial class Random_Number_Guessing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guesstextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.enchancementCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guesstextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Your Guess";
            // 
            // guesstextBox
            // 
            this.guesstextBox.Location = new System.Drawing.Point(7, 21);
            this.guesstextBox.Name = "guesstextBox";
            this.guesstextBox.Size = new System.Drawing.Size(185, 21);
            this.guesstextBox.TabIndex = 0;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guessButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guessButton.Location = new System.Drawing.Point(14, 77);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(156, 23);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Check Guess";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(176, 77);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(151, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enchancementCheckBox
            // 
            this.enchancementCheckBox.AutoSize = true;
            this.enchancementCheckBox.Location = new System.Drawing.Point(228, 38);
            this.enchancementCheckBox.Name = "enchancementCheckBox";
            this.enchancementCheckBox.Size = new System.Drawing.Size(98, 17);
            this.enchancementCheckBox.TabIndex = 3;
            this.enchancementCheckBox.Text = "Enchancement";
            this.enchancementCheckBox.UseVisualStyleBackColor = true;
            // 
            // Random_Number_Guessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 112);
            this.Controls.Add(this.enchancementCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Random_Number_Guessing";
            this.Text = "Random_Number_Guessing";
            this.Load += new System.EventHandler(this.Random_Number_Guessing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox guesstextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox enchancementCheckBox;
    }
}