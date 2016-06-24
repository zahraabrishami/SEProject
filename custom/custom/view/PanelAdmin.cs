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
    public partial class PanelAdmin : Form
    {
        domain.CustomAdmin cAdmin;
        public PanelAdmin(domain.CustomAdmin _cAdmin)
        {
            cAdmin = _cAdmin;
            InitializeComponent();
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            labelAgentName.Text = cAdmin.name + " " + cAdmin.family;
            startDate.Value = DateTime.Today;
            tabControlAdmin.TabPages.Remove(tabPageRuleInfo);
            tabControlAdmin.TabPages.Remove(tabPageLicenses);
            tabControlAdmin.TabPages.Remove(tabPageProductInfo);
            tabControlAdmin.TabPages.Remove(tabPageResult);
            tabControlAdmin.TabPages.Remove(tabPageSignUp);
            tabControlAdmin.TabPages.Remove(tabPageSignUpResult);
            tabControlAdmin.TabPages.Remove(tabPageRuleList);
        }

        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            buttonAddRule.Hide();
            logout.Hide();
            tabControlAdmin.TabPages.Add(tabPageRuleInfo);
            tabControlAdmin.SelectTab(tabPageRuleInfo);
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            cAdmin.curRule = null;
            tabControlAdmin.TabPages.Remove(tabPageRuleInfo);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }

        private void buttonSubmitRuleInfo_Click(object sender, EventArgs e)
        {
            string err = "";
            bool error = false;
            float endValue1;
            int endUnitPrice1;
            if (endValue.Value == 0)
                endValue1 = (float)endValue.Maximum;
            else
                endValue1 = (float)endValue.Value;
            if (endUnitPrice.Value == 0)
                endUnitPrice1 = (int)endUnitPrice.Maximum;
            else
                endUnitPrice1 = (int)endUnitPrice.Value;

            if (startDate.Value > endDate.Value)
            {
                err += "بازه ی تاریخ اظهار نامعتبر است\r\n";
                error = true;
            }
            if ((float)startValue.Value > endValue1)
            {
                err += "بازه ی مقدار نامعتبر است\r\n";
                error = true;
            }
            if ((int)startUnitPrice.Value > endUnitPrice1)
            {
                err += "بازه ی قیمت نامعتبر است\r\n";
                error = true;
            }
            if (error)
                MessageBox.Show(err);
            else
            {
                cAdmin.enterRuleInfo((float)startValue.Value, endValue1, startDate.Value, endDate.Value, (int)startUnitPrice.Value, endUnitPrice1);
                BindingList<domain.ProductDescription> pds = new BindingList<domain.ProductDescription>();
                foreach (domain.ProductDescription pd in cAdmin.curRule.pDescriptions)
                    pds.Add(pd);
                dataGridViewProducts.DataSource = pds;
                tabControlAdmin.TabPages.Remove(tabPageRuleInfo);
                tabControlAdmin.TabPages.Add(tabPageProductInfo);
                tabControlAdmin.SelectTab(tabPageProductInfo);
                startDate.Value = startDate.MinDate;
                endDate.Value = endDate.MaxDate;
                startUnitPrice.Value = 0;
                endUnitPrice.Value = 0;
                startValue.Value = 0;
                endValue.Value = 0;
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textboxPName.Text == "" && textboxCompany.Text == "" && textboxCountry.Text == "" && comboBoxEntranceType.Text == "" && textboxMaterial.Text=="")
                MessageBox.Show("لطفا مشخصات کالا را وارد کنید\r\n");
            else
            {
                cAdmin.enterProductDescription(textboxPName.Text, textboxCompany.Text, textboxCountry.Text, comboBoxEntranceType.Text, textboxMaterial.Text);
                BindingList<domain.ProductDescription> pds = new BindingList<domain.ProductDescription>();
                foreach(domain.ProductDescription pd in cAdmin.curRule.pDescriptions)
                    pds.Add(pd);
                dataGridViewProducts.DataSource = pds;
                tabControlAdmin.TabPages.Remove(tabPageProductInfo);
                tabControlAdmin.TabPages.Add(tabPageProductInfo);
                tabControlAdmin.SelectTab(tabPageProductInfo);
                textboxPName.Text = "";
                textboxCompany.Text = "";
                textboxCountry.Text = "";
                comboBoxEntranceType.Text = "";
                textboxMaterial.Text = "";
            }
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            cAdmin.curRule = null;
            tabControlAdmin.TabPages.Remove(tabPageProductInfo);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }

        private void buttonFinalizeProducts_Click(object sender, EventArgs e)
        {
            tabControlAdmin.TabPages.Remove(tabPageProductInfo);
            tabControlAdmin.TabPages.Add(tabPageLicenses);
            tabControlAdmin.SelectTab(tabPageLicenses);
            dataGridViewLicenses.Rows.Clear();
            dataGridViewLicenses.Refresh();
            foreach (string l in cAdmin.curRule.licenseNames)
            {
                string[] row = new string[2];
                row[1] = l;
                dataGridViewLicenses.Rows.Add(row);
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            cAdmin.curRule = null;
            tabControlAdmin.TabPages.Remove(tabPageResult);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }

        private void newLicenseName_Click(object sender, EventArgs e)
        {
            dataGridViewLicenses.Rows.Clear();
            dataGridViewLicenses.Refresh();
            if (licenseName1.Text == "")
                MessageBox.Show("لطفا عنوان مجوز را وارد کنید\r\n");
            else
            {
                cAdmin.enterLicenseName(licenseName1.Text);
                foreach (string l in cAdmin.curRule.licenseNames)
                {
                    string[] row = new string[2];
                    row[1] = l;
                    dataGridViewLicenses.Rows.Add(row);
                }
                licenseName1.Text = "";
            }
        }

        private void finalizeRule_Click(object sender, EventArgs e)
        {
            if (cAdmin.curRule.licenseNames.Count == 0)
                MessageBox.Show("حداقل یک مجوز وارد کنید\r\n");
            else
            {
                cAdmin.submitRule();
                dataGridViewLicenses.Rows.Clear();
                dataGridViewLicenses.Refresh();
                licenseName1.Text = "";
                tabControlAdmin.TabPages.Remove(tabPageLicenses);
                tabControlAdmin.TabPages.Add(tabPageResult);
                tabControlAdmin.SelectTab(tabPageResult);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cAdmin.curRule = null;
            tabControlAdmin.TabPages.Remove(tabPageLicenses);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }


        private void logout_Click_1(object sender, EventArgs e)
        {
            cAdmin = null;
            this.Hide();
            PanelLogin login = new PanelLogin();
            login.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string err = "";
            bool error = false;
            if (name.Text == "")
            {
                err += "لطفا نام را وارد کنید\r\n";
                error = true;
            }
            if (family.Text == "")
            {
                err += "لطفا نام خانوادگی را وارد کنید\r\n";
                error = true;
            }
            if (role.Text == "")
            {
                err += "لطفا نقش را وارد کنید\r\n";
                error = true;
            }
            if (organization.Text == "")
            {
                err += "لطفا نام سازمان را وارد کنید\r\n";
                error = true;
            }
            if (password.Text == "")
            {
                err += "لطفا رمز عبور را وارد کنید\r\n";
                error = true;
            }
            if (error)
                MessageBox.Show(err);
            else
            {
                string staffNo = cAdmin.signUp(name.Text, family.Text, role.Text, organization.Text, password.Text);
                username.Text = staffNo;
                pass.Text = password.Text;
                tabControlAdmin.TabPages.Remove(tabPageSignUp);
                tabControlAdmin.TabPages.Add(tabPageSignUpResult);
                tabControlAdmin.SelectTab(tabPageSignUpResult);
                name.Text = "";
                family.Text = "";
                role.Text = "";
                organization.Text = "";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cAdmin.curRule = null;
            tabControlAdmin.TabPages.Remove(tabPageSignUp);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            tabControlAdmin.TabPages.Add(tabPageSignUp);
            tabControlAdmin.SelectTab(tabPageSignUp);
            buttonAddRule.Hide();
            logout.Hide();
        }

        private void buttonEndSignUp_Click(object sender, EventArgs e)
        {
            password.Text = "";
            tabControlAdmin.TabPages.Remove(tabPageSignUpResult);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }

        private void buttonShowRules_Click(object sender, EventArgs e)
        {
            tabControlAdmin.TabPages.Add(tabPageRuleList);
            tabControlAdmin.SelectTab(tabPageRuleList);
            List<domain.Rule> rules = cAdmin.getAllRules();
            BindingList<domain.Rule> rulesToDisplay = new BindingList<domain.Rule>();
            foreach(domain.Rule r in rules)
                rulesToDisplay.Add(r);
            dataGridViewRules.DataSource = rulesToDisplay;
            buttonAddRule.Hide();
            logout.Hide();
        }

        private void dataGridViewRules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<domain.Rule> rules = cAdmin.getAllRules();
            DataGridViewRow row = dataGridViewRules.Rows[e.RowIndex];
            if (e.ColumnIndex == 0) /////////////////////delete
            {                 
                cAdmin.deleteRule(row.Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                rules = cAdmin.getAllRules();
                BindingList<domain.Rule> rulesToDisplay = new BindingList<domain.Rule>();
                foreach (domain.Rule r in rules)
                    rulesToDisplay.Add(r);
                dataGridViewRules.DataSource = rulesToDisplay;
            }
            if (e.ColumnIndex == 1) //////////////////////edit
            {
                foreach(domain.Rule r in rules) {
                    if(r.ruleID==row.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) 
                    {
                        cAdmin.curRule = r;
                        startDate.Value = r.startDate;
                        endDate.Value = r.endDate;
                        startValue.Value = (decimal)r.startValue;
                        endValue.Value = (decimal)r.endValue;
                        startUnitPrice.Value = (decimal)r.startUnitPrice;
                        endUnitPrice.Value = (decimal)r.endUnitPrice;
                        tabControlAdmin.TabPages.Remove(tabPageRuleList);
                        tabControlAdmin.TabPages.Add(tabPageRuleInfo);
                        tabControlAdmin.SelectTab(tabPageRuleInfo);
                        break;
                    }
                }
                
            }
            if (e.ColumnIndex == 9) //////////////////////show products
            {
                foreach (domain.Rule r in rules)
                {
                    if (r.ruleID == row.Cells["dataGridViewTextBoxColumn1"].Value.ToString())
                    {
                        products p = new products(r.pDescriptions);
                        p.ShowDialog();
                        break;
                    }
                }
            }
            if (e.ColumnIndex == 10) //////////////////////show licenses
            {
                foreach (domain.Rule r in rules)
                {
                    if (r.ruleID == row.Cells["dataGridViewTextBoxColumn1"].Value.ToString())
                    {
                        licenses l = new licenses(r.licenseNames);
                        l.ShowDialog();
                        break;
                    }
                }
            }
                
        }

        private void buttonreturn_Click(object sender, EventArgs e)
        {
            cAdmin.curRule = null;
            tabControlAdmin.TabPages.Remove(tabPageRuleList);
            tabControlAdmin.SelectTab(tabPageAdminPanel);
            buttonAddRule.Show();
            logout.Show();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0) /////////////////////delete
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                List<domain.ProductDescription> pds=new List<domain.ProductDescription>();
                foreach (domain.ProductDescription pd in cAdmin.curRule.pDescriptions)
                    if (pd.productDescriptionID != row.Cells["DGid"].Value.ToString())
                        pds.Add(pd);
                cAdmin.curRule.pDescriptions = pds;
                BindingList<domain.ProductDescription> pdstoshow = new BindingList<domain.ProductDescription>();
                foreach (domain.ProductDescription pd in pds)
                    pdstoshow.Add(pd);
                dataGridViewProducts.DataSource = pdstoshow;
            }
            if (e.ColumnIndex == 1) /////////////////////edit
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                textboxPName.Text = row.Cells["DGname"].Value.ToString();
                textboxCompany.Text = row.Cells["DGcompany"].Value.ToString();
                textboxCountry.Text = row.Cells["DGcountry"].Value.ToString();
                comboBoxEntranceType.Text = row.Cells["DGenterance"].Value.ToString();
                textboxMaterial.Text = row.Cells["DGmaterial"].Value.ToString();
            }
        }

        private void dataGridViewLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) /////////////////////delete
            {
                List<string> licenses = new List<string>();
                DataGridViewRow row = dataGridViewLicenses.Rows[e.RowIndex];
                foreach (string l in cAdmin.curRule.licenseNames)
                    if (l != row.Cells["licenseName"].Value.ToString())
                        licenses.Add(l);
                cAdmin.curRule.licenseNames = licenses;
                dataGridViewLicenses.Rows.Clear();
                dataGridViewLicenses.Refresh();
                foreach (string l in cAdmin.curRule.licenseNames)
                {
                    string[] newrow = new string[2];
                    newrow[1] = l;
                    dataGridViewLicenses.Rows.Add(newrow);
                }
            }
        }



    }
}
