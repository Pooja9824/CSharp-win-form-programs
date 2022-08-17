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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='D:\C#  Visual studio projects\Flag\Flag\flag_data.mdf';Integrated Security=True;User Instance=True");
            con.Open();

            da = new SqlDataAdapter("select * from data",con);
            dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "c_name";
            comboBox1.ValueMember = "c_id";
            comboBox1.DataSource = dt;
            pictureBox1.Load(dt.Rows[0][1].ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from data where c_id="+comboBox1.SelectedValue+"",con);
            dt = new DataTable();
            da.Fill(dt);
            pictureBox1.Load(dt.Rows[0][1].ToString());
            comboBox1.DisplayMember = "c_name";
            
        }
    }
}