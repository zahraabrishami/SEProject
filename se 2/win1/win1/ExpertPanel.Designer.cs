namespace win1
{
    partial class ExpertPanel
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
            this.AddDeclarationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDeclarationButton
            // 
            this.AddDeclarationButton.BackColor = System.Drawing.Color.Teal;
            this.AddDeclarationButton.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddDeclarationButton.Location = new System.Drawing.Point(289, 150);
            this.AddDeclarationButton.Name = "AddDeclarationButton";
            this.AddDeclarationButton.Size = new System.Drawing.Size(130, 73);
            this.AddDeclarationButton.TabIndex = 0;
            this.AddDeclarationButton.Text = "ایجاد اظهارنامه ";
            this.AddDeclarationButton.UseVisualStyleBackColor = false;
            this.AddDeclarationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nasim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(458, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = ":پنل کارشناس گمرک";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(272, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "//////////";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExpertPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(720, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDeclarationButton);
            this.Font = new System.Drawing.Font("B Nasim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ExpertPanel";
            this.Text = "پنل کارشناس گمرک";
            this.Load += new System.EventHandler(this.ExpertPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDeclarationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}