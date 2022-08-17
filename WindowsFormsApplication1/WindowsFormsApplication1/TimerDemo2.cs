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
    public partial class TimerDemo2 : Form
    {
        public TimerDemo2()
        {
            InitializeComponent();
        }
        int i=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + timer1.Interval;
            if (i == 1000)
            {
                label1.Text = "HINLI";
            }
            else if (i == 2000)
            {
                label1.Text = "HAWALI";
            }
            else
            {
                i = 0;
            }
        }
    }
}
