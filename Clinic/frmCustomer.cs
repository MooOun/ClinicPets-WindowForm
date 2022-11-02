using ProjectMiniZoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        String oldCustomerID = String.Empty;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
            ShowData();
            ClearData();
            Showanimal();
        }

        private void ShowData()
        {
            string sql = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgCustomer.DataSource = ds.Tables[0];
        }

        private void ClearData()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerTel.Text = "";
            oldCustomerID = "";
            Showanimal();
        }
        private void dvgCustomer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = dvgCustomer.CurrentRow.Cells;
            txtCustomerID.Text = x["CustomerID"].Value.ToString();
            txtCustomerName.Text = x["CustomerName"].Value.ToString();
            txtCustomerAddress.Text = x["Address"].Value.ToString();
            txtCustomerTel.Text = x["Tel"].Value.ToString();
            oldCustomerID = x["CustomerID"].Value.ToString();
        }
        private void Showanimal()
        {
            string sql = "select PetID , PetName ,AnimalType, Color, Age ,Species ,CustomerID from Pets";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvAnimals.DataSource = ds.Tables[0];
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CheckInPutCustoemr() == false)
            {
                return;
            }
            CheckInPutCustoemr();
            SqlCommand comm = new SqlCommand("InsertCustomers", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
            comm.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
            comm.Parameters.AddWithValue("@Address", txtCustomerAddress.Text.Trim());
            comm.Parameters.AddWithValue("@Tel", txtCustomerTel.Text);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Insert Customer Has Ploblem" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private bool CheckInPutCustoemr()
        {
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("Please Insert Customer Name", "Something Wrong !!");
                return false;
            }
            if (String.IsNullOrEmpty(txtCustomerTel.Text.Trim()))
            {
                MessageBox.Show("Please Insert Customer Phone", "Something Wrong !!");
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose Customer For Delete", "Something Wrong !!");
                return;
            }

            if (MessageBox.Show("Delete This Customer ?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // Delete 
            SqlCommand comm = new SqlCommand("DeleteCustomers", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CustomerID", oldCustomerID);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Delete Data Has Ploblem" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInPutCustoemr())
            {
                return;
            }
            // update
            SqlCommand comm = new SqlCommand("UpdateCustomers", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CustomerID", oldCustomerID);
            comm.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
            comm.Parameters.AddWithValue("@Address", txtCustomerAddress.Text.Trim());
            comm.Parameters.AddWithValue("@Tel", txtCustomerTel.Text);
            comm.Parameters.AddWithValue("@NewCustomerID", txtCustomerID.Text);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Update Customer Has Ploblem" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            (dgvAnimals.DataSource as DataTable).DefaultView.RowFilter =
              string.Format("CustomerID LIKE '{0}%' OR CustomerID LIKE '% {0}%'", txtCustomerID.Text);
        }
    }
}