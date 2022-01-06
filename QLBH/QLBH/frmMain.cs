using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void AddForm(Form s)
        {
            this.picLogo.Controls.Clear();
            s.TopLevel = false;
            s.AutoScroll = true;
            s.FormBorderStyle = FormBorderStyle.None;
            s.Dock = DockStyle.Fill;
            this.picLogo.Controls.Add(s);
            s.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWarehouse warehouse = new frmWarehouse();
            AddForm(warehouse);
        }

        private void shippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShipping shipping = new frmShipping();
            AddForm(shipping);
        }

        private void AcceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccept accept = new frmAccept();
            AddForm(accept);
        }

        private void createOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreateOrder creOrder = new frmCreateOrder();
            AddForm(creOrder);
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistic statistic = new frmStatistic();
            AddForm(statistic);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport import = new frmImport();
            AddForm(import);
        }
    }
}
