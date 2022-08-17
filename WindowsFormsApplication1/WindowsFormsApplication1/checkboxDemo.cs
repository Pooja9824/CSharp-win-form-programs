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
    public partial class checkboxDemo : Form
    {
        public checkboxDemo()
        {
            InitializeComponent();
        }

        private void chk_carrom_CheckedChanged(object sender, EventArgs e)
        {
            lbl_data.Text = "";
            if (chk_carrom.Checked == true)
            {
                lbl_data.Text = "carrom checked";
            }
            else
            {
                lbl_data.Text = "carrom unchecked";
            }
        }

        private void chk_cricket_CheckedChanged(object sender, EventArgs e)
        {
            lbl_data.Text = "";
            if (chk_cricket.Checked == true)
            {
                lbl_data.Text = "cricket checked";
            }
            else
            {
                lbl_data.Text = "cricket unchecked";
            }
        }

        private void chk_hockey_CheckedChanged(object sender, EventArgs e)
        {
            lbl_data.Text = "";
            if (chk_hockey.Checked == true)
            {
                lbl_data.Text = "hockey checked";
            }
            else
            {
                lbl_data.Text = "hockey unchecked";
            }
        }
    }
}
