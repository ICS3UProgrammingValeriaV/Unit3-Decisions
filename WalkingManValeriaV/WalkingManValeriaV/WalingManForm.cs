using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WalkingManValeriaV
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            int initialValue = 1;
            const int MAX_VALUE = 10;

            while (initialValue <= MAX_VALUE)
            {
                if (initialValue == 1)
                {
                    picMan.Image = Properties.Resources.walk1;
                }
                else if (initialValue == 2)
                {
                    picMan.Image = Properties.Resources.walk2;
                }
                else if (initialValue == 3)
                {
                    picMan.Image = Properties.Resources.walk3;
                }
                else if (initialValue == 4)
                {
                    picMan.Image = Properties.Resources.walk4;
                }
                else if (initialValue == 5)
                {
                    picMan.Image = Properties.Resources.walk5;
                }
                else if (initialValue == 6)
                {
                    picMan.Image = Properties.Resources.walk6;
                }
                else if (initialValue == 7)
                {
                    picMan.Image = Properties.Resources.walk7;
                }
                else if (initialValue == 8)
                {
                    picMan.Image = Properties.Resources.walk8;
                }
                else if (initialValue == 9)
                {
                    picMan.Image = Properties.Resources.walk9;
                }
                else if (initialValue == 10)
                {
                    picMan.Image = Properties.Resources.walk10;
                }

                initialValue++;
                Refresh();
                Thread.Sleep(100);
            }
        }
    }
}
