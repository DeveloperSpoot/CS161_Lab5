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

        //Method to generate the random mnumbers an output a file.
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amountToGen = int.Parse(inputTextBox.Text);
                Random rand = new Random();

                if(outFileDialog.ShowDialog() == DialogResult.OK) {
                    StreamWriter outputFile = File.CreateText(outFileDialog.FileName); // Creating and opening a new text file.


                    for(int i = 0; i < amountToGen; i++)
                    {
                        outputFile.WriteLine(rand.Next(1, 100)); // Writing the random numbers to the files.
                    }

                    outputFile.Close();

                    MessageBox.Show("Numbers have been generated."); // Telling the user that the file has been generating.
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // Catch any invalid inputs or other unforeseen machine errors.
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
