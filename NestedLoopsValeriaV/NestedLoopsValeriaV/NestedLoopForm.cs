/*
 * Created by: Valeria Veverita
 * Created on: 05-October-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day 26 - Nested Loops
 * This program converts hexadecimal numbers to unicode characters
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

namespace NestedLoopsValeriaV
{
    public partial class frmNestedLoop : Form
    {
        public frmNestedLoop()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lstLetters.Items.Clear();
            //create local variables & constants
            int counterCap, counterLow;
            string capitalLet, lowerLet;
            const int MAX_CAP = 90;
            const int MIN_CAP = 65;
            const int MAX_LOW = 122;
            const int MIN_LOW = 97;

            //set the counter for capital letters to 65, check if it's smaller or equal to 90
            for (counterCap = MIN_CAP; counterCap<=MAX_CAP; counterCap++)
            {
                //set the counter for capital letters to 97, check if it's smaller or equal to 122
                for (counterLow = MIN_LOW; counterLow <= MAX_LOW; counterLow++)
                {
                    //convert the hexadecimal # to the unicode characters
                    capitalLet = Char.ConvertFromUtf32(counterCap);
                    lowerLet = Char.ConvertFromUtf32(counterLow);
                    //add the characetrs to the list box
                    lstLetters.Items.Add( capitalLet + "-->" +  lowerLet);
                    this.Refresh();
                    //increment the counter for lower letters by 1

                }
                this.Refresh();
                //increment the counter for capital letters by 1
            }
        }
    }
}
