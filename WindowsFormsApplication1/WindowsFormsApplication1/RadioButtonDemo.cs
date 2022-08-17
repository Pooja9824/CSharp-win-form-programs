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
    public partial class RadioButtonDemo : Form
    {
        public RadioButtonDemo()
        {
            InitializeComponent();
        }

        string lbldata = "u have selected: ";

        private void rdo_red_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.Text = lbldata + rdo_red.Text;
        }

        private void RadioButtonDemo_Load(object sender, EventArgs e)
        {

        }

        private void rdo_yellow_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
            label1.Text = lbldata + rdo_yellow.Text;
        }

        private void rdo_blue_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
            label1.Text = lbldata + rdo_blue.Text;

        }

    }
}
