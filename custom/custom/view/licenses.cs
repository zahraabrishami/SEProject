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
    public partial class licenses : Form
    {
        public licenses(List<string> licenseNames)
        {
            InitializeComponent();
            foreach (string l in licenseNames)
            {

                string[] row = new string[1];
                row[0] = l;
                dataGridViewLicenses.Rows.Add(row);
            }
        }
    }
}
