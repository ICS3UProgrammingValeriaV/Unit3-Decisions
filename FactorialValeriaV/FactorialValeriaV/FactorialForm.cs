/*
 * Created by:Valeria Veverita
 * Created on: 27-October-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates the factotial of the number entered by the user
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

namespace FactorialValeriaV
{
    public partial class frmFactorial : Form
    {

        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //when the button is pressed, clear the listbox
            this.lstFactors.Items.Clear();
            //create local variables  and assign them
            double userNum = -1;
            double factorialSum = 1;
            int counter = 0;

            //check if the user number is a double
            if (Double.TryParse (txtUserAnswer.Text, out userNum))
            {
                //if user number is 0, display the factorial number equal to 1
                if (userNum == 0)
                {
                    lblAnswer.Text = "!0 = 1";
                    lstFactors.Items.Add(userNum);
                }
                //if the number is less than 0, ask the user to enter a positive number
                else if (userNum < 0)
                {
                    lblAnswer.Text = "Enter a positive number";
                }
                //if the integer is differenet than 0 and is not negative
                else
                {
                    do
                    {
                        //increment the counter by 1
                        counter++;
                        //add first factor to list box
                        lstFactors.Items.Add(counter);
                        //calculate the factorial
                        factorialSum = factorialSum * counter;
                        //refresh the screen
                        this.Refresh();
                        //repeat the loop while the counter is smaller than 5
                    } while (counter < userNum );

                    //display the factorial
                    lblAnswer.Text = "!" + Convert.ToString(userNum) + " = " + Convert.ToString(factorialSum);
                }
            }
            else
            {
                //if the user answer is not a double, ask the user to insert one
                lblAnswer.Text = "Insert an number";
            }


        }
    }
}
