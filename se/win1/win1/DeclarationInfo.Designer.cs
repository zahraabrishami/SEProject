namespace win1
{
    partial class DeclarationInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bfamily = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 111);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "شماره ملی تاجر";
            // 
            // SSN
            // 
            this.SSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SSN.Location = new System.Drawing.Point(171, 108);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(429, 26);
            this.SSN.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام تاجر";
            // 
            // Bname
            // 
            this.Bname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bname.Location = new System.Drawing.Point(171, 151);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(429, 26);
            this.Bname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "نام خانوادگی تاجر";
            // 
            // Bfamily
            // 
            this.Bfamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bfamily.Location = new System.Drawing.Point(171, 192);
            this.Bfamily.Name = "Bfamily";
            this.Bfamily.Size = new System.Drawing.Size(429, 26);
            this.Bfamily.TabIndex = 9;
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Teal;
            this.AddProductButton.Location = new System.Drawing.Point(291, 243);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(172, 39);
            this.AddProductButton.TabIndex = 11;
            this.AddProductButton.Text = "افزودن کالای جدید";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // DeclarationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 374);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bfamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SSN);
            this.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "DeclarationInfo";
            this.RightToLeftLayout = true;
            this.Text = "ورود اطلاعات تاجر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bfamily;
        private System.Windows.Forms.Button AddProductButton;

    }
}