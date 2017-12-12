using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.SelectCommand.Parameters[0].Value = txtTitle.Text;
            dataSet11.Clear();
            sqlDataAdapter1.Fill(dataSet11);
        }
    }
}
