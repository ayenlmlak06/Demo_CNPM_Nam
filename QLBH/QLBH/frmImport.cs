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
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();

            tbImport.ColumnCount = 6;
            tbImport.Columns[0].Name = "ID";
            tbImport.Columns[1].Name = "Name";
            tbImport.Columns[2].Name = "Type Code";
            tbImport.Columns[3].Name = "Amount";
            tbImport.Columns[4].Name = "Price";
            tbImport.Columns[5].Name = "Import date";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTypeCode.Text = "";
            txtAmount.Text = "";
            txtPrice.Text = "";

            tbImport.ClearSelection();
            txtID.Focus();
            btnAdd.Enabled = true;
            btnDelete_SI.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnDelete_SI.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnDelete_SI.Enabled = false;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            btnDelete_SI.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addData(txtID.Text, txtName.Text, txtTypeCode.Text, txtAmount.Text, txtPrice.Text, timeImport.Text);

            txtID.Text = "";
            txtName.Text = "";
            txtAmount.Text = "";
            txtPrice.Text = "";
            txtTypeCode.Text = "";

            tbImport.ClearSelection();
            txtID.Focus();
        }
        
        private void addData(string ID, string Name, string TypeCode, string Amount, string Price, string ImpDate)
        {
            String[] row = { ID, Name, TypeCode, Amount, Price, ImpDate };
            tbImport.Rows.Add(row);
        }

        private void btnDelete_SI_Click(object sender, EventArgs e)
        {
            int SelectedRows;
            SelectedRows = tbImport.CurrentCell.RowIndex;
            tbImport.Rows.RemoveAt(SelectedRows);
            
            btnDelete_SI.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtTypeCode_Click(object sender, EventArgs e)
        {
            btnDelete_SI.Enabled = false;
        }

        private void tbImport_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.tbImport.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtTypeCode.Text = row.Cells[2].Value.ToString();
            txtAmount.Text = row.Cells[3].Value.ToString();
            txtPrice.Text = row.Cells[4].Value.ToString();
            timeImport.Text = row.Cells[5].Value.ToString();

            btnAdd.Enabled = false;
            btnDelete_SI.Enabled = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnDelete_SI.Enabled = false;
            btnClear.Enabled = false;

            SqlConnection con = new SqlConnection(@"Data Source=BOURBON;Initial Catalog=Data_QL;Integrated Security=True");
            for(int i = 0; i < tbImport.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Import (ID, Name_Car, Type_Code, Amount, Price, Import_date) VALUES ('" + tbImport.Rows[i].Cells[0].Value +"', '"+ tbImport.Rows[i].Cells[1].Value +"', '"+ tbImport.Rows[i].Cells[2].Value +"', '"+ tbImport.Rows[i].Cells[3].Value +"', '"+ tbImport.Rows[i].Cells[4].Value +"', '"+ tbImport.Rows[i].Cells[5].Value +"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            SqlCommand md = new SqlCommand(@"INSERT INTO [Remaining] SELECT Type_Code, SUM (Amount) AS Remaining FROM Import GROUP BY Type_Code", con);
            SqlCommand cm = new SqlCommand(@"INSERT INTO [Temp_Imp] SELECT Name_Car, Price FROM Import", con);
            con.Open();
            md.ExecuteNonQuery();
            cm.ExecuteNonQuery();
            con.Close();
            //for (int i = 0; i < tbImport.Rows.Count - 1; i++)
            //{
            //    SqlCommand cm = new SqlCommand(@"INSERT INTO Temp_Imp (Name_Car, Price) VALUES ('" + tbImport.Rows[i].Cells[1].Value + "', '" + tbImport.Rows[i].Cells[4].Value + "')", con);
            //    con.Open();
            //    cm.ExecuteNonQuery();
            //    con.Close();
            //}
            //tbImport.Rows.Clear();

            txtID.Text = "";
            txtName.Text = "";
            txtAmount.Text = "";
            txtPrice.Text = "";
            txtTypeCode.Text = "";

            tbImport.ClearSelection();
            txtID.Focus();
        }
    }
}