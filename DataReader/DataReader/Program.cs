using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\C#  Visual studio projects\CmdParameter\CmdParameter\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from user_detail", con);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["u_name"].ToString() + " " + rdr["u_pass"].ToString());
            }
            Console.ReadLine();
        }
    }
}
