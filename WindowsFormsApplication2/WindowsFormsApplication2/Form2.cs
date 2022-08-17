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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save record/data
            cmd=new SqlCommand("insert into Table1 values('"+txt_uname.Text+"','"+txt_pass.Text+"')",con);
            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search
            da=new SqlDataAdapter("select * from Table1 where uid="+txt_id.Text+" ",con);
            dt=new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count>0)
            {
                txt_uname.Text=dt.Rows[0][0].ToString();
                txt_pass.Text=dt.Rows[0]["upass"].ToString();
                    
            }
            else
            {
                MessageBox.Show("No data Found for ID="+txt_id.Text);
                txt_id.Text="";
                txt_uname.Text="";
                txt_pass.Text="";
                
            }
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            cmd=new SqlCommand("update Table1 set uname='"+txt_pass.Text+"' where uid="+txt_id.Text+"",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            cmd=new SqlCommand("delete from Table1 where uid="+txt_id.Text+"",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
        }
    }
}
