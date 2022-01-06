using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBH
{
    public partial class frmCreateOrder : Form
    {
        public frmCreateOrder()
        {
            InitializeComponent();

            tbCreateOrder.ColumnCount = 4;
            tbCreateOrder.Columns[0].Name = "ID";
            tbCreateOrder.Columns[1].Name = "Phone number";
            tbCreateOrder.Columns[2].Name = "Buy date";
            tbCreateOrder.Columns[3].Name = "Total";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=BOURBON;Initial Catalog=Data_QL;Integrated Security=True");
            for (int i = 0; i < tbCreateOrder.Rows.Count - 1; i++)
            {
                SqlCommand md = new SqlCommand(@"INSERT INTO Export (ID, Phone, Buy_date, Total) VALUES ('"+ tbCreateOrder.Rows[i].Cells[0].Value +"', '"+ tbCreateOrder.Rows[i].Cells[1].Value +"', '"+ tbCreateOrder.Rows[i].Cells[2].Value +"', '"+ tbCreateOrder.Rows[i].Cells[3].Value +"')", con);
                con.Open();
                md.ExecuteNonQuery();
                con.Close();
            }

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getData(txtID.Text, txtPhone.Text, dateTimePicker.Text, txtTotal.Text);

            txtID.Text = "";
            txtPhone.Text = "";
            txtTotal.Text = "";

            tbCreateOrder.ClearSelection();
            txtID.Focus();
            btnDelete.Enabled = false;
        }

        private void getData(string ID, string Phone, string dateTime, string Total)
        {
            String[] row = { ID, Phone, dateTime, Total };
            tbCreateOrder.Rows.Add(row);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int SelectedRows;
            SelectedRows = tbCreateOrder.CurrentCell.RowIndex;
            tbCreateOrder.Rows.RemoveAt(SelectedRows);

            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void tbCreateOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.tbCreateOrder.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtPhone.Text = row.Cells[1].Value.ToString();
            dateTimePicker.Text = row.Cells[2].Value.ToString();
            txtTotal.Text = row.Cells[3].Value.ToString();

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
        }
    }
}
