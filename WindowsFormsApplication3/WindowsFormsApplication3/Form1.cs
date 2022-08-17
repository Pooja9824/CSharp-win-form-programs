using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
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
            con=new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\WindowsFormsApplication3\WindowsFormsApplication3\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            da=new SqlDataAdapter("select * from tab_country",con);
            dt=new DataTable();
            da.Fill(dt);
            cmb_country.DisplayMember="co_name";
            cmb_country.ValueMember="co_id";
            cmb_country.DataSource=dt;
        }

        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from tab_state where co_id=" + cmb_country.SelectedValue+ "", con);
            dt=new DataTable();
            da.Fill(dt);
            cmb_state.DisplayMember = "s_name";
            cmb_state.ValueMember = "s_id";
            cmb_state.DataSource = dt;
        }

        private void cmb_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from tab_city where s_id=" + cmb_state.SelectedValue+ "", con);
            dt = new DataTable();
            da.Fill(dt);
            cmb_city.DisplayMember = "c_name";
            cmb_city.ValueMember = "c_id";
            cmb_city.DataSource = dt;
        
          }
    }
}
