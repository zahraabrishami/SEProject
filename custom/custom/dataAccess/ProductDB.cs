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
    class ProductDB
    {
        public static ProductDescription getProductDescription(string name, string company, string originCountry, string enteranceApproach, string material)
        {
            ProductDescription pd = null;
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from productDescriptions pd where pd.name= N'" + name + "' and pd.company= N'" + company + "' and pd.originCountry= N'" + originCountry + "' and pd.enteranceApproach= N'" + enteranceApproach + "' and pd.material= N'" + material + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
                return null;
            foreach (DataRow dr in dt.Rows)
            {
                pd = new ProductDescription(dr.Field<string>("productDescriptionID"),name, company, originCountry, enteranceApproach, material);
            }
            return pd;
        }

        public static ProductDescription getProductDescriptionByID(string id)
        {
            ProductDescription p = null;
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from productDescriptions p where p.productDescriptionID= '" + id + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                p = new ProductDescription(id, dr.Field<string>("name"), dr.Field<string>("company"), dr.Field<string>("originCountry"), dr.Field<string>("enteranceApproach"), dr.Field<string>("material"));
            return p;
        }

        public static void addIssuancedProductDescriptionsToDB(License license)
        {
            foreach (LicenseDescription ld in license.descriptions)
            {
                if (getProductDescription(ld.productDescription.name, ld.productDescription.company, ld.productDescription.originCountry, ld.productDescription.enteranceApproach, ld.productDescription.material) == null)
                    addProductDescription(ld.productDescription);                                  
            }
        }       

        public static void addProductDescription(ProductDescription pd)
        {
            SqlConnection con = DB.connect();
            SqlCommand cmd = new SqlCommand("insert into productDescriptions (productDescriptionID, name, company, enteranceApproach, originCountry, material) values ('" + pd.productDescriptionID + "', N'" + pd.name + "', N'" + pd.company + "', N'" + pd.enteranceApproach + "', N'" + pd.originCountry + "', N'" + pd.material + "')", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
