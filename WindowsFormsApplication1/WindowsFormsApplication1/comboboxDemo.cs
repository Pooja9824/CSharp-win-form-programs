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
    public partial class comboboxDemo : Form
    {
        public comboboxDemo()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            cmb_one.Items.Add(txt_one.Text);
            txt_one.Text = "";
            txt_one.Focus();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            cmb_one.Items.Remove(cmb_one.Text);
        }

        private void comboboxDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
