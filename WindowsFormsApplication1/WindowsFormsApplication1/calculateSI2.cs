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
    public partial class calculateSI2 : Form
    {
        public calculateSI2()
        {
            InitializeComponent();
        }

        private void btn_calsi_Click(object sender, EventArgs e)
        {
            txt_si.Text = ((Int32.Parse(txt_p.Text) * Int32.Parse(txt_r.Text) * Int32.Parse(txt_n.Text)) / 100).ToString();
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
           int val1=(Int32.Parse(txt_p.Text));

            if (val1 < 10000)
            {
                txt_r.Text="5".ToString();
            }
            else if (val1 >= 20000 && val1 < 20000)
            {
                txt_r.Text = "6".ToString();
            }
            else if (val1 >= 20000 && val1 <= 50000)
            {
                txt_r.Text = "7".ToString();
            }
            else if (val1 >= 50000)
            {
                txt_r.Text = "8".ToString();
            }
          
            
        }
    }
}
