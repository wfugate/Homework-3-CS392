namespace FruitSalad
{
    public partial class Form1 : Form
    {
        private double money;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "$0.00";
            money = 0.00;

        }

        private void pbApple_Click(object sender, EventArgs e)
        {
            money += 1.35;
            txtTotal.Text = "$" + money.ToString();
        }

        private void pbBanana_Click(object sender, EventArgs e)
        {
            money += 0.65;
            txtTotal.Text = "$" + money.ToString();
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {
            money += 1.60;
            txtTotal.Text = "$" + money.ToString();
        }

        private void pbPear_Click(object sender, EventArgs e)
        {
            money += 1.20;
            txtTotal.Text = "$" + money.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
