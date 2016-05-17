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
    public partial class PanelExpert : Form
    {
        domain.CustomExpert cExpert;
        int rulesNumber = 0;

        public PanelExpert(domain.CustomExpert _cExpert)
        {
            InitializeComponent();
            cExpert = _cExpert;
        }

        private void PanelExpert_Load(object sender, EventArgs e)
        {
            tabControlExpert.SelectTab(tabPageExpertPanel);
            labelExpertName.Text = cExpert.name + " " + cExpert.family;
            tabControlExpert.TabPages.Remove(tabPageBInfo);
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            ///////////////////////////hide another tabs too
        }

        private void buttonAddDeclaration_Click(object sender, EventArgs e)
        {
            cExpert.newDeclaration();
            buttonAddDeclaration.Hide();
            tabControlExpert.TabPages.Add(tabPageBInfo);
            tabControlExpert.SelectTab(tabPageBInfo);
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageBInfo);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
        }

        private void buttonSubmitBInfo_Click(object sender, EventArgs e)
        {
            cExpert.enterBusinessmanInfo(textboxBname.Text, textboxBfamily.Text, textboxSSN.Text);
            tabControlExpert.TabPages.Remove(tabPageBInfo);
            tabControlExpert.TabPages.Add(tabPagePInfo);
            tabControlExpert.SelectTab(tabPagePInfo);
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
        }

        private void buttonFinalizeProducts_Click(object sender, EventArgs e)
        {
            List<domain.Rule> rulesOnDec = cExpert.curDeclaration.gatherRequiredLicenses();
            rulesNumber = rulesOnDec.Count;
            listBoxRequiredLicenses.DataSource = rulesOnDec;
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.TabPages.Add(tabPageNeedLicences);
            tabControlExpert.SelectTab(tabPageNeedLicences);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            cExpert.enterProduct(textboxPName.Text, textboxCompany.Text, textboxCountry.Text, textboxEntranceType.Text, float.Parse(textboxPValue.Text), Int32.Parse(textboxPPrice.Text));
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.TabPages.Add(tabPagePInfo);
            tabControlExpert.SelectTab(tabPagePInfo);
        }

        private void buttonCancel3_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
        }

        private void buttonEnterLicenses_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Add(tabPageEnterLicense);
        }

        private void buttonCancel4_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Remove(tabPageEnterLicense);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
        }

        private void buttonFinalizeLicenses_Click(object sender, EventArgs e)
        {
            bool success = cExpert.validateLicenses();
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Remove(tabPageEnterLicense);
            tabControlExpert.TabPages.Add(tabPageLicenseValidationReport);
            tabControlExpert.SelectTab(tabPageLicenseValidationReport);

            if (success)
                labelResult.Text = "Successfully done!";
            else
                labelResult.Text = "failure accured!";
        }
        
        private void buttonSubmitLicenseID_Click(object sender, EventArgs e)
        {
            int status = cExpert.enterLicense(textBoxLicenseID.Text);
            switch (status)
            {
                case -3: // license not exist
                    MessageBox.Show("This license not exist!");
                    break;
                case -2: // license not belong to bMan
                    MessageBox.Show("This license not belong to bMan!");
                    break;
                case -1: // license not valid
                    MessageBox.Show("This license does not have credit!");
                    break;
                case 1: // license belong to bMan & is valid
                    MessageBox.Show("Successful!");
                    break;
                default:
                    break;
            }
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Add(tabPageNeedLicences);
            tabControlExpert.SelectTab(tabPageNeedLicences);
        }

        private void buttonCancel5_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageLicenseValidationReport);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
        }

        private void buttonPrintReport_Click(object sender, EventArgs e)
        {
            ///print process
            ///
            tabControlExpert.TabPages.Remove(tabPageLicenseValidationReport);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
           
        }
    
    }
}
