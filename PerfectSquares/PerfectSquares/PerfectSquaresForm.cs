/*
 * Created by: Valeria Veverita
 * Created on: 28-October-2018
 * Created for: ICS3U Programming
 * Daily Assignemt - #22 - Perfect Squares
 * This program identifies all perfect squares up to the number assigned by the user
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

namespace PerfectSquares
{
    public partial class frmPerfetSquares : Form
    {
        public frmPerfetSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //create loacl variables and assign them
            int userChoice = -1;
            int value = 1;
            double doubleSquare = -1;
            int integerSquare = -1;

            //get the user choice and convert it to an integer
            userChoice = Convert.ToInt32(nudUserChoice.Value);

            //continue stating any perfect squares between the minimum value and the user's selcted value

            while (value <= userChoice)
            {
                //calculate the square root of the value
                doubleSquare = Math.Sqrt(value);

                //convertg the square root to an integer
                integerSquare = Convert.ToInt32(doubleSquare);

                //if the decimal and integer are the same, then the value is a perfect square
                if (doubleSquare == integerSquare)
                {
                    //add the value to the listbox
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                    //refresh the screen
                    this.Refresh();
                }
                //increment the value by 1
                value++;
            
            }
        }
    }
}
