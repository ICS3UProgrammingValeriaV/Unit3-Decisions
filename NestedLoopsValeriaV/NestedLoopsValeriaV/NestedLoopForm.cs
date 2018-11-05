using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLoopsValeriaV
{
    public partial class frmNestedLoop : Form
    {
        public frmNestedLoop()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //create local variables & constants
            int counterCap, counterLow;
            string capitalLet, lowerLet;
            const int MAX_CAP = 90;
            const int MIN_CAP = 65;
            const int MAX_LOW = 122;
            const int MIN_LOW = 97;

            for (counterCap = MIN_CAP; counterCap<=MAX_CAP; counterCap++)
            {
                for (counterLow = MIN_LOW; counterLow <= MAX_LOW; counterLow++)
                {
                    capitalLet = Char.ConvertFromUtf32(counterCap);
                    lowerLet = Char.ConvertFromUtf32(counterLow);
                    lstLetters.Items.Add( capitalLet + "-- >" +  lowerLet);
                }
            }
        }
    }
}
