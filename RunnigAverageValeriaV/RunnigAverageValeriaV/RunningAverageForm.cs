using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunnigAverageValeriaV
{
    public partial class frmRunningAverage : Form
    {
        //declare global variables
        int numOfMarks = 1;
        int marksTotals = 0;
        int average = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
            lblAverage.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //create local variable & get user's mark
            int userMark = int.Parse(txtAnswer.Text);

            if (userMark > 0 && userMark < 100)
            {
                marksTotals = marksTotals + userMark;
                average = userMark / numOfMarks;
                numOfMarks++;
                lblAverage.Text = Convert.ToString(average);
                lblAverage.Visible = true;
            }
            else if (userMark == -1)
            {
                MessageBox.Show("Running Average ended");
                btnCheck.Enabled = false;
                lblAverage.Visible = false;
            }
        }
    }
}
