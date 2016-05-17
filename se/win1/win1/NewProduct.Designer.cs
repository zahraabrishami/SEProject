namespace win1
{
    partial class NewProduct
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EntranceType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.FinalizeProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Teal;
            this.AddProductButton.Location = new System.Drawing.Point(376, 415);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(170, 35);
            this.AddProductButton.TabIndex = 18;
            this.AddProductButton.Text = "افزودن کالای جدید";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "کشور مبدا";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Country.Location = new System.Drawing.Point(173, 183);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(382, 26);
            this.Country.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "شرکت تولید کننده";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Company
            // 
            this.Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Company.Location = new System.Drawing.Point(173, 140);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(382, 26);
            this.Company.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام کالا";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductName.Location = new System.Drawing.Point(173, 96);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(382, 26);
            this.ProductName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "نحوه ورود به کشور";
            // 
            // EntranceType
            // 
            this.EntranceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EntranceType.Location = new System.Drawing.Point(173, 228);
            this.EntranceType.Name = "EntranceType";
            this.EntranceType.Size = new System.Drawing.Size(382, 26);
            this.EntranceType.TabIndex = 19;
            this.EntranceType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "وزن کالا";
            // 
            // ProductWeight
            // 
            this.ProductWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductWeight.Location = new System.Drawing.Point(173, 273);
            this.ProductWeight.Name = "ProductWeight";
            this.ProductWeight.Size = new System.Drawing.Size(382, 26);
            this.ProductWeight.TabIndex = 21;
            this.ProductWeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "تعداد کالا";
            // 
            // ProductNumber
            // 
            this.ProductNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductNumber.Location = new System.Drawing.Point(173, 316);
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.Size = new System.Drawing.Size(382, 26);
            this.ProductNumber.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "قیمت واحد کالا";
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductPrice.Location = new System.Drawing.Point(173, 359);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(382, 26);
            this.ProductPrice.TabIndex = 25;
            // 
            // FinalizeProducts
            // 
            this.FinalizeProducts.BackColor = System.Drawing.Color.Teal;
            this.FinalizeProducts.Location = new System.Drawing.Point(186, 415);
            this.FinalizeProducts.Name = "FinalizeProducts";
            this.FinalizeProducts.Size = new System.Drawing.Size(170, 35);
            this.FinalizeProducts.TabIndex = 28;
            this.FinalizeProducts.Text = "تایید نهایی";
            this.FinalizeProducts.UseVisualStyleBackColor = false;
            this.FinalizeProducts.Click += new System.EventHandler(this.FinalizeProducts_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(796, 529);
            this.Controls.Add(this.FinalizeProducts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EntranceType);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductName);
            this.Font = new System.Drawing.Font("B Nasim", 7.8F);
            this.Name = "NewProduct";
            this.Text = "اطلاعات کالا";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EntranceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button FinalizeProducts;
    }
}