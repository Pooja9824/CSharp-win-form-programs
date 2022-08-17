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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        

        private void btn_bill_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
                {
                    lbl_one.Text = 0.ToString();
                }
            if (textBox2.Text == "")
                {
                    lbl_two.Text = 0.ToString();
                }
            if (textBox3.Text == "")
                {
                    lbl_three.Text = 0.ToString();
                }
            

                if (chk_parcel.Checked == true)
                {
                    lbl_four.Text = (Int32.Parse(lbl_one.Text) + Int32.Parse(lbl_two.Text) + Int32.Parse(lbl_three.Text) + 10).ToString();
                }
                else
                {
                    lbl_four.Text = (Int32.Parse(lbl_one.Text) + Int32.Parse(lbl_two.Text) + Int32.Parse(lbl_three.Text) + 10 - 10).ToString();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_one.Text = (Int32.Parse(textBox1.Text) * 150).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
            }
        }

        private void chk_parcel_CheckedChanged(object sender, EventArgs e)
        {   

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lbl_two.Text = (Int32.Parse(textBox2.Text) * 130).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lbl_three.Text = (Int32.Parse(textBox3.Text) * 180).ToString();
        }
    }

      
}
