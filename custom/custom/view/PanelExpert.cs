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

        public PanelExpert(domain.CustomExpert _cExpert)
        {
            InitializeComponent();
            cExpert = _cExpert;
        }

        private void PanelExpert_Load(object sender, EventArgs e)
        {
            tabControlExpert.SelectTab(tabPageExpertPanel);
            string welcome = cExpert.name + " " + cExpert.family;
            labelExpertName.Text = welcome;
            tabControlExpert.TabPages.Remove(tabPageBInfo);
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Remove(tabPageEnterLicense);
            tabControlExpert.TabPages.Remove(tabPageLicenseValidationReport);
        }

        private void buttonAddDeclaration_Click(object sender, EventArgs e)
        {
            cExpert.newDeclaration();
            buttonAddDeclaration.Hide();
            logout.Hide();
            tabControlExpert.TabPages.Add(tabPageBInfo);
            tabControlExpert.SelectTab(tabPageBInfo);
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageBInfo);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
            logout.Show();
        }

        private void buttonSubmitBInfo_Click(object sender, EventArgs e)
        {
            string err = "";
            bool error = false;
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
            if (textboxSSN.Text == "")
            {
                err += "لطفا شماره ملی تاجر را وارد کنید\r\n";
                error = true;
            }
            if (error)
                MessageBox.Show(err);
            else
            {
                cExpert.enterBusinessmanInfo(textboxBname.Text, textboxBfamily.Text, textboxSSN.Text);
                textboxBname.Text = "";
                textboxBfamily.Text = "";
                textboxSSN.Text = "";
                tabControlExpert.TabPages.Remove(tabPageBInfo);
                tabControlExpert.TabPages.Add(tabPagePInfo);
                tabControlExpert.SelectTab(tabPagePInfo);
            }
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
            logout.Show();
        }

        private void buttonFinalizeProducts_Click(object sender, EventArgs e)
        {
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();
          
            listBoxRequiredLicenses.DataSource = licensesToDesplay;
            tabControlExpert.TabPages.Remove(tabPagePInfo);
            tabControlExpert.TabPages.Add(tabPageNeedLicences);
            tabControlExpert.SelectTab(tabPageNeedLicences);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string err = "";
            bool error = false;
            if (textboxPName.Text == "")
            {
                err += "لطفا نام کالا را وارد کنید\r\n";
                error = true;
            }
            if (PPrice.Value == 0)
            {
                err += "لطفا قیمت را وارد کنید\r\n";
                error = true;
            }
            if (PValue.Value == 0)
            {
                err += "لطفا مقدار را وارد کنید\r\n";
                error = true;
            }
            if (textboxCountry.Text == "")
            {
                err += "لطفا کشور مبدا را وارد کنید\r\n";
                error = true;
            }
            if (comboBoxEntranceType.Text == "")
            {
                err += "لطفا نحوه ورود به کشور را وارد کنید\r\n";
                error = true;
            }
            if (textboxCompany.Text == "")
            {
                err += "لطفا شرکت را وارد کنید\r\n";
                error = true;
            }
            if (textboxMaterial.Text == "")
            {
                err += "لطفا جنس کالا را وارد کنید\r\n";
                error = true;
            }                     
            if (error)
                MessageBox.Show(err);
            else
            {
                cExpert.enterProduct(textboxPName.Text, textboxCompany.Text, textboxCountry.Text, comboBoxEntranceType.Text,textboxMaterial.Text, (float)PValue.Value, (int)PPrice.Value);
                textboxPName.Text = "";
                textboxCompany.Text = "";
                textboxCountry.Text = "";
                comboBoxEntranceType.Text = "";
                PPrice.Value = 0;
                PValue.Value = 0;
                textboxMaterial.Text = "";
                tabControlExpert.TabPages.Remove(tabPagePInfo);
                tabControlExpert.TabPages.Add(tabPagePInfo);
                tabControlExpert.SelectTab(tabPagePInfo);
            }
        }

        private void buttonCancel3_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
            logout.Show();
        }

        private void buttonEnterLicenses_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Add(tabPageEnterLicense);
            tabControlExpert.SelectTab(tabPageEnterLicense);
        }

        private void buttonCancel4_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Remove(tabPageEnterLicense);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
            logout.Show();
        }

        private void buttonFinalizeLicenses_Click(object sender, EventArgs e)
        {
            bool success = cExpert.validateLicenses();
            tabControlExpert.TabPages.Remove(tabPageEnterLicense);
            tabControlExpert.TabPages.Add(tabPageLicenseValidationReport);
            tabControlExpert.SelectTab(tabPageLicenseValidationReport);

            if (success)
            {
                labelResult.Text = "اظهارنامه با موفقیت تایید شد";
                approvedPicture.Show();
            }
            else
            {
                labelResult.Text = "مجوز های لازم برای اظهارنامه را ندارید";
                approvedPicture.Hide();
            }
        }
        
        private void buttonSubmitLicenseID_Click(object sender, EventArgs e)
        {
            if (textBoxLicenseID.Text == "")
                MessageBox.Show("لطفا شماره مجوز را وارد کنید");
            else
            {
                int status = cExpert.enterLicense(textBoxLicenseID.Text);
                switch (status)
                {
                    case -3: // license not exist
                        MessageBox.Show("شماره مجوز وارد شده معتبر نمی باشد.");
                        break;
                    case -2: // license not belong to bMan
                        MessageBox.Show("این مجوز متعلق به تاجر ثبت شده در اظهارنامه نمی باشد");
                        break;
                    case -1: // license not valid
                        MessageBox.Show("مجوز وارد شده اعتبار ندارد");
                        break;
                    default:
                        break;
                }
                textBoxLicenseID.Text = "";
                tabControlExpert.TabPages.Remove(tabPageEnterLicense);
                tabControlExpert.TabPages.Add(tabPageEnterLicense);
                tabControlExpert.SelectTab(tabPageEnterLicense);
            }
        }

        private void buttonCancel5_Click(object sender, EventArgs e)
        {
            tabControlExpert.TabPages.Remove(tabPageLicenseValidationReport);
            tabControlExpert.TabPages.Remove(tabPageEnterLicense);
            tabControlExpert.TabPages.Remove(tabPageNeedLicences);
            tabControlExpert.TabPages.Remove(tabPageLicenseValidationReport);
            
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
            logout.Show();
        }

        private void buttonPrintReport_Click(object sender, EventArgs e)
        {
            ///print process
            ///
            tabControlExpert.TabPages.Remove(tabPageLicenseValidationReport);
            tabControlExpert.SelectTab(tabPageExpertPanel);
            buttonAddDeclaration.Show();
            logout.Show();
           
        }

        private void logout_Click(object sender, EventArgs e)
        {
            cExpert = null;
            this.Hide();
            PanelLogin login = new PanelLogin();
            login.Show();
        }
    
    }
}
