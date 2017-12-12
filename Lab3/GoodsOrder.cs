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
    public partial class Goods_Order : Form
    {
        public Goods_Order()
        {
            InitializeComponent();
        }

        private void Goods_Order_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet31, "Goods");
            sqlDataAdapter2.Fill(dataSet31,"Supply");
            sqlConnection1.Close();
            dataSet31.Relations.Add("Something", dataSet31.Tables["Goods"].Columns["code"], dataSet31.Tables["Supply"].Columns["goodsCode"]);
            dataGridView1.DataSource = dataSet31;
            dataGridView1.DataMember = "Goods";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
