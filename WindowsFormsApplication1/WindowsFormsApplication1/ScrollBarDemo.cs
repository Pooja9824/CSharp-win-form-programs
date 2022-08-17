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
    public partial class ScrollBarDemo : Form
    {
        public ScrollBarDemo()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.SmallChange.ToString();
            textBox2.Text = hScrollBar1.LargeChange.ToString();
            textBox3.Text = hScrollBar1.Minimum.ToString();
            textBox4.Text = hScrollBar1.Maximum.ToString();
            textBox5.Text = hScrollBar1.Value.ToString();
        }
    }
}
