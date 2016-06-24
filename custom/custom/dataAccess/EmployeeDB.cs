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
    public class EmployeeDB
    {
        public static Employee getEmployeeByLoginInfo(string _username, string _password)
        {
            Employee emp = null;
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employees e where e.staffNo= '" + _username + "' and e.password=N'" + _password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
                return null;            
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Field<string>("role") == "نماینده سازمان")
                    emp = new OrganizationAgent(dr.Field<string>("name"), dr.Field<string>("family"), _username, _password, dr.Field<string>("organization"));
                else if (dr.Field<string>("role") == "کارشناس گمرک")
                    emp = new CustomExpert(dr.Field<string>("name"), dr.Field<string>("family"), _username, _password);
                else if (dr.Field<string>("role") == "مدیر گمرک")
                    emp = new CustomAdmin(dr.Field<string>("name"), dr.Field<string>("family"), _username, _password);
            }
            return emp;
        }

        public static List<string> getLicensesCanIssue(string organName)
        {
            List<string> licensesName = new List<string>();
            List<string> licensesCanIssue = new List<string>();
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from licensesOfOrgan lo where lo.organName=N'" + organName + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                licensesName.Add(dr.Field<string>("licenseName"));
            return licensesName;
        }

        public static void addEmployeeToDB(Employee newEmp, string role)
        {
            SqlConnection con = DB.connect();
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("insert into employees (staffNo, password, role, name, family, organization) values ('" + newEmp.staffNo + "', N'" + newEmp.password + "', N'" + role + "', N'" + newEmp.name + "', N'" + newEmp.family + "', N'" + newEmp.organization + "')", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
