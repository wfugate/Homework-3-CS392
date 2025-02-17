namespace FactorialCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtInput.Text, out int input); //get input
            int result = 1;
            for (int i = 0; i < input; i++) { //calculate factorial
            result = result * (input - i);
            }
            lblResult.Text = ("Result: " + result.ToString()); // display results

        }
    }
}
