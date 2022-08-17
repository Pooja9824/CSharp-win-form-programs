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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login code here
            da=new SqlDataAdapter("select * from Table1 where uname='"+txt_uname.Text+"'and upass='"+txt_pass.Text+"' ",con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("uname or password does not exist");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dont have acc?
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
