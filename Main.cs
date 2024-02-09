using CS161_Lab5.Apps;
using System.Windows.Forms;

namespace CS161_Lab5
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void additionTutorButton_Click(object sender, System.EventArgs e)
        {
            Addition_Tutor form = new Addition_Tutor();
            form.Show();
        }

        private void randomGuessButton_Click(object sender, System.EventArgs e)
        {
            Random_Number_Guessing form = new Random_Number_Guessing();
            form.Show();
        }
    }
}
