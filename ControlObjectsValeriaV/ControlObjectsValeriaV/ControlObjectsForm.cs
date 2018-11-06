using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlObjectsValeriaV
{
    public partial class frmControlObjects : Form
    {
        int counter = 0;
        public frmControlObjects()
        {
            
            InitializeComponent();
        }

        private void frmControlObjects_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
            counter++;

                if (counter == 1)
                {
                    foreach (Control aControlObject in this.Controls)
                    {
                        aControlObject.BackColor = Color.DarkGoldenrod;
                        aControlObject.ForeColor = Color.Cornsilk;
                    }
                }
                else if (counter == 2)
                {
                    foreach (Control aControlObject in this.Controls)
                    {
                        aControlObject.BackColor = Color.DarkOliveGreen;
                        aControlObject.ForeColor = Color.Honeydew;
                    }
                }
                else if (counter == 3)
                {
                    foreach (Control aControlObject in this.Controls)
                    {
                        aControlObject.BackColor = Color.DarkSlateGray;
                        aControlObject.ForeColor = Color.Azure;
                    }
                }
                else if (counter == 4)
                {
                    foreach (Control aControlObject in this.Controls)
                    {
                        aControlObject.BackColor = Color.Maroon;
                        aControlObject.ForeColor = Color.FloralWhite;
                    }
                }
                else if (counter == 5)
                {
                   foreach (Control aControlObject in this.Controls)
                   {
                      aControlObject.BackColor = Color.DarkSlateBlue;
                      aControlObject.ForeColor = Color.GhostWhite;
                      counter = 0;
                   }
                }

            

        }
    }
}
