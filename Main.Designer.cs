namespace CS161_Lab5
{
    partial class Main
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
            this.additionTutorButton = new System.Windows.Forms.Button();
            this.randomGuessButton = new System.Windows.Forms.Button();
            this.calculateFactorButton = new System.Windows.Forms.Button();
            this.randomFileWriteButton = new System.Windows.Forms.Button();
            this.randomFileReaderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // additionTutorButton
            // 
            this.additionTutorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.additionTutorButton.Location = new System.Drawing.Point(29, 28);
            this.additionTutorButton.Name = "additionTutorButton";
            this.additionTutorButton.Size = new System.Drawing.Size(198, 31);
            this.additionTutorButton.TabIndex = 0;
            this.additionTutorButton.Text = "Addition Tutor";
            this.additionTutorButton.UseVisualStyleBackColor = false;
            this.additionTutorButton.Click += new System.EventHandler(this.additionTutorButton_Click);
            // 
            // randomGuessButton
            // 
            this.randomGuessButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.randomGuessButton.Location = new System.Drawing.Point(29, 78);
            this.randomGuessButton.Name = "randomGuessButton";
            this.randomGuessButton.Size = new System.Drawing.Size(198, 31);
            this.randomGuessButton.TabIndex = 1;
            this.randomGuessButton.Text = "Random Number Guessing";
            this.randomGuessButton.UseVisualStyleBackColor = false;
            this.randomGuessButton.Click += new System.EventHandler(this.randomGuessButton_Click);
            // 
            // calculateFactorButton
            // 
            this.calculateFactorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculateFactorButton.Location = new System.Drawing.Point(29, 128);
            this.calculateFactorButton.Name = "calculateFactorButton";
            this.calculateFactorButton.Size = new System.Drawing.Size(198, 31);
            this.calculateFactorButton.TabIndex = 2;
            this.calculateFactorButton.Text = "Calculating the Factor";
            this.calculateFactorButton.UseVisualStyleBackColor = false;
            this.calculateFactorButton.Click += new System.EventHandler(this.calculateFactorButton_Click);
            // 
            // randomFileWriteButton
            // 
            this.randomFileWriteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.randomFileWriteButton.Location = new System.Drawing.Point(29, 178);
            this.randomFileWriteButton.Name = "randomFileWriteButton";
            this.randomFileWriteButton.Size = new System.Drawing.Size(198, 31);
            this.randomFileWriteButton.TabIndex = 3;
            this.randomFileWriteButton.Text = "Random Number File";
            this.randomFileWriteButton.UseVisualStyleBackColor = false;
            this.randomFileWriteButton.Click += new System.EventHandler(this.randomFileWriteButton_Click);
            // 
            // randomFileReaderButton
            // 
            this.randomFileReaderButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.randomFileReaderButton.Location = new System.Drawing.Point(29, 228);
            this.randomFileReaderButton.Name = "randomFileReaderButton";
            this.randomFileReaderButton.Size = new System.Drawing.Size(198, 31);
            this.randomFileReaderButton.TabIndex = 4;
            this.randomFileReaderButton.Text = "Random File Reader";
            this.randomFileReaderButton.UseVisualStyleBackColor = false;
            this.randomFileReaderButton.Click += new System.EventHandler(this.randomFileReaderButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 285);
            this.Controls.Add(this.randomFileReaderButton);
            this.Controls.Add(this.randomFileWriteButton);
            this.Controls.Add(this.calculateFactorButton);
            this.Controls.Add(this.randomGuessButton);
            this.Controls.Add(this.additionTutorButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button additionTutorButton;
        private System.Windows.Forms.Button randomGuessButton;
        private System.Windows.Forms.Button calculateFactorButton;
        private System.Windows.Forms.Button randomFileWriteButton;
        private System.Windows.Forms.Button randomFileReaderButton;
    }
}

