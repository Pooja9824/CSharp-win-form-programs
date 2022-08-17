using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataTableWinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='D:\C#  Visual studio projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf';Integrated Security=True;User Instance=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Table1",con);
            DataTable dt = new DataTable();
       
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0].ToString());
            }
            Console.ReadLine();
        }
    }
}
