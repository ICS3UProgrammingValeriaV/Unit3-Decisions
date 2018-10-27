/*
     * Created by: Valeria Veverita
     * Created on: 14-October-2018
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Guessing Game
     * This program generates a random number and the user have to guess the number
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
using System.Media;

namespace GuessingGameValeriaV
{
    public partial class frmGuessing : Form
    {
        //declare the constants and variables
        const int MIN_NUMB = 1;
        const int MAX_NUMB = 10;
        int generatedCorrect, answer;
        Random correctGeneratedNumber = new Random();
        //Create two global Sound Variables
        System.Media.SoundPlayer correct = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wrong = new System.Media.SoundPlayer();

        public frmGuessing()
        {
            InitializeComponent();
            //Hide the the picture and text
            lblAnswer.Hide();
            picCheck.Hide();

            //import the sound files
            correct.SoundLocation = "correct.wav";
            wrong.SoundLocation = "wwrong.wav";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            //convert user's answer into an integer
            answer = int.Parse(txtAnswer.Text);

            //generate a random number
            generatedCorrect = correctGeneratedNumber.Next(MIN_NUMB, MAX_NUMB);

            //if the user's answer is same as the generated number, than display "correct", display the checkmark image and play sound
            if (answer == generatedCorrect)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.Show();
                correct.Play();
                picCheck.Image = Properties.Resources.checkmark1;
                picCheck.Show();
            }

            //if the user's answer is different from the generated number, than display "try again", display the cross image and play sound
            else
            {
                lblAnswer.Text = "Try again";
                lblAnswer.Show();
                wrong.Play();
                //txtAnswer.Text = "";
                //generatedCorrect = correctGeneratedNumber.Next(MIN_NUMB, MAX_NUMB);
                //lblAnswer.Hide(); 
                picCheck.Image = Properties.Resources.red_x1;
                picCheck.Show();
            }

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
