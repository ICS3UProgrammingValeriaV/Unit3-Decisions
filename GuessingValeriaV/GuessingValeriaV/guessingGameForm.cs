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

namespace GuessingValeriaV
{
    public partial class frmGuess : Form
    {
        System.Media.SoundPlayer correct = new System.Media.SoundPlayer();
        public frmGuess()
        { 

           
            InitializeComponent();
        }

        private void lblGuess_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
