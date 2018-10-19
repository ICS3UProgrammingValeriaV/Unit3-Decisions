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
            int progessValue = 0;
            const int MAX_PROGRESS_VALUE = 100;

            do
            {
                prbIncrease.Value = progessValue;
                progessValue = progessValue + 5;
                this.Refresh();
            } while (progessValue <= MAX_PROGRESS_VALUE);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
