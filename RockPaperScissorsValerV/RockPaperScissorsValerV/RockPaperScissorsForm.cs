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
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            randomNumberGenerator = new Random();
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
            int userChoice, computerChoice;

            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            if (radRockUser.Checked == true)
            {
                userChoice = ROCK;
            }
            else if (radPaperUser.Checked == true) 
            {
                userChoice = PAPER;
            }
            else if (radScissorsUser.Checked == true) 
            {
                userChoice = SCISSORS;
            }

            if (computerChoice == ROCK) 
            {
                radRockComp.Checked = true;
            }
            else if (computerChoice == PAPER) 
            {
                radPaperComp.Checked = true;
            }
            else if (computerChoice == SCISSORS) 
            {
                radScissorsComp.Checked = true;
            }


            if (computerChoice == ROCK && userChoice == ROCK)
            {
                radRockComp.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                radPaperComp.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                radScissorsComp.Checked = true;
            }
        }

        private void radPaperUser_CheckedChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
        }

        private void radScissorsUser_CheckedChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
        }
    }
}
