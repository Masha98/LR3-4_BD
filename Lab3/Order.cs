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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            dataSet11.Clear();
            sqlDataAdapter1.Fill(dataSet11);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.InsertCommand.Parameters[0].Value = Convert.ToInt32(txtAmount.Text);
            sqlDataAdapter1.InsertCommand.Parameters[1].Value = Convert.ToInt32(txtUnitPrice.Text);
            sqlDataAdapter1.InsertCommand.Parameters[2].Value = txtDate.Text;
            sqlDataAdapter1.InsertCommand.Parameters[3].Value = Convert.ToInt32(txtGoodsCode.Text);
            sqlDataAdapter1.InsertCommand.Parameters[4].Value = Convert.ToInt32(txtProviderNumber.Text);
            sqlConnection1.Open();
            sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
            sqlConnection1.Close();
            dataSet11.Clear();
            sqlDataAdapter1.Fill(dataSet11);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet11);
            MessageBox.Show("Update OK");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.DeleteCommand.Parameters[0].Value = txtDate.Text;
            sqlConnection1.Open();
            sqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
            sqlConnection1.Close();
            dataSet11.Clear();
            sqlDataAdapter1.Fill(dataSet11, "Supply");
        }
    }
}
