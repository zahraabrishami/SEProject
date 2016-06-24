using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using dataAccess;
using domain;

namespace dataAccess
{
    public class BusinessmanDB
    {
        public static BusinessMan getBusinessmanBySSN(string ssn)
        {
            BusinessMan b = null;
            SqlConnection con = DB.connect();
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

        public static List<License> getLicenseOfBusinessman(string ssn)
        {
            List<License> ls = new List<License>();
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from licenses l where l.BusinessmanSSN= '" + ssn + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                List<LicenseDescription> lds = LicenseDB.getLicenseDescription(dr.Field<string>("licenseID"));
                License l = new License(dr.Field<string>("licenseID"), dr.Field<string>("name"), ssn, dr.Field<DateTime>("issuanceDate"), dr.Field<DateTime>("expireDate"), lds);
                ls.Add(l);
            }
            return ls;
        }

        public static void addBman(BusinessMan businessMan)
        {
            SqlConnection con = DB.connect();
            SqlCommand cmd = new SqlCommand("insert into businessmans (ssn, name, family) values ('" + businessMan.ssn + "', N'" + businessMan.name + "', N'" + businessMan.family + "')", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void addDeclarationToBman(BusinessMan bMan, Declaration curDeclaration)
        {
            string grant = "0";
            SqlConnection con = DB.connect();

            if (curDeclaration.granted)
                grant = "1";
            SqlCommand cmd = new SqlCommand("insert into declaration (d.cExpertID, d.bManSSN, d.granted) values('" + curDeclaration.cExpertStaffNo + "', '" + bMan.ssn + "', " + grant + ")", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
