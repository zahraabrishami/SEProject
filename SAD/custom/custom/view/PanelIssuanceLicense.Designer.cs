namespace View
{
    partial class PanelIssuanceLicense
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAgentPanel = new System.Windows.Forms.TabPage();
            this.tabPageBmanInfo2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProductNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ExpireDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.TextBox();
            this.FinalizeLicenseInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.UpperProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EntranceType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSubmitBInfo = new System.Windows.Forms.Button();
            this.buttonCancel1 = new System.Windows.Forms.Button();
            this.groupboxBInfo = new System.Windows.Forms.GroupBox();
            this.textboxBname2 = new System.Windows.Forms.TextBox();
            this.textboxSSN2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxBfamily3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAddLicense = new System.Windows.Forms.Button();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAgentPanel.SuspendLayout();
            this.tabPageBmanInfo2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupboxBInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAgentPanel);
            this.tabControl1.Controls.Add(this.tabPageBmanInfo2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 542);
            this.tabControl1.TabIndex = 48;
            // 
            // tabPageAgentPanel
            // 
            this.tabPageAgentPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageAgentPanel.Controls.Add(this.buttonAddLicense);
            this.tabPageAgentPanel.Controls.Add(this.label12);
            this.tabPageAgentPanel.Controls.Add(this.labelAgentName);
            this.tabPageAgentPanel.Location = new System.Drawing.Point(4, 27);
            this.tabPageAgentPanel.Name = "tabPageAgentPanel";
            this.tabPageAgentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgentPanel.Size = new System.Drawing.Size(917, 511);
            this.tabPageAgentPanel.TabIndex = 0;
            this.tabPageAgentPanel.Text = "پنل نماینده سازمان";
            // 
            // tabPageBmanInfo2
            // 
            this.tabPageBmanInfo2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageBmanInfo2.Controls.Add(this.buttonSubmitBInfo);
            this.tabPageBmanInfo2.Controls.Add(this.buttonCancel1);
            this.tabPageBmanInfo2.Controls.Add(this.groupboxBInfo);
            this.tabPageBmanInfo2.Location = new System.Drawing.Point(4, 27);
            this.tabPageBmanInfo2.Name = "tabPageBmanInfo2";
            this.tabPageBmanInfo2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBmanInfo2.Size = new System.Drawing.Size(917, 511);
            this.tabPageBmanInfo2.TabIndex = 1;
            this.tabPageBmanInfo2.Text = "اطلاعات تاجر";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.ProductNumber);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProductName);
            this.tabPage1.Controls.Add(this.ExpireDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Company);
            this.tabPage1.Controls.Add(this.FinalizeLicenseInfo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Country);
            this.tabPage1.Controls.Add(this.UpperProductPrice);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.EntranceType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 511);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "اطلاعات مجوز";
            // 
            // ProductNumber
            // 
            this.ProductNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductNumber.Location = new System.Drawing.Point(173, 279);
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.Size = new System.Drawing.Size(429, 26);
            this.ProductNumber.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "تاریخ پایان اعتبار";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductName.Location = new System.Drawing.Point(173, 80);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(429, 26);
            this.ProductName.TabIndex = 64;
            // 
            // ExpireDate
            // 
            this.ExpireDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExpireDate.Location = new System.Drawing.Point(173, 379);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(429, 26);
            this.ExpireDate.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "نام کالا";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = " اطلاعات مجوز درخواستی";
            // 
            // Company
            // 
            this.Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Company.Location = new System.Drawing.Point(173, 129);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(429, 26);
            this.Company.TabIndex = 66;
            // 
            // FinalizeLicenseInfo
            // 
            this.FinalizeLicenseInfo.BackColor = System.Drawing.Color.Teal;
            this.FinalizeLicenseInfo.Location = new System.Drawing.Point(283, 433);
            this.FinalizeLicenseInfo.Name = "FinalizeLicenseInfo";
            this.FinalizeLicenseInfo.Size = new System.Drawing.Size(191, 39);
            this.FinalizeLicenseInfo.TabIndex = 76;
            this.FinalizeLicenseInfo.Text = "تایید نهایی";
            this.FinalizeLicenseInfo.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "شرکت تولید کننده";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "سقف قیمت";
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Country.Location = new System.Drawing.Point(173, 177);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(429, 26);
            this.Country.TabIndex = 68;
            // 
            // UpperProductPrice
            // 
            this.UpperProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpperProductPrice.Location = new System.Drawing.Point(173, 327);
            this.UpperProductPrice.Name = "UpperProductPrice";
            this.UpperProductPrice.Size = new System.Drawing.Size(429, 26);
            this.UpperProductPrice.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "کشور مبدا";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "تعداد کالا";
            // 
            // EntranceType
            // 
            this.EntranceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EntranceType.Location = new System.Drawing.Point(173, 228);
            this.EntranceType.Name = "EntranceType";
            this.EntranceType.Size = new System.Drawing.Size(429, 26);
            this.EntranceType.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "نحوه ورود به کشور";
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
            // 
            // groupboxBInfo
            // 
            this.groupboxBInfo.Controls.Add(this.textboxBname2);
            this.groupboxBInfo.Controls.Add(this.textboxSSN2);
            this.groupboxBInfo.Controls.Add(this.label9);
            this.groupboxBInfo.Controls.Add(this.label10);
            this.groupboxBInfo.Controls.Add(this.textboxBfamily3);
            this.groupboxBInfo.Controls.Add(this.label11);
            this.groupboxBInfo.Location = new System.Drawing.Point(59, 76);
            this.groupboxBInfo.Name = "groupboxBInfo";
            this.groupboxBInfo.Size = new System.Drawing.Size(799, 266);
            this.groupboxBInfo.TabIndex = 32;
            this.groupboxBInfo.TabStop = false;
            // 
            // textboxBname2
            // 
            this.textboxBname2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxBname2.Location = new System.Drawing.Point(62, 119);
            this.textboxBname2.Name = "textboxBname2";
            this.textboxBname2.Size = new System.Drawing.Size(542, 26);
            this.textboxBname2.TabIndex = 22;
            // 
            // textboxSSN2
            // 
            this.textboxSSN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxSSN2.Location = new System.Drawing.Point(62, 65);
            this.textboxSSN2.Name = "textboxSSN2";
            this.textboxSSN2.Size = new System.Drawing.Size(542, 26);
            this.textboxSSN2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(644, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "نام خانوادگی تاجر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 69);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "شماره ملی تاجر";
            // 
            // textboxBfamily3
            // 
            this.textboxBfamily3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxBfamily3.Location = new System.Drawing.Point(62, 172);
            this.textboxBfamily3.Name = "textboxBfamily3";
            this.textboxBfamily3.Size = new System.Drawing.Size(542, 26);
            this.textboxBfamily3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "نام تاجر";
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
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAgentName.Location = new System.Drawing.Point(338, 60);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(251, 21);
            this.labelAgentName.TabIndex = 50;
            this.labelAgentName.Text = "                                                            ";
            this.labelAgentName.Click += new System.EventHandler(this.labelExpertName_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Nasim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(686, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = ":نماینده سازمان";
            // 
            // PanelIssuanceLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(927, 537);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold);
            this.Name = "PanelIssuanceLicense";
            this.Text = "پنل نماینده سازمان";
            this.Load += new System.EventHandler(this.PanelIssuanceLicense_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAgentPanel.ResumeLayout(false);
            this.tabPageAgentPanel.PerformLayout();
            this.tabPageBmanInfo2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupboxBInfo.ResumeLayout(false);
            this.groupboxBInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAgentPanel;
        private System.Windows.Forms.TabPage tabPageBmanInfo2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ProductNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ExpireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.Button FinalizeLicenseInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox UpperProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EntranceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSubmitBInfo;
        private System.Windows.Forms.Button buttonCancel1;
        private System.Windows.Forms.GroupBox groupboxBInfo;
        private System.Windows.Forms.TextBox textboxBname2;
        private System.Windows.Forms.TextBox textboxSSN2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textboxBfamily3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddLicense;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.Label label12;

    }
}