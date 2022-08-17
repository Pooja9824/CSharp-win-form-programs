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
    public partial class comboboxDemo2 : Form
    { 
       
        public comboboxDemo2()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cmb_one.Items.Add(txt_one.Text);
            txt_one.Text = "";
            txt_one.Focus();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            cmb_one.Items.Remove(cmb_one.Text);
          
        }

        private void cmb_one_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboboxDemo2_Load(object sender, EventArgs e)
        {

        }
    }
}
