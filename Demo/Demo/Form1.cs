using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Demo
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        string img;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='D:\C#  Visual studio projects\Demo\Demo\Database1.mdf';Integrated Security=True;User Instance=True");
            con.Open();

            da = new SqlDataAdapter("select * from Table1",con);
            dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "t_name";
            comboBox1.ValueMember = "t_id";
            comboBox1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Table1 values('"+textBox2.Text+"','"+textBox3.Text+"')",con);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Table1 set t_name='"+textBox2.Text+"' ,t_pass='"+textBox3.Text+"' where t_id="+textBox1.Text+" ",con);
            cmd.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from Table1 where t_id="+textBox1.Text+" ",con);
            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Table1 where t_id="+textBox1.Text+"",con);
            dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count>0)
            {
                textBox2.Text = dt.Rows[0]["t_name"].ToString();
                textBox3.Text = dt.Rows[0]["t_pass"].ToString();

            }
            else
            {
                MessageBox.Show("svghdfjvh");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Table1 where t_id="+comboBox1.SelectedValue.ToString()+" ",con);
            dt = new DataTable();
            da.Fill(dt);
            label4.Text = dt.Rows[0][1].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            img = ofd.FileName;
            pictureBox1.Load(img);
        }
    }
}
