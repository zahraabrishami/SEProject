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
    public partial class ExpertPanel : Form
    {
        public ExpertPanel()
        {
            InitializeComponent();
        }

        private void ExpertPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeclarationInfo DI = new DeclarationInfo();
            DI.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           // this.Text = LoginPanel.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }   
    }
}
