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
    public partial class calculateSI : Form
    {
        public calculateSI()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_calSI_Click(object sender, EventArgs e)
        {
            txt_si.Text=((Int32.Parse(txt_p.Text)*Int32.Parse(txt_r.Text)*Int32.Parse(txt_n.Text))/100).ToString();
        }
    }
}
