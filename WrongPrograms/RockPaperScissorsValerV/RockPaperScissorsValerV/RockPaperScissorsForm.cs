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
        //declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;
<<<<<<< HEAD
=======
        int points = 0;
        int pointsComp = 0;
>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2

        public frmRockPaperScissors()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            //create the random number generator
>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2
            randomNumberGenerator = new Random();
        }

        private void radRockUser_CheckedChanged(object sender, EventArgs e)
        {
            //when radRock is pressed, the button will be enabled
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
<<<<<<< HEAD
            int userChoice, computerChoice;

            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
=======
            int playerChoice = -1;
>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2

            //generate a random number (computer choice)
            int computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //get the user selection, if there is no selection display "Error"
            if (radRockUser.Checked == true)
            {
<<<<<<< HEAD
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
=======
                playerChoice = ROCK;
            }
            else if (radPaperUser.Checked == true) 
            {
                playerChoice = PAPER;
            }
            else if (radScissorsUser.Checked == true) 
            {
                playerChoice = SCISSORS;
            }
            else
            {
                //error
                MessageBox.Show("Error: User did not make a selection");
            }

            //set the radio button for the computer's choice
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

            //check the user's choice and compare it to computre's choice
            if (playerChoice == ROCK)
            {
                if (computerChoice == ROCK) 
                {
                    MessageBox.Show("it's a tie");
                }
                else if (computerChoice == PAPER)
                {
                    MessageBox.Show("The computer won");
                    pointsComp = pointsComp + 1;
                    lblComputerPoints.Text = "Points: " + Convert.ToString(pointsComp);
                }
                else if (computerChoice == SCISSORS)
                {
                    MessageBox.Show("You won");
                    points = points + 1;
                    lblUserPoints.Text = "Points: " + Convert.ToString(points);

                }

            }
            else if (playerChoice == PAPER)
            {
                if (computerChoice == PAPER)
                {
                    MessageBox.Show("it's a tie");
                }
                else if (computerChoice == SCISSORS)
                {
                    MessageBox.Show("The computer won");
                    pointsComp = pointsComp + 1;
                    lblComputerPoints.Text = "Points: " + Convert.ToString(pointsComp);
                }
                else if (computerChoice == ROCK)
                {
                    MessageBox.Show("You won");
                    points = points + 1;
                    lblUserPoints.Text = "Points: " + Convert.ToString(points);
                }
>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2

            if (computerChoice == ROCK) 
            {
                radRockComp.Checked = true;
            }
<<<<<<< HEAD
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
=======
            else if (playerChoice == SCISSORS)
            {
                if (computerChoice == SCISSORS)
                {
                    MessageBox.Show("it's a tie");
                }
                else if (computerChoice == ROCK)
                {
                    MessageBox.Show("The computer won");
                    pointsComp = pointsComp + 1;
                    lblComputerPoints.Text = "Points: " + Convert.ToString(pointsComp);
                }
                else if (computerChoice == PAPER)
                {
                    MessageBox.Show("You won");
                    points = points + 1;
                    lblUserPoints.Text = "Points: " + Convert.ToString(points);
                }

>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2
            }
        }

        private void radPaperUser_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            //when radPaper is pressed, the button will be enabled
>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2
            btnPlay.Enabled = true;
        }

        private void radScissorsUser_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            btnPlay.Enabled = true;
=======
            //when radScissors is pressed, the button will be enabled
            btnPlay.Enabled = true;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

>>>>>>> 8d7bf4a2402b456db9fc77dd4fdd5445395326b2
        }
    }
}
