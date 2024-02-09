﻿using System;
using System.Windows.Forms;

namespace CS161_Lab5.Apps
{
    public partial class Random_Number_Guessing : Form
    {
        public Random_Number_Guessing()
        {
            InitializeComponent();
        }

        int toBeGuessed = 0;
        int guessedCount = 0;
        private void Random_Number_Guessing_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            toBeGuessed = rand.Next(1, 100);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            bool enchacement = enchancementCheckBox.Checked;

            try
            {
                int guessed = int.Parse(guesstextBox.Text);

                if (enchacement) { guessedCount++; }

                if(guessed < toBeGuessed) { MessageBox.Show("Your guess is too low, try again."); return; }

                if(guessed > toBeGuessed) { MessageBox.Show("Your guess is too high, try again."); return; }
                
                if(enchacement) { MessageBox.Show($"You guessed correctly in {guessedCount} tries."); return; }

                MessageBox.Show("You guessed correctly.");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}