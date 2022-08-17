using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CmdParameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cmd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\CmdParameter\CmdParameter\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
  
            SqlCommand cmd=new SqlCommand("insert into user_detail values(@u_name,@u_pass)");
            cmd.Parameters.AddWithValue("@u_name","abc");
            cmd.Parameters.AddWithValue("@u_pass","xyz");
            cmd.ExecuteNonQuery();
        }
    }
}
