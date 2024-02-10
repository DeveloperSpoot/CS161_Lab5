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

        private void loadButton_Click(object sender, System.EventArgs e)
        {

            int total = 0;
            try
            {
                if(inputFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputFile = File.OpenText(inputFileDialog.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        string item = (inputFile.ReadLine()).ToString();

                        numbersListBox.Items.Add(item);
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
                MessageBox.Show(err.Message);
            }
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
