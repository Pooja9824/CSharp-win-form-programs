using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Flag
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='D:\C#  Visual studio projects\Flag\Flag\flag_data.mdf';Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\ADMIN\OneDrive\Pictures\Saved Pictures\FlagsPic";
            ofd.ShowDialog();
            pictureBox1.Load(ofd.FileName);
            path=ofd.FileName.ToString();    
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_country.Text == "" && path == "")
            {
                MessageBox.Show("Enter proper value");
            }
           else
            {
                cmd = new SqlCommand("INSERT INTO data VALUES ('"+txt_country.Text+"','"+path+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Picture uploaded");
            }
        }
    }
}
