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
    public partial class maths : Form
    {
        public maths()
        {
            InitializeComponent();
        }

        private void txt_sign_TextChanged(object sender, EventArgs e)
        {
            int val1 = (Int32.Parse(txt_x.Text));
            int val2 = (Int32.Parse(txt_y.Text));

            if (txt_sign.Text=="+")
            {
                txt_ans.Text=(val1 + val2).ToString();
            }
            else if (txt_sign.Text == "-")
            {
                txt_ans.Text = (val1 - val2).ToString();
            }
            else if (txt_sign.Text == "*")
            {
                txt_ans.Text = (val1 * val2).ToString();
            }
            else if (txt_sign.Text == "/")
            {
                txt_ans.Text = (val1 / val2).ToString();
            }
            else
            {
                txt_ans.Text = " ";
            }

           
        }
    }
}
