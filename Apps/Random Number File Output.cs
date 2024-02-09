using System;
using System.IO;
using System.Windows.Forms;

namespace CS161_Lab5.Apps
{
    public partial class Random_Number_File_Output : Form
    {
        public Random_Number_File_Output()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amountToGen = int.Parse(inputTextBox.Text);
                Random rand = new Random();

                if(outFileDialog.ShowDialog() == DialogResult.OK) {
                    StreamWriter outputFile = File.CreateText(outFileDialog.FileName);


                    for(int i = 0; i < amountToGen; i++)
                    {
                        outputFile.WriteLine(rand.Next(1, 100));
                    }

                    outputFile.Close();

                    MessageBox.Show("Numbers have been generated.");
                }
            }catch(Exception ex)
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
