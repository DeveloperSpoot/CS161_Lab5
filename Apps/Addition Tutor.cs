using System;
using System.Windows.Forms;

namespace CS161_Lab5.Apps
{
    public partial class Addition_Tutor : Form
    {
        public Addition_Tutor()
        {
            InitializeComponent();
        }

        // Declaring vairbales to hold our random numbers for the creation of our math problem.
        private Random random = new Random();
        private int firstNumber;
        private int secondNumber;

        //Declaring our event method for creating a new math problem.
        private void newButton_Click(object sender, EventArgs e)
        {
            firstNumber = random.Next(100, 500);
            secondNumber = random.Next(100, 500);

            questionLabel.Text = $"{firstNumber} + {secondNumber} =";
            answerTextBox.Text = string.Empty;
            answerTextBox.Focus();
        }

        //Declaring a method to handle the checking of the clients answer and comparing it to the actual answer.
        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {

            int answer = int.Parse(answerTextBox.Text);

            if (firstNumber + secondNumber == answer)
            {
                    MessageBox.Show("Correct.");

            }else{
                    MessageBox.Show("Incorrect.");
                    answerTextBox.Text = string.Empty;
                    answerTextBox.Focus();
            }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

           

        }

        //Exit button event method.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
