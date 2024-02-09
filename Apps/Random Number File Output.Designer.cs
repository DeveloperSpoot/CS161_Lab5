namespace CS161_Lab5.Apps
{
    partial class Random_Number_File_Output
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Number of Random Numbers to Generate";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(8, 35);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(249, 21);
            this.inputTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(13, 87);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(162, 87);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Random_Number_File_Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Random_Number_File_Output";
            this.Text = "Random_Number_File_Output";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.SaveFileDialog outFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}