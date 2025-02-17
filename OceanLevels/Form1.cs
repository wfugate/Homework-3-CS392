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
           
            int.TryParse(txtYear.Text, out int year ); //get input year
            for (int i = 1; i < 11; i++) { //print the level risen each year
            lbLevels.Items.Add((i + year).ToString() + " | Ocean level risen: " + (i*1.5).ToString() + " milimeters");
            }

        }
    }
}
