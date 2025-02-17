using System.Xml.Schema;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbTicketsSold_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblClassB_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {   //get values any use TryParse incase they are not ints
            bool aExists = int.TryParse(txtClassA.Text, out int aVal);
            int bVal;
            bool bExists = int.TryParse(txtClassB.Text, out bVal);
            int cVal;
            bool cExists = int.TryParse(txtClassC.Text, out cVal);
            int total;
            //calculate revenues
            int aTotal = aVal * 15;
            int bTotal = bVal * 12;
            int cTotal = cVal * 9;
            total = aTotal + bTotal + cTotal;
            //display revenues
            txtClassADisplay.Text = "$" + aTotal.ToString();
            txtClassBDisplay.Text = "$" + bTotal.ToString();
            txtClassCDisplay.Text = "$" + cTotal.ToString();
            txtTotal.Text = total.ToString();






        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassADisplay.Text = "";
            txtClassBDisplay.Text = "";
            txtClassCDisplay.Text = "";
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";
            txtTotal.Text = "";
        }
    }
}
