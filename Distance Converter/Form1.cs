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
            if (lbFrom.SelectedIndex != -1 & lbTo.SelectedIndex != -1) //assure there is a selection for both To and From units
            {
                string fromUnit = lbFrom.SelectedItem.ToString();
                string toUnit = lbTo.SelectedItem.ToString();
                Double.TryParse(txtInput.Text, out double number);
                if (!fromUnit.Equals(toUnit)) //If they are not the same unit, go into switch case
                {
                    switch (fromUnit) //switch on fromUnit to determine how to calculate result
                    {
                        case "Inches":
                            switch (toUnit) //if it is inches, switch on toUnit to decide between Feet and Yards
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
                            switch (toUnit) // if it is Feet, switch on toUnit to decide between Inches and Yards
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
                            switch (toUnit) //if it is Yards, switch on toUnit to decide between Inches and Feet
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
                else //if they are the same unit, do no calculations
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
