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

namespace QLBH
{
    public partial class frmWarehouse : Form
    {
        public frmWarehouse()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=BOURBON;Initial Catalog=Data_QL;Integrated Security=True");
        string connectionString = @"Data Source=BOURBON;Initial Catalog=Data_QL;Integrated Security=True";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = tbWarehouse.CurrentCell.RowIndex;
            tbWarehouse.Rows.RemoveAt(selectedRow);
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand(@"INSERT INTO [Remaining] SELECT Type_Code, SUM (Amount) AS Remaining FROM Import GROUP BY Type_Code", con);
            //SqlCommand cm = new SqlCommand(@"INSERT INTO [Temp_Imp] SELECT Name_Car, Price FROM Import", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //cm.ExecuteNonQuery();
            //con.Close();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Remaining", sqlCon);
                DataTable dtbl = new DataTable();
                SqlDa.Fill(dtbl);
                tbWarehouse.DataSource = dtbl;
            }
        }
    }
}
