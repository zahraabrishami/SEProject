using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace view
{
    public partial class products : Form
    {
        public products(List<domain.ProductDescription> pDescriptions)
        {
            InitializeComponent();
            BindingList<domain.ProductDescription> pds = new BindingList<domain.ProductDescription>();
            foreach (domain.ProductDescription pd in pDescriptions)
                pds.Add(pd);
            dataGridViewProducts.DataSource = pds;
        }
    }
}
