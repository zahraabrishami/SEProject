namespace view
{
    partial class licenses
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
            this.dataGridViewLicenses = new System.Windows.Forms.DataGridView();
            this.licenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLicenses
            // 
            this.dataGridViewLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLicenses.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseName});
            this.dataGridViewLicenses.Location = new System.Drawing.Point(168, 88);
            this.dataGridViewLicenses.Name = "dataGridViewLicenses";
            this.dataGridViewLicenses.Size = new System.Drawing.Size(184, 170);
            this.dataGridViewLicenses.TabIndex = 92;
            // 
            // licenseName
            // 
            this.licenseName.HeaderText = "نام مجوز";
            this.licenseName.Name = "licenseName";
            this.licenseName.Width = 71;
            // 
            // licenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(536, 319);
            this.Controls.Add(this.dataGridViewLicenses);
            this.Name = "licenses";
            this.Text = "licenses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseName;
    }
}