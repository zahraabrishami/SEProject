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
    public partial class PanelAgent : Form
    {
        domain.OrganizationAgent oAgent;
        public PanelAgent(domain.OrganizationAgent _oAgent)
        {
            oAgent = _oAgent;
            InitializeComponent();
        }

        private void PanelIssuanceLicense_Load(object sender, EventArgs e)
        {
            tabControlAgent.SelectTab(tabPageAgentPanel);
            labelAgentName.Text = oAgent.name + " " + oAgent.family;
            expireDate.Value = DateTime.Today;
            tabControlAgent.TabPages.Remove(tabPageLicenseInfo);
            tabControlAgent.TabPages.Remove(tabPageProductInfo);
            tabControlAgent.TabPages.Remove(tabPageResult);
        }

        private void buttonAddLicense_Click(object sender, EventArgs e)
        {
            buttonAddLicense.Hide();
            logout.Hide();
            tabControlAgent.TabPages.Add(tabPageLicenseInfo);
            tabControlAgent.SelectTab(tabPageLicenseInfo);
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            tabControlAgent.TabPages.Remove(tabPageLicenseInfo);
            tabControlAgent.SelectTab(tabPageAgentPanel);
            buttonAddLicense.Show();
            logout.Show();
        }

        private void buttonSubmitBInfo_Click(object sender, EventArgs e)
        {
            string err = "";
            bool error = false;

            if (textboxLicenseName.Text == "")
            {
                err += "لطفا عنوان مجوز را وارد کنید\r\n";
                error = true;
            }
            if (textboxSSN.Text == "")
            {
                err += "لطفا کدملی تاجر را وارد کنید\r\n";
                error = true;
            }
            if (textboxBname.Text == "")
            {
                err += "لطفا نام تاجر را وارد کنید\r\n";
                error = true;
            }
            if (textboxBfamily.Text == "")
            {
                err += "لطفا نام خانوادگی تاجر را وارد کنید\r\n";
                error = true;
            }
            if (error)
                MessageBox.Show(err);
            else
            {
                oAgent.enterBusinessmanInfo(textboxSSN.Text, textboxBname.Text, textboxBfamily.Text);
                bool canIssue = oAgent.enterLicenseInfo(textboxLicenseName.Text,expireDate.Value);
                if (canIssue)
                {                    
                    tabControlAgent.TabPages.Remove(tabPageLicenseInfo);
                    tabControlAgent.TabPages.Add(tabPageProductInfo);
                    tabControlAgent.SelectTab(tabPageProductInfo);
                    textboxLicenseName.Text = "";
                    textboxSSN.Text = "";
                    expireDate.Value = DateTime.Today;
                }
                else
                    MessageBox.Show("شما اجازه صدور این مجوز را ندارید.");
                
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textboxPName.Text == "" && textboxCompany.Text == "" && textboxCountry.Text == "" && comboBoxEntranceType.Text == "" && textboxMaterial.Text=="" && PPrice.Value==0 && PValue.Value==0)
                MessageBox.Show("لطفا مشخصات کالا را وارد کنید\r\n");
            else
            {
                oAgent.enterLicenseDescription((float)PValue.Value, (int)PPrice.Value, textboxPName.Text, textboxCompany.Text, textboxCountry.Text, comboBoxEntranceType.Text, textboxMaterial.Text);
                tabControlAgent.TabPages.Remove(tabPageProductInfo);
                tabControlAgent.TabPages.Add(tabPageProductInfo);
                tabControlAgent.SelectTab(tabPageProductInfo);
                PValue.Value = 0;
                PPrice.Value = 0;
                textboxPName.Text = "";
                textboxCompany.Text = "";
                textboxCountry.Text = "";
                comboBoxEntranceType.Text = "";
                textboxMaterial.Text = "";
            }
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            tabControlAgent.TabPages.Remove(tabPageProductInfo);
            tabControlAgent.SelectTab(tabPageAgentPanel);
            buttonAddLicense.Show();
            logout.Show();
        }

        private void buttonFinalizeProducts_Click(object sender, EventArgs e)
        {
            string licenseID = oAgent.issuanceLicense();
            tabControlAgent.TabPages.Remove(tabPageProductInfo);
            tabControlAgent.TabPages.Add(tabPageResult);
            tabControlAgent.SelectTab(tabPageResult);
            LicenseID.Text = licenseID;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            tabControlAgent.TabPages.Remove(tabPageResult);
            tabControlAgent.SelectTab(tabPageAgentPanel);
            buttonAddLicense.Show();
            logout.Show();
        }
     
        private void logout_Click_1(object sender, EventArgs e)
        {
            oAgent = null;
            this.Hide();
            PanelLogin login = new PanelLogin();
            login.Show();
        }

    }
}
