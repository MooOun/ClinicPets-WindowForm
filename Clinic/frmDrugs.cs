using ProjectMiniZoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmDrugs : Form
    {
        public frmDrugs()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void frmDrugs_Load(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
            setcboCompanyName();
            ShowData();
            ClearData();
        }

        private void setcboCompanyName()
        {
            String sql = "select DealerID , CompanyName from Dealer ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboCompanyDealer.DataSource = ds.Tables[0];
            cboCompanyDealer.DisplayMember = "CompanyName"; //เเสดงชื่อหมวดหมู่สินค้า
            cboCompanyDealer.ValueMember = "DealerID"; //ค่าที่เก็บใน DB
            cboCompanyDealer.SelectedItem = null;
            cboCompanyDealer.SelectedText = "- Choose Dealer -";
        }

        private void ClearData()
        {
            txtDrugID.Text = "";
            txtDrugName.Text = "";
            txtPriceDrug.Text = "";
            txtQuantityDrug.Text = "";
            txtSizeDrug.Text = "";
            setcboCompanyName();

        }

        private void ShowData()
        {
            string sql = "select * from Drug";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgDrug.DataSource = ds.Tables[0];
        }

        private void dvgDrug_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = dvgDrug.CurrentRow.Cells;
            txtDrugID.Text = x["DrugID"].Value.ToString();
            txtDrugName.Text = x["DrugName"].Value.ToString();
            txtQuantityDrug.Text = x["Quantity"].Value.ToString();
            txtPriceDrug.Text = x["UnitPrice"].Value.ToString();
            txtSizeDrug.Text = x["Size"].Value.ToString();
            cboCompanyDealer.SelectedValue = x["DealerID"].Value.ToString();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckInPutDrug();
            SqlCommand comm = new SqlCommand("InsertDrug", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@DrugName", txtDrugName.Text.Trim());
            comm.Parameters.AddWithValue("@UnitPrice", txtPriceDrug.Text.Trim());
            comm.Parameters.AddWithValue("@Quantity", txtQuantityDrug.Text);
            comm.Parameters.AddWithValue("@Size", txtSizeDrug.Text);
            comm.Parameters.AddWithValue("DealerID", cboCompanyDealer.SelectedValue);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Insert Drug Has Something Wrong" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private bool CheckInPutDrug()
        {
            if ( txtDrugName.Text.Trim() == "")
            {
                string msg = "Please Check Drug Name (Not Null)";
                MessageBox.Show(msg, "Something Wrong !!");
                return false;
            }
            //Check Price and Quantity
            double x = 0.0;
            if (double.TryParse(txtPriceDrug.Text, out x) == false)
            {
                string msg = "Please Check UnitPrice (Format to Float)";
                MessageBox.Show(msg, "Something Wrong !!");
                return false;
            }
            int y = 0;
            if (int.TryParse(txtQuantityDrug.Text, out y) == false)
            {
                string msg = "Please Check Quantity (Format to Int)";
                MessageBox.Show(msg, "Something Wrong !!");
                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDrugID.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose Drug to Delete", "Something Wrong !!");
                return;
            }
            if (MessageBox.Show("Delete This Drug ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // Delete 
            SqlCommand comm = new SqlCommand("DeleteDrug", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@DrugID", txtDrugID.Text.ToString());
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Delete Data has Ploblem" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInPutDrug())
            {
                return;
            }
            // update
            SqlCommand comm = new SqlCommand("UpdateDrug", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@DrugID", txtDrugID.Text.Trim());
            comm.Parameters.AddWithValue("@DrugName", txtDrugName.Text.Trim());
            comm.Parameters.AddWithValue("@UnitPrice", txtPriceDrug.Text);
            comm.Parameters.AddWithValue("@Quantity", txtQuantityDrug.Text);
            comm.Parameters.AddWithValue("@Size", txtSizeDrug.Text);
            comm.Parameters.AddWithValue("DealerID", cboCompanyDealer.SelectedValue);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Update Drug has Somthing Wrong !!" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
