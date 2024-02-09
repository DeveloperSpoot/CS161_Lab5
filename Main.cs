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
    }
}
