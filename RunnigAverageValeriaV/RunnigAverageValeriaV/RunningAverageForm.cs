/*
 * Created by: Valeria Veverita
 * Created on:6-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program  calculates the running average and stops the program when the user enters -1
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

namespace RunnigAverageValeriaV
{
    public partial class frmRunningAverage : Form
    {
        //declare global variables
        int numOfMarks = 1;
        int marksTotals = 0;
        int average = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
            lblAverage.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //create local variable & get user's mark
            int userMark = int.Parse(txtAnswer.Text);

            //check if userMark is greater than 0  and less than 100
            if (userMark > 0 && userMark < 100)
            {
                //calculate the total and divide it by the number of mkarks
                marksTotals = marksTotals + userMark;
                average = userMark / numOfMarks;
                //increase the number of marks by one
                numOfMarks++;
                //display the average
                lblAverage.Text = Convert.ToString(average);
                lblAverage.Visible = true;
            }
            //if user enetrs -1, dispaly a message in the Message 
            else if (userMark == -1)
            {
                MessageBox.Show("Running Average ended");
                //disable the button and hide the average label
                btnCheck.Enabled = false;
                lblAverage.Visible = false;
                //clear the text box
                txtAnswer.Text = "";
            }
        }
    }
}
