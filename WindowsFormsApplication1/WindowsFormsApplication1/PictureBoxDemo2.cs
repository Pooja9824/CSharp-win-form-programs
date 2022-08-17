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
    public partial class PictureBoxDemo2 : Form
    {
        public PictureBoxDemo2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(@"D:\C#  Visual studio projects\WindowsFormsApplication1\WindowsFormsApplication1\des21.png");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(@"D:\C#  Visual studio projects\WindowsFormsApplication1\WindowsFormsApplication1\des17.png");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(@"D:\C#  Visual studio projects\WindowsFormsApplication1\WindowsFormsApplication1\des18.png");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(@"D:\C#  Visual studio projects\WindowsFormsApplication1\WindowsFormsApplication1\des19.png");
        }
    }
}
