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
    public partial class marksheet : Form
    {
        int val1,val2,val3,val4,val5,val6;

        public marksheet()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            if (txt_rno.Text=="")
            {
                txt_rno.Focus();
                cnt = 1;
            }
            else if (txt_name.Text == "")
            {
                txt_name.Focus();
                cnt = 1;
            }
            else if (txt_java.Text == "")
            {
                txt_java.Focus();
                cnt = 1;
            }
            else if (txt_cs.Text == "")
            {
                txt_cs.Focus();
                cnt = 1;
            }
            else if (txt_net.Text == "")
            {
                txt_net.Focus();
                cnt = 1;
            }
            else if (txt_os.Text == "")
            {
                txt_os.Focus();
                cnt = 1;
            }
           

            
            if(cnt==0)
            {
             val1 = Int32.Parse(txt_java.Text);
             val2 = Int32.Parse(txt_cs.Text);
             val3 = Int32.Parse(txt_net.Text);
             val4 = Int32.Parse(txt_os.Text);
            
            

            txt_obt.Text = (val1 + val2 + val3 + val4).ToString();
            txt_per.Text = (((val1 + val2 + val3 + val4) * 100) / 400).ToString();
            int per = (Int32.Parse(txt_per.Text));

            if (per > 90)
            {
                txt_grade.Text = "A".ToString();
            }
            else if (per > 70 && per < 90)
            {
                txt_grade.Text = "B".ToString();
            }
            else if (per > 50 && per < 70)
            {
                txt_grade.Text = "C".ToString();
            }
            else if (per > 40 && per < 50)
            {
                txt_grade.Text = "D".ToString();
            }
            else
            {
                txt_grade.Text = "Fail,try next time".ToString();
            }

        }
            
        }

        private void txt_rno_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_cal_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
