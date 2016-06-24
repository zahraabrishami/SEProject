namespace view
{
    partial class products
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.نامDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.شرکتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.کشورمبداDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نحوهورودDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.شناسهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.جنسDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.نامDataGridViewTextBoxColumn,
            this.شرکتDataGridViewTextBoxColumn,
            this.کشورمبداDataGridViewTextBoxColumn,
            this.نحوهورودDataGridViewTextBoxColumn,
            this.شناسهDataGridViewTextBoxColumn,
            this.جنسDataGridViewTextBoxColumn});
            this.dataGridViewProducts.DataSource = this.productDescriptionBindingSource;
            this.dataGridViewProducts.Location = new System.Drawing.Point(52, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(480, 288);
            this.dataGridViewProducts.TabIndex = 84;
            // 
            // نامDataGridViewTextBoxColumn
            // 
            this.نامDataGridViewTextBoxColumn.DataPropertyName = "نام";
            this.نامDataGridViewTextBoxColumn.HeaderText = "نام";
            this.نامDataGridViewTextBoxColumn.Name = "نامDataGridViewTextBoxColumn";
            this.نامDataGridViewTextBoxColumn.ReadOnly = true;
            this.نامDataGridViewTextBoxColumn.Width = 45;
            // 
            // شرکتDataGridViewTextBoxColumn
            // 
            this.شرکتDataGridViewTextBoxColumn.DataPropertyName = "شرکت";
            this.شرکتDataGridViewTextBoxColumn.HeaderText = "شرکت";
            this.شرکتDataGridViewTextBoxColumn.Name = "شرکتDataGridViewTextBoxColumn";
            this.شرکتDataGridViewTextBoxColumn.ReadOnly = true;
            this.شرکتDataGridViewTextBoxColumn.Width = 61;
            // 
            // کشورمبداDataGridViewTextBoxColumn
            // 
            this.کشورمبداDataGridViewTextBoxColumn.DataPropertyName = "کشور_مبدا";
            this.کشورمبداDataGridViewTextBoxColumn.HeaderText = "کشور_مبدا";
            this.کشورمبداDataGridViewTextBoxColumn.Name = "کشورمبداDataGridViewTextBoxColumn";
            this.کشورمبداDataGridViewTextBoxColumn.ReadOnly = true;
            this.کشورمبداDataGridViewTextBoxColumn.Width = 82;
            // 
            // نحوهورودDataGridViewTextBoxColumn
            // 
            this.نحوهورودDataGridViewTextBoxColumn.DataPropertyName = "نحوه_ورود";
            this.نحوهورودDataGridViewTextBoxColumn.HeaderText = "نحوه_ورود";
            this.نحوهورودDataGridViewTextBoxColumn.Name = "نحوهورودDataGridViewTextBoxColumn";
            this.نحوهورودDataGridViewTextBoxColumn.ReadOnly = true;
            this.نحوهورودDataGridViewTextBoxColumn.Width = 83;
            // 
            // شناسهDataGridViewTextBoxColumn
            // 
            this.شناسهDataGridViewTextBoxColumn.DataPropertyName = "شناسه";
            this.شناسهDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.شناسهDataGridViewTextBoxColumn.Name = "شناسهDataGridViewTextBoxColumn";
            this.شناسهDataGridViewTextBoxColumn.ReadOnly = true;
            this.شناسهDataGridViewTextBoxColumn.Width = 63;
            // 
            // جنسDataGridViewTextBoxColumn
            // 
            this.جنسDataGridViewTextBoxColumn.DataPropertyName = "جنس";
            this.جنسDataGridViewTextBoxColumn.HeaderText = "جنس";
            this.جنسDataGridViewTextBoxColumn.Name = "جنسDataGridViewTextBoxColumn";
            this.جنسDataGridViewTextBoxColumn.ReadOnly = true;
            this.جنسDataGridViewTextBoxColumn.Width = 52;
            // 
            // productDescriptionBindingSource
            // 
            this.productDescriptionBindingSource.DataSource = typeof(domain.ProductDescription);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(589, 316);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "products";
            this.Text = "لیست کالا ها";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn نامDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn شرکتDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn کشورمبداDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نحوهورودDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn شناسهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn جنسDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productDescriptionBindingSource;
    }
}