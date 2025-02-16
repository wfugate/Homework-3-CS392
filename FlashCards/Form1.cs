using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FlashCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //counterToTen counts the number of submissions
        //counterToThree counts the number of incorrect submissions
        //correct counts the score
        public int counterToTen = 0;
        public int counterToThree = 0;
        public int correct;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the current operator, current problem solution, and increases submission counter
            bool opAvailable = char.TryParse(txtOp.Text, out char Op);
            if (opAvailable) //catch errors where op is not available 
            {

                int solution = findSolution();
                counterToTen++;
                lblScore.Text = counterToTen.ToString() + "/10";
                try
                {
                    //get the input and check if it is correct
                    int input = int.Parse(txtInput.Text);
                    if (input == solution)
                    {
                        //increase the score and reset incorrect counter
                        counterToThree = 0;
                        correct++;
                        lblStatus.Text = ("Correct!");
                        if (counterToTen == 10) // check if user is done
                        {
                            MessageBox.Show("Your score was: " + correct.ToString());
                            counterToTen = 0;
                            makeProblem(Op);
                            lblScore.Text = counterToTen.ToString() + "/10";
                            lblStatus.Text = "Play Another!";

                        }
                        else
                        {
                            makeProblem(Op);
                        }

                    }
                    else //if it's not correct
                    {
                        //increase counterToThree
                        counterToThree++;
                        if (counterToTen == 10) // check if user is done
                        {
                            MessageBox.Show("Your score was: " + correct.ToString());
                            counterToTen = 0;
                            counterToThree = 0;
                            lblScore.Text = counterToTen.ToString() + "/10";
                            makeProblem(Op);
                            lblStatus.Text = "Play Another!";
                        }
                        if (counterToThree == 3) //check for third incorrect in a row
                        {
                            lblStatus.Text = "Let's try something different."; // reset problem
                            makeProblem(Op);
                            counterToThree = 0;
                        }
                        else
                        {
                            lblStatus.Text = "Incorrect, try again.";
                            txtInput.Text = "";
                        }
                    }
                }
                catch //catch exceptions
                {
                    if (counterToTen == 10) // check if user is done
                    {
                        MessageBox.Show("Your score was: " + correct.ToString());
                        counterToTen = 0;
                        counterToThree = 0;
                        lblScore.Text = counterToTen.ToString() + "/10";
                        makeProblem(Op);
                        lblStatus.Text = "Play Another!";
                    }
                    else
                    {
                        lblStatus.Text = "Incorrect, try again.";
                        txtInput.Text = "";
                    }
                }

            }
            else // error catching
            { MessageBox.Show("Please initialize the question first."); }
            


        }

        private int findSolution()
        {
            //gather values
            int solution = 0;
            int.TryParse(txtInt1.Text, out int int1);
            int.TryParse(txtInt2.Text, out int int2);
            char.TryParse(txtOp.Text, out char Op);

            if (Op.Equals('+')) //calculate addition or subtraction based on Op
            {
                solution = int1 + int2;
            }
            else
            {
                solution = int1 - int2;
            }
            return solution;
        }
        private int makeProblem(char Op)
        {
            //define variables
            Random rand = new Random();
            int int1;
            int int2;
            int solution;
            if (Op == '+') //decide solutions and numbers based on operator selection
            {
                int2 = rand.Next(0, 10);
                int1 = rand.Next(0, 10);
                solution = int1 + int2;
            }
            else
            {
                int2 = rand.Next(0, 10);
                int1 = rand.Next(int2 + 1, 10);
                solution = int1 - int2;
            }
            txtInt1.Text = int1.ToString(); //set values on display
            txtInt2.Text = int2.ToString();
            txtOp.Text = Op.ToString();
            txtInput.Text = "";
            return solution;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            char Op;
            if (rbSubtraction.Checked) //if subtraction is checked
            {
                if (rbAddition.Checked) // check if addition is also checked and if so display an error
                {
                    MessageBox.Show("Please select either addition or subtraction");
                }
                else //otherwise set op to subtraction and generate problem
                {
                    counterToTen = 0;
                    lblScore.Text = counterToTen.ToString() + "/10";
                    correct = 0;
                    counterToThree = 0;
                    Op = '-';
                    makeProblem(Op);

                }
            } //if subtraction is not checked
            else if (rbAddition.Checked) //if addition is checked, set op to add and generate problem
            {
                counterToTen = 0;
                lblScore.Text = counterToTen.ToString() + "/10";
                correct = 0;
                counterToThree = 0;
                Op = '+';
                makeProblem(Op);
            }
            else //otherwise, there is no selection
            {
                MessageBox.Show("You must select addition or subtraction.");
            }



        }

        private void txtStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
