using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RadioButtonDemo2 : Form
    {
        public RadioButtonDemo2()
        {
            InitializeComponent();
        }

        private void rdo_red_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            string lbldata = "u have selected: ";

            if (rdo_red.Checked == true)
            {
                lbl_first.BackColor = Color.Red;
                lbl_first.Text = lbldata + rdo_red.Text;
            }
            else if (rdo_yellow.Checked == true)
            {
                lbl_first.BackColor = Color.Yellow;
                lbl_first.Text = lbldata + rdo_yellow.Text;
            }
            else if (rdo_blue.Checked == true)
            {
                lbl_first.BackColor = Color.Blue;
                lbl_first.Text = lbldata + rdo_blue.Text;
            }
        }
    }
}
