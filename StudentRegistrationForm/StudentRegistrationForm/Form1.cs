using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con;
        SqlCommand cmd;
        int rdotmp;
        string gen;
        string strhb;
        string img_path;

        public Form1()
        {
            InitializeComponent();
        }

        private void check_rdo()
        {
            rdotmp = 0;
            if (rdo_male.Checked)
            {
                rdotmp = 1;
            }
        }

        private void check_hb()
        {
            
            strhb = "";
            ArrayList al = new ArrayList();
            foreach (var checkedItem in this.chkb1_hb.CheckedItems)
            {
                strhb += checkedItem.ToString();
                al.Add(checkedItem.ToString());
            }
            strhb = string.Join(",",al.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\StudentRegistrationForm\StudentRegistrationForm\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //save
            check_rdo();
            if (rdotmp == 0)
            {
                gen = "F";
            }
            else
            {
                gen = "M";
            }

            check_hb();
            cmd = new SqlCommand("insert into student values('"+txt_name.Text+"','"+txt_sname.Text+"','"+gen+"','"+cmb_cast.SelectedItem+"','"+img_path+"','"+strhb+"')",con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter("select s_id from student where s_fname='"+txt_name.Text+"' and s_sname='"+txt_sname.Text+"' ",con);
            dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Saved Successfully!");
            txt_id.Text = "";
            txt_name.Text = "";
            txt_sname.Text = "";
            rdo_female.Checked = false;
            rdo_male.Checked = false;
            for (int i = 0; i < chkb1_hb.Items.Count; i++)
            {
                chkb1_hb.SetItemChecked(i,false);
            }

            img_path = "";
            pictureBox1.Image = null;
        }

        private void btn_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            img_path = ofd.FileName;
            pictureBox1.Load(img_path);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //search
            da = new SqlDataAdapter("select * from student where s_id="+txt_id.Text+"",con);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txt_name.Text = dt.Rows[0][1].ToString();
                txt_sname.Text=dt.Rows[0][2].ToString();
                string genres = dt.Rows[0][3].ToString();
                if(genres=="M")
                {
                    rdo_male.Checked = true;
                }
                else
                {
                    rdo_female.Checked = true;
                }
                cmb_cast.Text = dt.Rows[0]["s_cast"].ToString();

                string[] gethb = dt.Rows[0]["s_hobby"].ToString().Split(',');
                for (int i = 0; i < chkb1_hb.Items.Count; i++)
                {
                    if (gethb.Contains(chkb1_hb.Items[i].ToString()))
                    {
                        chkb1_hb.SetItemChecked(i, true);
                    }
                }
             
                string path = dt.Rows[0][5].ToString();
                img_path = path;
                pictureBox1.Load(path);
            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
        }


        private void cmb_cast_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

       
        private void btn_update_Click(object sender, EventArgs e)
        {
            check_hb();
            if (rdotmp == 0)
            {
                gen = "F";
            }
            else
            {
                gen = "M";
            }
            check_hb();
            cmd = new SqlCommand("update student set s_fname='"+txt_name.Text+"' ,s_sname='"+txt_sname.Text+"',s_gender='"+gen+"' ,s_cast='"+cmb_cast.SelectedItem+"',s_photo='"+img_path+"',s_hobby='"+strhb+"' where s_id="+txt_id.Text+" ",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkb1_hb.Items.Count; i++)
            {
                chkb1_hb.SetItemChecked(i, false);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from student where s_id="+txt_id.Text+"",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!");
            txt_id.Text = "";
            txt_name.Text = "";
            txt_sname.Text = "";
            rdo_female.Checked = false;
            rdo_male.Checked = false;
            for (int i = 0; i < chkb1_hb.Items.Count;i++)
            {
                chkb1_hb.SetItemChecked(i,false);
            }
            img_path = "";
            pictureBox1.Image = null;

        }

        private void chkb1_hb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
