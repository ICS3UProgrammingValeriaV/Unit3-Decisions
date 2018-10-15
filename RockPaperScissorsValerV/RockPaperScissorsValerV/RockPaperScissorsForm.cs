/*
 * Created by: First Last
 * Created on: 15-October-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program is a rock, paper, scissors game.
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

namespace RockPaperScissorsValerV
{
    public partial class frmRockPaperScissors : Form
    {
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            
        }

        private void radRockUser_CheckedChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            if (radRockUser.Checked == true)
            {

            }
        }
    }
}
