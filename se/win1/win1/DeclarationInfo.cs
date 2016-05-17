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
    public partial class DeclarationInfo : Form
    {
        public DeclarationInfo()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProduct NP = new NewProduct();
            NP.Show();
        }

        

     

    
    
    }
}
