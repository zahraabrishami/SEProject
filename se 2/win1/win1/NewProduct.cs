using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace win1
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProduct NP = new NewProduct();
            NP.Show();
        }

        private void FinalizeProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F = new Form2();
            F.Show();
        }

      

       
        
    }
}
