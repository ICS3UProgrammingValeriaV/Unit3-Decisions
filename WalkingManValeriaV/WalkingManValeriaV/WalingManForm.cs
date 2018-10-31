/*
 * Created by: Valeria Veverita
 * Created on: 24-October-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program animates an image
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
using System.Threading;

namespace WalkingManValeriaV
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            //create local variables
            int initialValue = 1;
            const int MAX_VALUE = 10;

            //continue this loop until the intial value will reach the MAX_VALUE
            while (initialValue <= MAX_VALUE)
            {
                if (initialValue == 1)
                {
                    picMan.Image = Properties.Resources.walk1;
                }
                else if (initialValue == 2)
                {
                    picMan.Image = Properties.Resources.walk2;
                }
                else if (initialValue == 3)
                {
                    picMan.Image = Properties.Resources.walk3;
                }
                else if (initialValue == 4)
                {
                    picMan.Image = Properties.Resources.walk4;
                }
                else if (initialValue == 5)
                {
                    picMan.Image = Properties.Resources.walk5;
                }
                else if (initialValue == 6)
                {
                    picMan.Image = Properties.Resources.walk6;
                }
                else if (initialValue == 7)
                {
                    picMan.Image = Properties.Resources.walk7;
                }
                else if (initialValue == 8)
                {
                    picMan.Image = Properties.Resources.walk8;
                }
                else if (initialValue == 9)
                {
                    picMan.Image = Properties.Resources.walk9;
                }
                else if (initialValue == 10)
                {
                    picMan.Image = Properties.Resources.walk10;
                }

                //increase the initial values
                initialValue++;
                //refresh the form
                Refresh();
                //pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }
        }
    }
}
