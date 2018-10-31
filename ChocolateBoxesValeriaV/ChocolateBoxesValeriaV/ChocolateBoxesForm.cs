/*
 * Created by: Valeria Veverita
 * Created on: 19-October-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program uses nested if else statements
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

namespace ChocolateBoxesValeriaV
{
    public partial class ChocolateBoxesForm : Form
    {
        public ChocolateBoxesForm()
        {
            InitializeComponent();
            //Hide the lbl
            lblPrize.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Create the variable
            int boxes;
            //Convert the value from the textbox to an integer and check if it is an integer
            if (int.TryParse(txtBoxes.Text, out boxes))
            {
                //if it's bigger than 20, give the user a prize
                if (boxes > 20)
                {
                    lblPrize.Text = "Prize";
                    lblPrize.Show();
                }
                else
                {
                     //if it's less than 0, ask the user to enter a positive number
                    if (boxes < 0)
                    {
                        lblPrize.Text = "Enter a positive integer";
                        lblPrize.Show();
                    }
                    //if it's equal to 0, the user gets a small prize
                    else if (boxes == 0)
                    {
                        lblPrize.Text = "Enter an integer bigger than 0";
                        lblPrize.Show();
                    }
                    //if it's less than 10, honorable metion
                    else if (boxes < 10)
                    {
                        lblPrize.Text = "Honorable Mention";
                        lblPrize.Show();
                    }
                    //if it's less than 20, the user gets a small prize
                    else if (boxes < 20)
                    {
                        lblPrize.Text = "Small Prize";
                        lblPrize.Show();
                    }
                  
                }
               
                
            }
            //if the user doesn't enter an integer, ask the user to enter an integer
            else
            {
                lblPrize.Text = "Enter an integer";
                lblPrize.Show();

            }
        }
    }
}
