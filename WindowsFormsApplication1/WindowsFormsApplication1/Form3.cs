﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_getname_Click(object sender, EventArgs e)
        {
            txt_fullname.Text = txt_fname.Text + " " + txt_lname.Text;
        }
    }
}
