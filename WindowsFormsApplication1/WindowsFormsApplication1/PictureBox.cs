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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("D:\\des21.png");
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
