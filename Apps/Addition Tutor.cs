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

        private Random random = new Random();
        private int firstNumber;
        private int secondNumber;
        private void newButton_Click(object sender, EventArgs e)
        {
            firstNumber = random.Next(100, 500);
            secondNumber = random.Next(100, 500);

            questionLabel.Text = $"{firstNumber} + {secondNumber} =";
            answerTextBox.Text = string.Empty;
            answerTextBox.Focus();
        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
