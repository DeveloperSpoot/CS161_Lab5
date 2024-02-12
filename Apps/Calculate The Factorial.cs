using System;
using System.Windows.Forms;

namespace CS161_Lab5.Apps
{
    public partial class Calculate_The_Factorial : Form
    {
        public Calculate_The_Factorial()
        {
            InitializeComponent();
        }

        //Method to calulcate the factorial of a given number.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int toFactor = int.Parse(inputTextBox.Text);
                int outFactor = 1;

                for(int count = 1; count <= toFactor; count++) // Loop to calculate the actual factorial.
                {
                    outFactor = outFactor * count;
                }

                outputLabel.Text = outFactor.ToString("n1");
            }catch(Exception ex) // Catch any invalid inputs.
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
