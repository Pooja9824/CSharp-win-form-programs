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
    public partial class checkboxDemo_2 : Form
    {
        public checkboxDemo_2()
        {
            InitializeComponent();
        }
        string ind = "";
        string eng = "";
        string aus = "";
        

        private void chk_ind_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chk_ind.Checked == true)
            {
                ind = "India";
                lbl_select.Text = ind+"   "+eng+"   "+aus;
            }
            if (chk_ind.Checked == false)
            {
                ind = "";
                lbl_select.Text = ind +"   "+ eng +"   "+ aus;
            }
        }

        private void chk_eng_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_eng.Checked == true)
            {
                eng = "Englend";
                lbl_select.Text = ind+"   " + eng +"   "+ aus;
            }
            if (chk_eng.Checked == false)
            {
                eng = "";
                lbl_select.Text = ind +"   "+ eng +"   "+ aus;
            }
        }

        private void chk_aus_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_aus.Checked == true)
            {
                aus = "Astrelia";
                lbl_select.Text = ind+"   "+eng+"   "+aus;
            }
            if (chk_aus.Checked == false)
            {
                aus = "";
                lbl_select.Text = ind+"   "+ eng +"   "+ aus;
            }
        }

        private void checkboxDemo_2_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
