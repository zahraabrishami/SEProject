using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using domain;

namespace dataAccess
{
    public class LicenseDB
    {
        public static List<string> getLicensesOfRule(string ruleID)
        {
            List<string> licenseNames = new List<string>();
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ruleLicenses r where r.ruleID='" + ruleID + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                licenseNames.Add(dr.Field<string>("licenseName"));
            return licenseNames;
        }

        public static List<LicenseDescription> getLicenseDescription(string licenseID)
        {
            List<LicenseDescription> lds = new List<LicenseDescription>();
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from licenseDescriptions ld where ld.licenseID='" + licenseID + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ProductDescription pd = ProductDB.getProductDescriptionByID(dr.Field<string>("productDescriptionID"));
                LicenseDescription ld = new LicenseDescription((float)dr.Field<double>("goodsNumber"), dr.Field<int>("upperPrice"), pd);
                lds.Add(ld);
            }
            return lds;
        }

        public static License getLicense(string licenseID)
        {
            License l = null;
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from licenses l where l.licenseID= '" + licenseID + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BusinessMan bMan = BusinessmanDB.getBusinessmanBySSN(dr.Field<string>("BusinessmanSSN"));
                List<LicenseDescription> lds = getLicenseDescription(licenseID);
                l = new License(licenseID, dr.Field<string>("name"), bMan.ssn, dr.Field<DateTime>("issuanceDate"), dr.Field<DateTime>("expireDate"), lds);
            }
            return l;
        }

        public static void addIssuancedLicenseToDB(License license, string bManSSN, string agentStaffNo)
        {
            SqlConnection con = DB.connect();            
            SqlCommand cmd = new SqlCommand("insert into licenses (licenseID, issuanceDate, expireDate, BusinessmanSSN, name, organAgentStaffNo) values ('" + license.licenseID + "', '" + license.issuanceDate.Date + "', '" + license.expireDate + "', '" + bManSSN + "', N'" + license.name + "', '" + agentStaffNo + "')", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();            
            foreach(LicenseDescription ld in license.descriptions){
                cmd = new SqlCommand("insert into licenseDescriptions (licenseID, goodsNumber, upperPrice, productDescriptionID) values ('" + license.licenseID + "', '" + ld.value + "', '" + ld.upperUnitPrice + "', '" + ld.productDescription.productDescriptionID + "')", con);                
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void updateLicense(string licenseID, string pDescriptionID, float value)
        {
            SqlConnection con = DB.connect();
            SqlCommand cmd = new SqlCommand("update licenseDescriptions set goodsNumber=" + value + " where licenseID='" + licenseID + "' and productDescriptionID='" + pDescriptionID + "'", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();            
            con.Close();            
        }

        public static void updateBmanLicenses(List<License> ownedLicensesForDec)
        {
            foreach (License ownLicense in ownedLicensesForDec)            
                foreach (LicenseDescription ld in ownLicense.descriptions)
                    updateLicense(ownLicense.licenseID, ld.productDescription.productDescriptionID, ld.value);
        }

    }
}
