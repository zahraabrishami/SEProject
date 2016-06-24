using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using domain;
using dataAccess;

namespace dataAccess
{
    public class RuleDB
    {
        public static List<domain.Rule> getRelatedRules(Product product)
        {
            List<domain.Rule> rules = new List<domain.Rule>();

            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from (select rl.ruleID, rl.licenseName , rp.productDescriptionID from ruleLicenses rl full outer join ruleProductDescriptions rp on rl.ruleID=rp.ruleID) as t , rules r where t.ruleID=r.ruleID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ProductDescription pd = ProductDB.getProductDescriptionByID(dr.Field<string>("productDescriptionID"));
                bool related = true;
                if (pd != null)
                {
                    if (pd.company != "" && pd.company != product.pDescription.company)
                        related = false;
                    if (pd.enteranceApproach != "" && pd.enteranceApproach != product.pDescription.enteranceApproach)
                        related = false;
                    if (pd.material != "" && pd.material != product.pDescription.material)
                        related = false;
                    if (pd.originCountry != "" && pd.originCountry != product.pDescription.originCountry)
                        related = false;
                    if (pd.name != "" && pd.name != product.pDescription.name)
                        related = false;
                }
                if (related)
                {
                    List<string> licenseNames = LicenseDB.getLicensesOfRule(dr.Field<string>("ruleID"));
                    List<ProductDescription> pdl = new List<ProductDescription>();
                    domain.Rule r = new domain.Rule(dr.Field<string>("ruleID"), (float)dr.Field<double>("startValue"), (float)dr.Field<double>("endValue"), dr.Field<DateTime>("startDate"), dr.Field<DateTime>("endDate"), dr.Field<int>("startUnitPrice"), dr.Field<int>("endUnitPrice"), pdl, licenseNames);
                    rules.Add(r);
                }
            }
            return rules;
        }

        public static void addRule(domain.Rule curRule)
        {
            SqlConnection con = DB.connect();
            SqlCommand cmd = new SqlCommand("insert into rules (ruleID, startValue, endValue, startDate, endDate,  startUnitPrice, endUnitPrice) values ('" + curRule.ruleID + "', '" + curRule.startValue + "', '" + curRule.endValue +"', '" + curRule.startDate +"', '" + curRule.endDate +"', '" + curRule.startUnitPrice+"', '" + curRule.endUnitPrice + "')", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            foreach (ProductDescription pd in curRule.pDescriptions)
            {
                if (ProductDB.getProductDescription(pd.name, pd.company, pd.originCountry, pd.enteranceApproach, pd.material) == null)
                    ProductDB.addProductDescription(pd);
                cmd = new SqlCommand("insert into ruleProductDescriptions (ruleID, productDescriptionID) values ('" + curRule.ruleID + "','" + pd.productDescriptionID + "')", con);
                cmd.ExecuteNonQuery();
                             
            }
            foreach (string lName in curRule.licenseNames)
            {
                cmd = new SqlCommand("insert into ruleLicenses (ruleID, licenseName) values ('" + curRule.ruleID + "', N'" + lName + "')", con);
                cmd.ExecuteNonQuery();
            }  
            con.Close();
        }

        public static void deleteRule(string ruleID)
        {
            SqlConnection con = DB.connect();
            SqlCommand cmd = new SqlCommand("delete from ruleLicenses where ruleID='" + ruleID + "'", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from ruleProductDescriptions where ruleID='" + ruleID + "'", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from rules where ruleID='" + ruleID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static domain.Rule getRuleByID(string ruleID)
        {
            SqlConnection con = DB.connect();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            domain.Rule rule = null;
            List<ProductDescription> pDescriptions = new List<ProductDescription>();
            List<string> licenseNames = new List<string>();            
            SqlDataAdapter sda = new SqlDataAdapter("select * from rules where ruleID='" + ruleID + "'", con);
            sda.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                sda = new SqlDataAdapter("select productDescriptionID from ruleProductDescriptions where ruleID='" + ruleID + "'", con);
                sda.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    string pdID = dr2.Field<string>("productDescriptionID");
                    if (!pDescriptions.Any(p => p.productDescriptionID == pdID))
                    {
                        ProductDescription pDescription = ProductDB.getProductDescriptionByID(pdID);
                        pDescriptions.Add(pDescription);
                    }
                }
                sda = new SqlDataAdapter("select licenseName from ruleLicenses where ruleID='" + ruleID + "'", con);
                sda.Fill(dt3);
                foreach (DataRow dr3 in dt3.Rows)
                {
                    string lName = dr3.Field<string>("licenseName");
                    if (!licenseNames.Any(ln => ln == lName))
                        licenseNames.Add(lName);
                }
                rule = new domain.Rule(ruleID, (float)dr1.Field<double>("startValue"), (float)dr1.Field<double>("endValue"), dr1.Field<DateTime>("startDate"), dr1.Field<DateTime>("endDate"), dr1.Field<int>("startUnitPrice"), dr1.Field<int>("endUnitPrice"), pDescriptions, licenseNames);
                return rule;
            }
            return rule;
        }
        
        public static List<domain.Rule> getAllRules()
        {
            List<domain.Rule> rules = new List<domain.Rule>();            
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from rules", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                string ruleID = dr.Field<string>("ruleID");
                domain.Rule rule = getRuleByID(ruleID);
                rules.Add(rule);
            }
            return rules;            
        }        

    }
}
