using System;
using System.IO;
using System.Windows.Forms;

namespace CS161_Lab5.Apps
{
    public partial class Random_Number_File_Reader : Form
    {
        public Random_Number_File_Reader()
        {
            InitializeComponent();
        }

        //Method used to triggle the file input dialog, read the file, and calculate the total of the numbers in the file, as it loads them.
        private void loadButton_Click(object sender, System.EventArgs e)
        {

            int total = 0;
            try
            {
                if(inputFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputFile = File.OpenText(inputFileDialog.FileName);

                    while (!inputFile.EndOfStream) // Looping through all the numbers on the file.
                    {
                        string item = (inputFile.ReadLine()).ToString(); // Getting the number on the current line.

                        numbersListBox.Items.Add(item); // Adding said number to our list box.

                        // Parsing and calculating the total.
                        int itemNumber = int.Parse(item); 
                        total = total + itemNumber;
                    }

                    totalLabel.Text = total.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Please select a file containing the numbers.");
                }

            }catch(Exception err)
            {
                MessageBox.Show(err.Message); // Catch any unforseen errors and any invlaid inputs provided.
            }
        }

        //Exit button method.

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
