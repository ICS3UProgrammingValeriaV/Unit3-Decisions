/*
 * Created by: valeria Veverita
 * Created on: 01-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day 24 - Unicode
 * This program converts a decimal to a character
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

namespace UnicodeValeriaV
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //clear the list box 
            lstUnicode.Items.Clear();
            //create local variables and constants
            int initialNum;
            const int MAX_NUMBER = 90;
            string actLetter;

            //for initialNum smaller or equal to 90, convert the initialNum to Unicode character
            for (initialNum = 65; initialNum<=MAX_NUMBER; initialNum ++)
            {
                actLetter = Char.ConvertFromUtf32(initialNum);
                lstUnicode.Items.Add(actLetter + " --> " + Convert.ToString(initialNum));
                this.Refresh();
            }
        }
    }
}
