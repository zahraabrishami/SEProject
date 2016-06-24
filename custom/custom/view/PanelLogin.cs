using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace view
{
    public partial class PanelLogin : Form
    {
        domain.LoginHandler lhandler = new domain.LoginHandler();
        domain.Employee emp;

        public PanelLogin()
        {
            InitializeComponent();
        }

        public void nullEmployee()
        {
            MessageBox.Show("Invalid username or password!");
        }

        public void showCustomExpertPanel()
        {
            this.Hide();
            domain.CustomExpert cExpert = new domain.CustomExpert(emp.name, emp.family, emp.staffNo, emp.password);
            PanelExpert EP = new PanelExpert(cExpert);
            EP.Show();
        }

        public void showOrganizationAgentPanel()
        {
            this.Hide();
            domain.OrganizationAgent oAgent= new domain.OrganizationAgent(emp.name, emp.family, emp.staffNo, emp.password, emp.organization);
            this.Hide();
            PanelAgent AP = new PanelAgent(oAgent);
            AP.Show();
        }

        public void showCustomAdminPanel()
        {
            this.Hide();
            domain.CustomAdmin cAdmin = new domain.CustomAdmin(emp.name, emp.family, emp.staffNo, emp.password);
            this.Hide();
            PanelAdmin AP = new PanelAdmin(cAdmin);
            AP.Show();
        }


        private void loginBTN_Click(object sender, EventArgs e)
        {
            emp = lhandler.login(username.Text, password.Text);

            if (emp==null)
                nullEmployee();
            else
            {
                switch (emp.GetType().Name)
                {
                    case "CustomExpert":
                        showCustomExpertPanel();
                        break;
                    case "OrganizationAgent":
                        showOrganizationAgentPanel();
                        break;
                    case "CustomAdmin":
                        showCustomAdminPanel();
                        break;
                    default:
                        break;
                }
            }
        }
    
    }
}
