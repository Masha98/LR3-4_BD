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
    public partial class Order_Provider : Form
    {
        public Order_Provider()
        {
            InitializeComponent();
            dataSet2.Clear();
            sqlDataAdapter1.Fill(dataSet2);
            sqlDataAdapter2.Fill(dataSet2);
            dataGridView1.AllowUserToAddRows = false;
        }


    }
}
