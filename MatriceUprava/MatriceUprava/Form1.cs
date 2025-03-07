using FileCorrection;

namespace MatriceUprava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NactiSouboryBtn_Click(object sender, EventArgs e)
        {
            FileManager.SeFileNames();
        }
    }
}
