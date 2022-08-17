using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            da=new SqlDataAdapter("select * from Table1",con);
            dt=new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "uname";
            comboBox1.ValueMember = "uid";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Table1 where uid=" + comboBox1.SelectedValue.ToString() + "", con);
            dt = new DataTable();
            da.Fill(dt);
            label3.Text = dt.Rows[0][1].ToString();
        }
    }
}
