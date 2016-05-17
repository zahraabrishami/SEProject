using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using domain;

namespace dataAccess
{
    public static class DB
    {
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jedfvhe\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            return con;
        }

        public static BusinessMan getBusinessmanBySSN(string ssn)
        {
            BusinessMan b = null;
            SqlConnection con = connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from businessmans b where b.ssn= '" + ssn + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
                return null;
            foreach (DataRow dr in dt.Rows)
            {
                b = new BusinessMan(dr.Field<string>("name"), dr.Field<string>("family"), ssn);
            }
            return b;
        }

        public static Employee getEmployeeByLoginInfo(string _username, string _password)
        {
            Employee emp = null;
            SqlConnection con = connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employees e where e.username= '" + _username + "' and e.password='" + _password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
                return null;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Field<string>("role") == "OA")
                    emp = new OrganizationAgent(dr.Field<string>("name"), dr.Field<string>("family"), _username, _password);
                else if (dr.Field<string>("role") == "CE")
                    emp = new CustomExpert(dr.Field<string>("name"), dr.Field<string>("family"), _username, _password);
                else if (dr.Field<string>("role") == "CA")
                    emp = new CustomAdmin(dr.Field<string>("name"), dr.Field<string>("family"), _username, _password);
            }
            return emp;
        }

 /*       public static LicenseDescription getLicenseDescription(string licenseID)
        {
            LicenseDescription ld;
            SqlConnection con = connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from licensens l,licenseDescriptions ld where l.licenseID= '" + licenseID + "' and l.licenseDescriptionID=ld.licenseDescriptionID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
                return null;
            foreach (DataRow dr in dt.Rows)
            {
                ld = new LicenseDescription();
            }
            return ld;
        }
*/
        public static ProductDescription getProductDescription(string name, string company, string originCountry, string enteranceApproach)
        {
            ProductDescription pd = null;
            SqlConnection con = connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from productDescriptions pd where pd.name= '" + name + "' and pd.company= '" + company + "' and pd.originCountry= '" + originCountry + "' and pd.enteranceApproach= '" + enteranceApproach + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
                return null;
            foreach (DataRow dr in dt.Rows)
            {
                pd = new ProductDescription(name, company, originCountry, enteranceApproach);
            }
            return pd;
        }

  /*      public static License addLicenseDescription(LicenseDescription ld)
        {
            License l = null;
            SqlConnection con = connect();
            SqlCommand cmd = new SqlCommand("insert into licenseDescriptions values ('" + ld.issuanceDate + "','" + ld.expireDate + "'," + ld.goodsNumber + "," + ld.upperPrice + ",'" + ld.pd.productID + "')");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            l = new License(ld);
            SqlCommand cmd2 = new SqlCommand("insert into licenses values ('" + ld.licenseDescriptionID + "')");
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = con;
            con.Open();
            cmd2.ExecuteNonQuery();
            return l;
        }
   * */
        public static License getLicense(string licenseID)
        {
            License l = null;
            return l;
        }
    }
}
