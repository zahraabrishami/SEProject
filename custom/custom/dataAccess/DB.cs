using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using domain;

namespace dataAccess
{
    public class DB
    {
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jedfvhe\Documents\Visual Studio 2012\Projects\custom\custom\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            return con;
        }

        public static void deleteAllExceptAdmin()
        {
            SqlConnection con = DB.connect();
            SqlCommand cmd = new SqlCommand("delete from declaration", con);            
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();                      
            cmd = new SqlCommand("delete from licenseDescriptions", con);
            cmd.ExecuteNonQuery();            
            cmd = new SqlCommand("delete from licenses", con);
            cmd.ExecuteNonQuery();            
            cmd = new SqlCommand("delete from products", con);
            cmd.ExecuteNonQuery();            
            cmd = new SqlCommand("delete from ruleProductDescriptions", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from ruleLicenses", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from productDescriptions", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from rules", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from businessmans", con);
            cmd.ExecuteNonQuery();  
            cmd = new SqlCommand("delete from employees where role!=N'مدیر گمرک'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
    }
}
