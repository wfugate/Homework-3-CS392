namespace RomanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(txtInput.Text, out int number);
                switch (number) {
                    case 1:
                        lblValue.Text = "I";
                        break;
                    case 2:
                        lblValue.Text = "II";
                        break;
                    case 3:
                        lblValue.Text = "III";
                        break;
                    case 4:
                        lblValue.Text = "IV";
                        break;
                    case 5:
                        lblValue.Text = "V";
                        break;
                    case 6:
                        lblValue.Text = "VI";
                        break;
                    case 7:
                        lblValue.Text = "VII";
                        break;
                    case 8:
                        lblValue.Text = "VIII";
                        break;
                    case 9:
                        lblValue.Text = "IX";
                        break;
                    case 10:
                        lblValue.Text = "X";
                        break;
                    default:
                        lblValue.Text = "That is not a number 1-10!";
                        break;

                
            }
        }
    }
}
