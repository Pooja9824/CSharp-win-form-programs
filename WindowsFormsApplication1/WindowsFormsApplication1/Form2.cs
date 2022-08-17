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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_first_Enter(object sender, EventArgs e)
        {
            txt_first.Text = "Welcome";
            txt_second.Text = "By";
        }

        private void txt_first_Leave(object sender, EventArgs e)
        {
            txt_first.Text = "By";
            txt_second.Text = "Welcome";
        }

    }
}
