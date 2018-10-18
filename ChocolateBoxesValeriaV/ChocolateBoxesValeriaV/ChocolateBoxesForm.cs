using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesValeriaV
{
    public partial class ChocolateBoxesForm : Form
    {
        public ChocolateBoxesForm()
        {
            InitializeComponent();
            lblPrize.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int boxes;
            if (int.TryParse(txtBoxes.Text, out boxes))
            {
                if (boxes > 20)
                {
                    lblPrize.Text = "Prize";
                    lblPrize.Show();
                }
                else if (boxes < 0)
                {
                    lblPrize.Text = "Enter a positive integer";
                    lblPrize.Show();
                }
                else if (boxes < 10)
                {
                    lblPrize.Text = "Honorable Mention";
                    lblPrize.Show();
                }
                else if (boxes < 20)
                {
                    lblPrize.Text = "Small Prize";
                    lblPrize.Show();
                }
            }
            else
            {
                lblPrize.Text = "Enter an integer";
=======
            int boxes = int.Parse(txtBoxes.Text);

            if (boxes > 20)
            {
                lblPrize.Text = "Prize";
                lblPrize.Show();
            }
            else if (boxes < 0)
            {
                lblPrize.Text = "Enter a positive integer";
                lblPrize.Show();
            }
            else if (boxes < 10) 
            {
                lblPrize.Text = "Honorable Mention";
                lblPrize.Show();
            }
            
            /*else if (boxes < 20)
            {
                lblPrize.Text = "Small Prize";
                lblPrize.Show();
            }*/
            else
            {
                lblPrize.Text = "Small Prize";
>>>>>>> 536aac407f97b9ef403e30a07848d64f0a0a2a7d
                lblPrize.Show();
            }
        }
    }
}
