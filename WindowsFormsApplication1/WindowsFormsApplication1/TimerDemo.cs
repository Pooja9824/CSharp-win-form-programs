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
    public partial class TimerDemo : Form
    {
        public TimerDemo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "HIMANSHUDI")
            {
                label1.Text = "IS TOTALLY MENTAL";
            }
            else if (label1.Text == "IS TOTALLY MENTAL")
            {
                label1.Text = "HIMANSHUDI";
            }

            if (label1.BackColor == Color.Yellow)
            {
                label1.BackColor= Color.Red;
            }
            else
            {
                label1.BackColor=Color.Yellow;
            }

        }
    }
}
