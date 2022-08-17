using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DetaSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='D:\C#  Visual studio projects\DetaSet\DetaSet\Database1.mdf';Integrated Security=True;User Instance=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from stud",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stud");

            SqlDataAdapter da2 = new SqlDataAdapter("select * from emp",con);
            da2.Fill(ds, "emp");

            Console.WriteLine("===STUD===");
            Console.WriteLine();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[i][0].ToString()+" "+ds.Tables[0].Rows[i][1].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("===EMP===");
            Console.WriteLine();

            for(int i=0;i<ds.Tables[1].Rows.Count;i++)
            {
                Console.WriteLine(ds.Tables[1].Rows[i][0].ToString()+" "+ds.Tables[1].Rows[i][1].ToString());
            }
        
        }
    }
}
