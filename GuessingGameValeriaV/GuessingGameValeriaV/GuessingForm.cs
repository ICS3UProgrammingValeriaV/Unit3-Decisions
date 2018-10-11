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
    public partial class GuessingForm : Form
    {
        //Create two global Sound Variables
        System.Media.SoundPlayer correct = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wrong = new System.Media.SoundPlayer();
        public GuessingForm()
        {
            InitializeComponent();
            correct.SoundLocation = "correct.wav";
            wrong.SoundLocation = "wwrong.wav";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            const int CORRECT_ANSWER= 3 ;
            correct.Play();
        }
    }
}
