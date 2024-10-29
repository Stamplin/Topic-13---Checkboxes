using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_13___Checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chkMath.Checked && !chkScience.Checked)
            {
                lblRResult.Text = "Real, approved valid fact based.";

            }
            else if (chkScience.Checked && !chkMath.Checked)
            {
                lblRResult.Text = "That's aight aint bad";
            }
            else if (chkScience.Checked && chkMath.Checked)
            {
                lblRResult.Text = "BRO I SAID PICK ONE!";
            }
            else if (!!chkScience.Checked && !!chkMath.Checked)
            {
                lblRResult.Text = "WOW LOOK IM SO FUNNY I CHICK NONE XOXXO";
            }
        }
    }
}
