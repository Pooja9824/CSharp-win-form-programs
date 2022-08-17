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
    public partial class checkBoxDemo_3 : Form
    {
        public checkBoxDemo_3()
        {
            InitializeComponent();
        }

        private void chk_a_CheckedChanged(object sender, EventArgs e)
        {

        }
        int count = 0;
        bool[] chkvar = new bool[10];

        void getstatus()
        {
            chkvar[0] = chk_a.Checked == true;
            chkvar[1] = chk_b.Checked == true;
            chkvar[2] = chk_c.Checked == true;
            chkvar[3] = chk_d.Checked == true;
            chkvar[4] = chk_e.Checked == true;
            chkvar[5] = chk_f.Checked == true;
            chkvar[6] = chk_g.Checked == true;
            chkvar[7] = chk_h.Checked == true;
            chkvar[8] = chk_i.Checked == true;
            chkvar[9] = chk_j.Checked == true;
           
        }

        void keepfalse()
        {
            if (chkvar[0] == false)
            {
                chk_a.Enabled = false;
            }
            if (chkvar[1] == false)
            {
                chk_b.Enabled = false;
            }
            if (chkvar[2] == false)
            {
                chk_c.Enabled = false;
            }
            if (chkvar[3] == false)
            {
                chk_d.Enabled = false;
            }
            if (chkvar[4] == false)
            {
                chk_e.Enabled = false;
            }
            if (chkvar[5] == false)
            {
                chk_f.Enabled = false;
            }
            if (chkvar[6] == false)
            {
                chk_g.Enabled = false;
            }
            if (chkvar[7] == false)
            {
                chk_h.Enabled = false;
            }
            if (chkvar[8] == false)
            {
                chk_i.Enabled = false;
            }
            if (chkvar[9] == false)
            {
                chk_j.Enabled = false;
            }
        }

        void keeptrue()
        {
            chk_a.Enabled = true;
            chk_b.Enabled = true;
            chk_c.Enabled = true;
            chk_d.Enabled = true;
            chk_e.Enabled = true;
            chk_f.Enabled = true;
            chk_g.Enabled = true;
            chk_h.Enabled = true;
            chk_i.Enabled = true;
            chk_j.Enabled = true;
            count = 0;
        }
        private void chk_a_CheckedChanged_1(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_b_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_c_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_d_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_e_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_f_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_g_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_h_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_i_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }

        private void chk_j_CheckedChanged(object sender, EventArgs e)
        {
            getstatus();
            if (count != 5)
            {
                count = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (chkvar[i] == true)
                    {
                        count++;
                    }
                    if (count == 5)
                    {
                        keepfalse();
                    }
                }
            }
            else
            {
                keeptrue();
            }
        }
    }
}
