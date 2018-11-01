using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialForLoop
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //create local variables
            int counter;
            double sumAnswer = 0;
            double userNumber;

            //check if the user answer is a double
            if (Double.TryParse(txtUserChoice.Text, out userNumber))
            {
                //is the user answer is smaller than 0, ask the user to enter a positive number
                if (userNumber <= 0 )
                {
                    lblAnswer.Text = "Enter a number bigger than 0";
                }
                else if (userNumber > 0)
                {
                    for(counter = 1; counter<=userNumber; counter++ )
                    {
                        sumAnswer = sumAnswer + counter;
                        lstNumbers.Items.Add(counter);
                        this.Refresh();
                    }
                    lblAnswer.Text = "Sum of all in" + Convert.ToString(userNumber) + " = " + Convert.ToString(sumAnswer);
                }
            }
            else
            {
                lblAnswer.Text = "Enter a number";
            }
        }
    }
}
