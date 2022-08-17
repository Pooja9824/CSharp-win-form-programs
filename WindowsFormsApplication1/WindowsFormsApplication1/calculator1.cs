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
    public partial class calculator1 : Form
    {
        public calculator1()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (Int32.Parse(txt_x.Text) + Int32.Parse(txt_y.Text)).ToString();
        }
        private void btn_sub_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (Int32.Parse(txt_x.Text) - Int32.Parse(txt_y.Text)).ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (Int32.Parse(txt_x.Text) * Int32.Parse(txt_y.Text)).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (Int32.Parse(txt_x.Text) / Int32.Parse(txt_y.Text)).ToString();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_x.Text = " ";
            txt_y.Text = " ";
            txt_ans.Text = " ";
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            txt_ans.Text = "x is " + " " + txt_y.Text + " " + "y is " + " " + txt_x.Text;
        }

        private void btn_oddeven_Click(object sender, EventArgs e)
        {
            int val1=(Int32.Parse(txt_x.Text));
            int val2=(Int32.Parse(txt_y.Text));

            if ((val1) % 2 == 0 && (val2) % 2 == 0)
            {
                txt_ans.Text = "even= " + txt_x.Text + " even= " + txt_y.Text;
            }
            else if ((val1) % 2 == 0 && (val2) % 2 != 0)
            {
                txt_ans.Text = "even= " + txt_x.Text + " odd= " + txt_y.Text;
            }
            else if ((val1) % 2 != 0 && (val2) % 2 == 0)
            {
                txt_ans.Text = "odd= " + txt_x.Text + " even= " + txt_y.Text;
            }
            else if ((val1) % 2 != 0 && (val2) % 2 != 0)
            {
                txt_ans.Text = "odd= " + txt_x.Text + " odd= " + txt_y.Text;
            }
        }

        private void btn_minmax_Click(object sender, EventArgs e)
        {
            int val1 = (Int32.Parse(txt_x.Text));
            int val2 = (Int32.Parse(txt_y.Text));


            if ((val1) > (val2))
            {
                txt_ans.Text="x is big:- x= "+txt_x.Text+"  y= "+txt_y.Text;
            }
            else if ((val1) < (val2))
            {
                txt_ans.Text = "y is big:- x= " + txt_x.Text + "  y= " + txt_y.Text;
            }
            else if ((val1) == (val2))
            {
                txt_ans.Text = "x and y both are same:- x= " + txt_x.Text + "  y= " + txt_y.Text;
            } 
        }
    }
}
