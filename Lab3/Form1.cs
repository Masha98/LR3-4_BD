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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goods newForm = new Goods();
            newForm.Show();

        }

        private void orderGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goods_Order newForm = new Goods_Order();
            newForm.Show();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider newForm = new Provider();
            newForm.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order newForm = new Order();
            newForm.Show();
        }

        private void orderProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Provider newForm = new Order_Provider();
            newForm.Show();
        }
    }
}
