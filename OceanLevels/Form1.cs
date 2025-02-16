namespace OceanLevels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int.TryParse(txtYear.Text, out int year );

        }
    }
}
