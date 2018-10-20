/*
 * Created by: Valeria Veverita
 * Created on: 19-October-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program 
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

namespace FactorialDoWhileValeriaV
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //create the variables and constants. Assign them
            int progessValue = 0;
            const int MAX_PROGRESS_VALUE = 100;

            //CREATE THE WHILE LOOP
            do
            {
                //while the progress value is less than 100, increase the value by 5
                prbIncrease.Value = progessValue;
                progessValue = progessValue + 5;
                this.Refresh();
            } while (progessValue <= MAX_PROGRESS_VALUE);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {

        }
    }
}
