using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (lbFrom.SelectedIndex != -1 & lbTo.SelectedIndex != -1)
            {
                string fromUnit = lbFrom.SelectedItem.ToString();
                string toUnit = lbTo.SelectedItem.ToString();
                Double.TryParse(txtInput.Text, out double number);
                if (!fromUnit.Equals(toUnit))
                {
                    switch (fromUnit)
                    {
                        case "Inches":
                            switch (toUnit)
                            {
                                case "Feet":
                                    txtResult.Text = (number / 12).ToString(); ;
                                    break;
                                case "Yards":
                                    txtResult.Text = (number / 36).ToString(); ;
                                    break;
                            }
                            break;
                        case "Feet":
                            switch (toUnit)
                            {
                                case "Inches":
                                    txtResult.Text = (number * 12).ToString();
                                    break;
                                case "Yards":
                                    txtResult.Text = (number / 3).ToString();
                                    break;
                            }

                            break;
                        case "Yards":
                            switch (toUnit)
                            {
                                case "Inches":
                                    txtResult.Text = (number * 36).ToString();
                                    break;
                                case "Feet":
                                    txtResult.Text = (number * 3).ToString();
                                    break;
                            }
                            break;


                    }


                }
                else
                {
                    txtResult.Text = txtInput.Text;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
