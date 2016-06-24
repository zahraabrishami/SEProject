namespace view
{
    partial class PanelAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlAgent = new System.Windows.Forms.TabControl();
            this.tabPageAgentPanel = new System.Windows.Forms.TabPage();
            this.logout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.buttonAddLicense = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageLicenseInfo = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSubmitBInfo = new System.Windows.Forms.Button();
            this.buttonCancel1 = new System.Windows.Forms.Button();
            this.groupboxBInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.textboxLicenseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxBname = new System.Windows.Forms.TextBox();
            this.textboxSSN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxBfamily = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageProductInfo = new System.Windows.Forms.TabPage();
            this.buttonCancel2 = new System.Windows.Forms.Button();
            this.buttonFinalizeProducts = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxPInfo = new System.Windows.Forms.GroupBox();
            this.PPrice = new System.Windows.Forms.NumericUpDown();
            this.PValue = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textboxMaterial = new System.Windows.Forms.TextBox();
            this.comboBoxEntranceType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textboxCountry = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textboxCompany = new System.Windows.Forms.TextBox();
            this.textboxPName = new System.Windows.Forms.TextBox();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.LicenseID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.licensedPicture = new System.Windows.Forms.PictureBox();
            this.productDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControlAgent.SuspendLayout();
            this.tabPageAgentPanel.SuspendLayout();
            this.tabPageLicenseInfo.SuspendLayout();
            this.groupboxBInfo.SuspendLayout();
            this.tabPageProductInfo.SuspendLayout();
            this.groupBoxPInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PValue)).BeginInit();
            this.tabPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAgent
            // 
            this.tabControlAgent.Controls.Add(this.tabPageAgentPanel);
            this.tabControlAgent.Controls.Add(this.tabPageLicenseInfo);
            this.tabControlAgent.Controls.Add(this.tabPageProductInfo);
            this.tabControlAgent.Controls.Add(this.tabPageResult);
            this.tabControlAgent.Location = new System.Drawing.Point(0, 1);
            this.tabControlAgent.Name = "tabControlAgent";
            this.tabControlAgent.SelectedIndex = 0;
            this.tabControlAgent.Size = new System.Drawing.Size(925, 542);
            this.tabControlAgent.TabIndex = 48;
            // 
            // tabPageAgentPanel
            // 
            this.tabPageAgentPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageAgentPanel.Controls.Add(this.pictureBox4);
            this.tabPageAgentPanel.Controls.Add(this.logout);
            this.tabPageAgentPanel.Controls.Add(this.label4);
            this.tabPageAgentPanel.Controls.Add(this.labelAgentName);
            this.tabPageAgentPanel.Controls.Add(this.buttonAddLicense);
            this.tabPageAgentPanel.Controls.Add(this.label12);
            this.tabPageAgentPanel.Location = new System.Drawing.Point(4, 24);
            this.tabPageAgentPanel.Name = "tabPageAgentPanel";
            this.tabPageAgentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgentPanel.Size = new System.Drawing.Size(917, 514);
            this.tabPageAgentPanel.TabIndex = 0;
            this.tabPageAgentPanel.Text = "پنل نماینده سازمان";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Teal;
            this.logout.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.logout.Location = new System.Drawing.Point(102, 420);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(146, 43);
            this.logout.TabIndex = 54;
            this.logout.Text = "خروج از سیستم";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nasim", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(315, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "خوش آمدید";
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.Font = new System.Drawing.Font("B Nasim", 15F, System.Drawing.FontStyle.Bold);
            this.labelAgentName.Location = new System.Drawing.Point(465, 197);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(112, 28);
            this.labelAgentName.TabIndex = 52;
            this.labelAgentName.Text = "نام کاربری";
            // 
            // buttonAddLicense
            // 
            this.buttonAddLicense.BackColor = System.Drawing.Color.Teal;
            this.buttonAddLicense.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonAddLicense.Location = new System.Drawing.Point(677, 420);
            this.buttonAddLicense.Name = "buttonAddLicense";
            this.buttonAddLicense.Size = new System.Drawing.Size(146, 43);
            this.buttonAddLicense.TabIndex = 51;
            this.buttonAddLicense.Text = "صدور مجوز";
            this.buttonAddLicense.UseVisualStyleBackColor = false;
            this.buttonAddLicense.Click += new System.EventHandler(this.buttonAddLicense_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Nasim", 20F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(656, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 38);
            this.label12.TabIndex = 49;
            this.label12.Text = ":نماینده سازمان";
            // 
            // tabPageLicenseInfo
            // 
            this.tabPageLicenseInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageLicenseInfo.Controls.Add(this.label8);
            this.tabPageLicenseInfo.Controls.Add(this.buttonSubmitBInfo);
            this.tabPageLicenseInfo.Controls.Add(this.buttonCancel1);
            this.tabPageLicenseInfo.Controls.Add(this.groupboxBInfo);
            this.tabPageLicenseInfo.Location = new System.Drawing.Point(4, 24);
            this.tabPageLicenseInfo.Name = "tabPageLicenseInfo";
            this.tabPageLicenseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicenseInfo.Size = new System.Drawing.Size(917, 514);
            this.tabPageLicenseInfo.TabIndex = 1;
            this.tabPageLicenseInfo.Text = "اطلاعات مجوز";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 78;
            this.label8.Text = " اطلاعات مجوز درخواستی";
            // 
            // buttonSubmitBInfo
            // 
            this.buttonSubmitBInfo.BackColor = System.Drawing.Color.Teal;
            this.buttonSubmitBInfo.Location = new System.Drawing.Point(701, 391);
            this.buttonSubmitBInfo.Name = "buttonSubmitBInfo";
            this.buttonSubmitBInfo.Size = new System.Drawing.Size(146, 43);
            this.buttonSubmitBInfo.TabIndex = 33;
            this.buttonSubmitBInfo.Text = "تایید اطلاعات";
            this.buttonSubmitBInfo.UseVisualStyleBackColor = false;
            this.buttonSubmitBInfo.Click += new System.EventHandler(this.buttonSubmitBInfo_Click);
            // 
            // buttonCancel1
            // 
            this.buttonCancel1.BackColor = System.Drawing.Color.Teal;
            this.buttonCancel1.Location = new System.Drawing.Point(59, 391);
            this.buttonCancel1.Name = "buttonCancel1";
            this.buttonCancel1.Size = new System.Drawing.Size(146, 43);
            this.buttonCancel1.TabIndex = 31;
            this.buttonCancel1.Text = "انصراف";
            this.buttonCancel1.UseVisualStyleBackColor = false;
            this.buttonCancel1.Click += new System.EventHandler(this.buttonCancel1_Click);
            // 
            // groupboxBInfo
            // 
            this.groupboxBInfo.Controls.Add(this.label2);
            this.groupboxBInfo.Controls.Add(this.expireDate);
            this.groupboxBInfo.Controls.Add(this.textboxLicenseName);
            this.groupboxBInfo.Controls.Add(this.label1);
            this.groupboxBInfo.Controls.Add(this.textboxBname);
            this.groupboxBInfo.Controls.Add(this.textboxSSN);
            this.groupboxBInfo.Controls.Add(this.label9);
            this.groupboxBInfo.Controls.Add(this.label10);
            this.groupboxBInfo.Controls.Add(this.textboxBfamily);
            this.groupboxBInfo.Controls.Add(this.label11);
            this.groupboxBInfo.Location = new System.Drawing.Point(59, 59);
            this.groupboxBInfo.Name = "groupboxBInfo";
            this.groupboxBInfo.Size = new System.Drawing.Size(799, 298);
            this.groupboxBInfo.TabIndex = 32;
            this.groupboxBInfo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "عنوان مجوز";
            // 
            // expireDate
            // 
            this.expireDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expireDate.Location = new System.Drawing.Point(56, 35);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(542, 22);
            this.expireDate.TabIndex = 28;
            // 
            // textboxLicenseName
            // 
            this.textboxLicenseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxLicenseName.Location = new System.Drawing.Point(56, 87);
            this.textboxLicenseName.Name = "textboxLicenseName";
            this.textboxLicenseName.Size = new System.Drawing.Size(542, 22);
            this.textboxLicenseName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "تاریخ انقضا";
            // 
            // textboxBname
            // 
            this.textboxBname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxBname.Location = new System.Drawing.Point(56, 191);
            this.textboxBname.Name = "textboxBname";
            this.textboxBname.Size = new System.Drawing.Size(542, 22);
            this.textboxBname.TabIndex = 22;
            // 
            // textboxSSN
            // 
            this.textboxSSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxSSN.Location = new System.Drawing.Point(56, 137);
            this.textboxSSN.Name = "textboxSSN";
            this.textboxSSN.Size = new System.Drawing.Size(542, 22);
            this.textboxSSN.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "نام خانوادگی تاجر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(642, 144);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "شماره ملی تاجر";
            // 
            // textboxBfamily
            // 
            this.textboxBfamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxBfamily.Location = new System.Drawing.Point(56, 244);
            this.textboxBfamily.Name = "textboxBfamily";
            this.textboxBfamily.Size = new System.Drawing.Size(542, 22);
            this.textboxBfamily.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(670, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "نام تاجر";
            // 
            // tabPageProductInfo
            // 
            this.tabPageProductInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageProductInfo.Controls.Add(this.pictureBox1);
            this.tabPageProductInfo.Controls.Add(this.buttonCancel2);
            this.tabPageProductInfo.Controls.Add(this.buttonFinalizeProducts);
            this.tabPageProductInfo.Controls.Add(this.buttonAddProduct);
            this.tabPageProductInfo.Controls.Add(this.label3);
            this.tabPageProductInfo.Controls.Add(this.groupBoxPInfo);
            this.tabPageProductInfo.Location = new System.Drawing.Point(4, 24);
            this.tabPageProductInfo.Name = "tabPageProductInfo";
            this.tabPageProductInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductInfo.Size = new System.Drawing.Size(917, 514);
            this.tabPageProductInfo.TabIndex = 2;
            this.tabPageProductInfo.Text = "اطلاعات کالا";
            // 
            // buttonCancel2
            // 
            this.buttonCancel2.BackColor = System.Drawing.Color.Teal;
            this.buttonCancel2.Location = new System.Drawing.Point(166, 452);
            this.buttonCancel2.Name = "buttonCancel2";
            this.buttonCancel2.Size = new System.Drawing.Size(146, 36);
            this.buttonCancel2.TabIndex = 80;
            this.buttonCancel2.Text = "انصراف";
            this.buttonCancel2.UseVisualStyleBackColor = false;
            this.buttonCancel2.Click += new System.EventHandler(this.buttonCancel2_Click);
            // 
            // buttonFinalizeProducts
            // 
            this.buttonFinalizeProducts.BackColor = System.Drawing.Color.Teal;
            this.buttonFinalizeProducts.Location = new System.Drawing.Point(380, 452);
            this.buttonFinalizeProducts.Name = "buttonFinalizeProducts";
            this.buttonFinalizeProducts.Size = new System.Drawing.Size(146, 36);
            this.buttonFinalizeProducts.TabIndex = 82;
            this.buttonFinalizeProducts.Text = "تایید نهایی";
            this.buttonFinalizeProducts.UseVisualStyleBackColor = false;
            this.buttonFinalizeProducts.Click += new System.EventHandler(this.buttonFinalizeProducts_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.Teal;
            this.buttonAddProduct.Location = new System.Drawing.Point(596, 452);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(146, 36);
            this.buttonAddProduct.TabIndex = 81;
            this.buttonAddProduct.Text = "افزودن کالای جدید";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = " اطلاعات کالا";
            // 
            // groupBoxPInfo
            // 
            this.groupBoxPInfo.Controls.Add(this.PPrice);
            this.groupBoxPInfo.Controls.Add(this.PValue);
            this.groupBoxPInfo.Controls.Add(this.label13);
            this.groupBoxPInfo.Controls.Add(this.textboxMaterial);
            this.groupBoxPInfo.Controls.Add(this.comboBoxEntranceType);
            this.groupBoxPInfo.Controls.Add(this.label14);
            this.groupBoxPInfo.Controls.Add(this.label15);
            this.groupBoxPInfo.Controls.Add(this.label16);
            this.groupBoxPInfo.Controls.Add(this.label17);
            this.groupBoxPInfo.Controls.Add(this.label18);
            this.groupBoxPInfo.Controls.Add(this.textboxCountry);
            this.groupBoxPInfo.Controls.Add(this.label19);
            this.groupBoxPInfo.Controls.Add(this.textboxCompany);
            this.groupBoxPInfo.Controls.Add(this.textboxPName);
            this.groupBoxPInfo.Location = new System.Drawing.Point(300, 50);
            this.groupBoxPInfo.Name = "groupBoxPInfo";
            this.groupBoxPInfo.Size = new System.Drawing.Size(569, 377);
            this.groupBoxPInfo.TabIndex = 49;
            this.groupBoxPInfo.TabStop = false;
            // 
            // PPrice
            // 
            this.PPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PPrice.Location = new System.Drawing.Point(38, 278);
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(312, 22);
            this.PPrice.TabIndex = 48;
            // 
            // PValue
            // 
            this.PValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PValue.Location = new System.Drawing.Point(38, 230);
            this.PValue.Name = "PValue";
            this.PValue.Size = new System.Drawing.Size(312, 22);
            this.PValue.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "نوع جنس";
            // 
            // textboxMaterial
            // 
            this.textboxMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxMaterial.Location = new System.Drawing.Point(38, 326);
            this.textboxMaterial.Name = "textboxMaterial";
            this.textboxMaterial.Size = new System.Drawing.Size(312, 22);
            this.textboxMaterial.TabIndex = 45;
            // 
            // comboBoxEntranceType
            // 
            this.comboBoxEntranceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxEntranceType.FormattingEnabled = true;
            this.comboBoxEntranceType.Items.AddRange(new object[] {
            "زمینی",
            "هوایی",
            "دریایی"});
            this.comboBoxEntranceType.Location = new System.Drawing.Point(38, 181);
            this.comboBoxEntranceType.Name = "comboBoxEntranceType";
            this.comboBoxEntranceType.Size = new System.Drawing.Size(312, 23);
            this.comboBoxEntranceType.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 43;
            this.label14.Text = "قیمت واحد کالا";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(455, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "مقدار کالا";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(455, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "نام کالا";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(423, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "نحوه ورود به کشور";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(453, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 34;
            this.label18.Text = "کشور مبدا";
            // 
            // textboxCountry
            // 
            this.textboxCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxCountry.Location = new System.Drawing.Point(38, 133);
            this.textboxCountry.Name = "textboxCountry";
            this.textboxCountry.Size = new System.Drawing.Size(312, 22);
            this.textboxCountry.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(427, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 15);
            this.label19.TabIndex = 32;
            this.label19.Text = "شرکت تولید کننده";
            // 
            // textboxCompany
            // 
            this.textboxCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxCompany.Location = new System.Drawing.Point(38, 85);
            this.textboxCompany.Name = "textboxCompany";
            this.textboxCompany.Size = new System.Drawing.Size(312, 22);
            this.textboxCompany.TabIndex = 31;
            // 
            // textboxPName
            // 
            this.textboxPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxPName.Location = new System.Drawing.Point(38, 37);
            this.textboxPName.Name = "textboxPName";
            this.textboxPName.Size = new System.Drawing.Size(312, 22);
            this.textboxPName.TabIndex = 29;
            // 
            // tabPageResult
            // 
            this.tabPageResult.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageResult.Controls.Add(this.licensedPicture);
            this.tabPageResult.Controls.Add(this.LicenseID);
            this.tabPageResult.Controls.Add(this.label5);
            this.tabPageResult.Controls.Add(this.buttonEnd);
            this.tabPageResult.Controls.Add(this.result);
            this.tabPageResult.Location = new System.Drawing.Point(4, 24);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(917, 514);
            this.tabPageResult.TabIndex = 3;
            this.tabPageResult.Text = "نتیجه";
            // 
            // LicenseID
            // 
            this.LicenseID.AutoSize = true;
            this.LicenseID.Font = new System.Drawing.Font("B Nasim", 10F, System.Drawing.FontStyle.Bold);
            this.LicenseID.Location = new System.Drawing.Point(522, 303);
            this.LicenseID.Name = "LicenseID";
            this.LicenseID.Size = new System.Drawing.Size(80, 19);
            this.LicenseID.TabIndex = 50;
            this.LicenseID.Text = "LicenseID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nasim", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(656, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = ":شماره ی مجوز";
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.Teal;
            this.buttonEnd.Location = new System.Drawing.Point(103, 424);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(146, 36);
            this.buttonEnd.TabIndex = 48;
            this.buttonEnd.Text = "اتمام";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("B Nasim", 32F, System.Drawing.FontStyle.Bold);
            this.result.Location = new System.Drawing.Point(460, 132);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(143, 61);
            this.result.TabIndex = 0;
            this.result.Text = "نتیجه";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::domain.Properties.Resources.Value_Price_600_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(45, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // licensedPicture
            // 
            this.licensedPicture.Image = global::domain.Properties.Resources.License_Registration;
            this.licensedPicture.Location = new System.Drawing.Point(103, 108);
            this.licensedPicture.Name = "licensedPicture";
            this.licensedPicture.Size = new System.Drawing.Size(289, 245);
            this.licensedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.licensedPicture.TabIndex = 51;
            this.licensedPicture.TabStop = false;
            // 
            // productDescriptionBindingSource
            // 
            this.productDescriptionBindingSource.DataSource = typeof(domain.ProductDescription);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::domain.Properties.Resources.user_male_1_512;
            this.pictureBox4.Location = new System.Drawing.Point(78, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 186);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // PanelAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(927, 537);
            this.Controls.Add(this.tabControlAgent);
            this.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold);
            this.Name = "PanelAgent";
            this.Text = "پنل نماینده سازمان";
            this.Load += new System.EventHandler(this.PanelIssuanceLicense_Load);
            this.tabControlAgent.ResumeLayout(false);
            this.tabPageAgentPanel.ResumeLayout(false);
            this.tabPageAgentPanel.PerformLayout();
            this.tabPageLicenseInfo.ResumeLayout(false);
            this.tabPageLicenseInfo.PerformLayout();
            this.groupboxBInfo.ResumeLayout(false);
            this.groupboxBInfo.PerformLayout();
            this.tabPageProductInfo.ResumeLayout(false);
            this.tabPageProductInfo.PerformLayout();
            this.groupBoxPInfo.ResumeLayout(false);
            this.groupBoxPInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PValue)).EndInit();
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAgent;
        private System.Windows.Forms.TabPage tabPageAgentPanel;
        private System.Windows.Forms.TabPage tabPageLicenseInfo;
        private System.Windows.Forms.Button buttonSubmitBInfo;
        private System.Windows.Forms.Button buttonCancel1;
        private System.Windows.Forms.GroupBox groupboxBInfo;
        private System.Windows.Forms.TextBox textboxBname;
        private System.Windows.Forms.TextBox textboxSSN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textboxBfamily;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddLicense;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textboxLicenseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.DateTimePicker expireDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label LicenseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageProductInfo;
        private System.Windows.Forms.BindingSource productDescriptionBindingSource;
        private System.Windows.Forms.Button buttonCancel2;
        private System.Windows.Forms.Button buttonFinalizeProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxPInfo;
        private System.Windows.Forms.NumericUpDown PPrice;
        private System.Windows.Forms.NumericUpDown PValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textboxMaterial;
        private System.Windows.Forms.ComboBox comboBoxEntranceType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textboxCountry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textboxCompany;
        private System.Windows.Forms.TextBox textboxPName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox licensedPicture;
        private System.Windows.Forms.PictureBox pictureBox4;

    }
}