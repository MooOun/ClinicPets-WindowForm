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
    public partial class frmDealers : Form
    {
        public frmDealers()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void frmDealers_Load(object sender, EventArgs e)
        {
            
        }
        private void frmDealers_Load_1(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
            ShowData();
            ClearData();
        }

        private void ClearData()
        {
            txtDealerID.Text = "";
            txtDealerCompany.Text = "";
            txtDealerTel.Text = "";
            txtEmpName.Text = "";
        }

        private void ShowData()
        {
            string sql = "select * from Dealer";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgDealer.DataSource = ds.Tables[0];
        }

        private void dvgDealer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = dvgDealer.CurrentRow.Cells;
            txtDealerID.Text = x["DealerID"].Value.ToString();
            txtEmpName.Text = x["EmpName"].Value.ToString();
            txtDealerCompany.Text = x["CompanyName"].Value.ToString();
            txtDealerTel.Text = x["Tel"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CheckInputDrugDealer() == false)
            {
                return;
            }
            CheckInputDrugDealer();
            SqlCommand comm = new SqlCommand("InsertDrugDealer", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
            comm.Parameters.AddWithValue("@CompanyName", txtDealerCompany.Text.Trim());
            comm.Parameters.AddWithValue("@Tel", txtDealerTel.Text.Trim());
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Insert DealerDrug Has Something Wrong !!" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบก่อนลบ 
            if (txtDealerID.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose DealerDrug For Delete", "Something Wrong !!");
                return;
            }

            //ยืนยันการลบ 
            if (MessageBox.Show("Delete this Dealer ? ", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            SqlCommand comm = new SqlCommand("DeleteDrugDealer", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@DealerID", txtDealerID.Text);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = "Has Ploblem In Datebase" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Can't Delete this data !");

            }

            conn.Close();

            ShowData();
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInputDrugDealer() == false)
            {
                return;
            }
            CheckInputDrugDealer();
            SqlCommand comm = new SqlCommand("UpdateDrugDealer", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@DealerID", txtDealerID.Text.Trim());
            comm.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
            comm.Parameters.AddWithValue("@CompanyName", txtDealerCompany.Text.Trim());
            comm.Parameters.AddWithValue("@Tel", txtDealerTel.Text.Trim());
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Update DrugDealer Has Somthing Wrong !!" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private bool CheckInputDrugDealer()
        {
            // ตรวจห้ามเป็นที่ว่าง
            if (String.IsNullOrEmpty(txtEmpName.Text.Trim()))
            {
                MessageBox.Show("Please Insert DealerName", "Something Wrong !!");
                return false;
            }
            if (String.IsNullOrEmpty(txtDealerCompany.Text.Trim()))
            {
                MessageBox.Show("Please Insert DealerComany", "Something Wrong !!");
                return false;
            }
            if (String.IsNullOrEmpty(txtDealerTel.Text.Trim()))
            {
                MessageBox.Show("Please Insert DealerPhone", "Something Wrong !!");
                return false;
            }
            
            // ตรวจ Username ห้ามซ้ำ
            String sql = "select count(*) n_user from Dealer where CompanyName = @CompanyName";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@CompanyName", txtDealerCompany.Text);
            conn.Open();
            int n = Convert.ToInt16(comm.ExecuteScalar());
            conn.Close();
            if (n > 0)
            {
                MessageBox.Show("Already DrugDealerCompany", "Something Wrong !!");
                return false;
            }
            if (String.IsNullOrEmpty(txtDealerCompany.Text))
            {
                MessageBox.Show("Already DrugDealerCompany", "Something Wrong !!");
                return false;
            }

            return true;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
