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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string btn1;
        string btn2;
        string btn3;
        string btn4;

        private void button1_Click(object sender, EventArgs e)
        {
           
             btn1=button1.Text;
             btn2=button2.Text;
             btn3=button3.Text;
             btn4=button4.Text;

             button1.Text = btn4;
             button2.Text = btn1;
             button3.Text = btn2;
             button4.Text = btn3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             btn1=button1.Text;
             btn2=button2.Text;
             btn3=button3.Text;
             btn4=button4.Text;

             button1.Text = btn4;
             button2.Text = btn1;
             button3.Text = btn2;
             button4.Text = btn3;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
             btn1=button1.Text;
             btn2=button2.Text;
             btn3=button3.Text;
             btn4=button4.Text;

             button1.Text = btn4;
             button2.Text = btn1;
             button3.Text = btn2;
             button4.Text = btn3;
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
             btn1=button1.Text;
             btn2=button2.Text;
             btn3=button3.Text;
             btn4=button4.Text;

             button1.Text = btn4;
             button2.Text = btn1;
             button3.Text = btn2;
             button4.Text = btn3;
        
        }
    }
}
