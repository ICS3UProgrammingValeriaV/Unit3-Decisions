/*
 * Created by: Valeria Veverita
 * Created on: 31-Ocotober-2028
 * Created for: ICS3U Programming
 * Daily Assignment – Day 24 - Sum of the Numbers
 * This program this program calculates the sum of all numbers up to the user's number
*/
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
            //hide the answer
            lblAnswer.Hide();
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
                //is the user answer is smaller or equal to 0, ask the user to enter a positive number
                if (userNumber <= 0 )
                {
                    lblAnswer.Text = "Enter a number bigger than 0";
                    lblAnswer.Location = new System.Drawing.Point(70, 317);
                    lblAnswer.Show();
                }
                //if the user answer is bigger than 0, calculate the sum of all numbers up to user's number by using a for loop
                else if (userNumber > 0)
                {
                    //initialize the counter, check the condition and incriment the counter
                    for(counter = 1; counter<=userNumber; counter++ )
                    {
                        //calculate the sum
                        sumAnswer = sumAnswer + counter;
                        //add the counter to the list box
                        lstNumbers.Items.Add(counter);
                        //refresh the form
                        this.Refresh();
                    }
                    //display the answer
                    lblAnswer.Text = "Sum of all numbers up to " + Convert.ToString(userNumber) + " is " + Convert.ToString(sumAnswer);
                    lblAnswer.Location = new System.Drawing.Point(30, 317);
                    lblAnswer.Show();
                }
            }
            //if the user's answer is not a double, ask the user to enetr a number
            else
            {
                lblAnswer.Text = "Enter a number";
                lblAnswer.Location = new System.Drawing.Point(125, 317);
                lblAnswer.Show();
            }
        }
    }
}
