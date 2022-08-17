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
    public partial class Trafic_Light : Form
    {
        public Trafic_Light()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int ival = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
                ival = ival + timer1.Interval;
                if (ival == 1000)
                {
                    lbl_waite.Visible = false;
                    lbl_stop.Visible = true;
                    lbl_status.Text = "Stop";
                }
                else if (ival == 2000)
                {
                    lbl_start.Visible = true;
                    lbl_stop.Visible = false;
                    lbl_status.Text = "Start";
                }
                else if (ival == 3000)
                {
                    lbl_waite.Visible = true;
                    lbl_start.Visible = false;
                    lbl_status.Text = "Waite";
                    ival = 0;
                }
            
        }

        private void lbl_start_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_stop_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_waite_Click(object sender, EventArgs e)
        {
 
        }
    }
}
