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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic
{
    public partial class frmTreatment : Form
    {
        public frmTreatment()
        {
            InitializeComponent();
        }
        public int VeterID { get; set; }
        public string VeterName { get; set; }
        public string position { get; set; }
        public string userName { get; set; }

        SqlConnection conn;
        SqlTransaction tr;
        
        private void frmCures_Load(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
            ListViewFormat();
            ClearProductData();
            txtVeterID.Text = this.VeterID.ToString();
            txtVeterName.Text = this.VeterName;
            txtCureDate.Text = DateTime.Now.ToString("dd MMMM,yyyy");
        }
        private void CalculateTotal() //คำนวนราคารวม
        {
            double total = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text);
            txtTotalprice.Text = total.ToString("#,##0.00");
            txtDrugID.Focus();
            txtDrugID.SelectAll();
        }
        private void CalculateNetPrice() //คำนวนราคารวมทั้งหมด 
        {
            double tmpNetPrice = 0.0;
            double totalprice = 0.0;
            for (int i = 0; i <= lsvCure.Items.Count - 1; i++)
            {
                tmpNetPrice += Convert.ToDouble(lsvCure.Items[i].SubItems[4].Text);
            }
            totalprice += tmpNetPrice + Convert.ToDouble(txtCurePrice.Text);
            IbNetPrice.Text = totalprice.ToString("#,##0.00");
        }
        private void CalculateDrugPrice() //คำนวนราคารวมทั้งหมด 
        {
            double tmpNetPrice = 0.0;
            for (int i = 0; i <= lsvCure.Items.Count - 1; i++)
            {
                tmpNetPrice += Convert.ToDouble(lsvCure.Items[i].SubItems[4].Text);
            }
            IbtotaldrugPrice.Text = tmpNetPrice.ToString("#,##0.00");
        }

        private void ListViewFormat()
        {
            lsvCure.Columns.Add("DrugID", 70, HorizontalAlignment.Left);
            lsvCure.Columns.Add("DrugName", 120, HorizontalAlignment.Left);
            lsvCure.Columns.Add("UnitPrice", 100, HorizontalAlignment.Left);
            lsvCure.Columns.Add("Quantity",100, HorizontalAlignment.Left);
            lsvCure.Columns.Add("TotalPrice", 100, HorizontalAlignment.Left);
            lsvCure.View = View.Details;
            lsvCure.GridLines = true;
            lsvCure.FullRowSelect = true;
        }
        private void ClearProductData()
        {
            txtDrugID.Text = "";
            txtDrugName.Text = "";
            txtPrice.Text = "0";
            txtQuantity.Text = "1";
            txtTotalprice.Text = "0.00";
        }
  
        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "")
            {
                txtQuantity.Text = "1";
            }
            if (Convert.ToInt16(txtQuantity.Text) == 0)
            {
                txtQuantity.Text = "1";
            }
            CalculateTotal();
            CalculateDrugPrice();
        }
        private void txtAnimalID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "select PetID , PetName , c.CustomerName" +
                             " from Pets p join Customers c on p.CustomerID = c.CustomerID" +
                             " where PetID = @PetID";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@PetID", txtAnimalID.Text);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtAnimalID.Text = dt.Rows[0][0].ToString();
                    txtAnimalName.Text = dt.Rows[0][1].ToString();
                    txtCustomerName.Text = dt.Rows[0][2].ToString();
                    txtAnimalID.Focus();
                    txtAnimalID.SelectAll();
                }
                else
                {
                    MessageBox.Show("No have Animal in this ID", "Something Wrong !!");
                    ClearProductData();

                }

                txtAnimalID.Focus();
                txtAnimalID.SelectAll();
                dr.Close();
                conn.Close();
            }
        }
        private void txtDrugID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "select DrugID , DrugName ,UnitPrice , Quantity " +
                             " from Drug where DrugID = @DrugID";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@DrugID", txtDrugID.Text);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        txtDrugID.Text = dt.Rows[0][0].ToString();
                        txtDrugName.Text = dt.Rows[0][1].ToString();
                        txtPrice.Text = dt.Rows[0][2].ToString();
                        CalculateTotal();
                        CalculateDrugPrice();
                        txtDrugID.Focus();
                        txtDrugID.SelectAll();
                    }
                    else
                    {
                        MessageBox.Show("No Have Drug in This ID", "Something Wrong !!");
                        ClearProductData();

                    }

                txtDrugID.Focus();
                txtDrugID.SelectAll();
                dr.Close();
                conn.Close();
            }
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDrugID.Text.Trim() == "" || txtDrugName.Text.Trim() == "")
            {
                txtDrugID.Focus();
                txtDrugID.SelectAll();
                return;
            }
            if (Convert.ToInt16(txtQuantity.Text) == 0)
            {
                txtDrugID.Focus();
                txtDrugID.SelectAll();
                return;
            }
            ListViewItem lvi;
            String tmpProductID = "";
            for (int i = 0; i <= lsvCure.Items.Count - 1; i++)
            {
                tmpProductID = lsvCure.Items[i].SubItems[0].Text;
                if (txtDrugID.Text == tmpProductID)
                {
                    int qty = Convert.ToInt16(lsvCure.Items[i].SubItems[3].Text)
                            + Convert.ToInt16(txtQuantity.Text);
                    double newTotal = Convert.ToDouble(lsvCure.Items[i].SubItems[4].Text)
                                    + Convert.ToDouble(txtTotalprice.Text);
                    lsvCure.Items[i].SubItems[3].Text = qty.ToString();
                    lsvCure.Items[i].SubItems[4].Text = newTotal.ToString("#,##0.00");
                    ClearProductData();
                    CalculateTotal();
                    CalculateDrugPrice();
                    CalculateNetPrice();
                    return;

                }
            }
            String[] anyData;
            anyData = new string[]
            {
                txtDrugID.Text ,
                txtDrugName.Text ,
                txtPrice.Text ,
                txtQuantity.Text ,
                txtTotalprice.Text
            };

            lvi = new ListViewItem(anyData);
            lsvCure.Items.Add(lvi);
            CalculateNetPrice();
            CalculateDrugPrice();
            ClearProductData();
            btnSave.Enabled = true;
            txtDrugID.Focus();
            txtDrugID.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Want To save this Cure ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            int LastOrderID = 0;  //เก็บรหัสที่เพิ่มล่าสุด 

            if (lsvCure.Items.Count > 0)
            {
                //ประกาศเริ่ม transaction 
                conn.Open();
                tr = conn.BeginTransaction();
                //เพิ่มข้อมูล Receipt 
                SqlCommand comm = new SqlCommand("InsertTreatment", conn, tr);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@DateCure", DateTime.Today);
                comm.Parameters.AddWithValue("@Symptom", txtSymptom.Text);
                comm.Parameters.AddWithValue("@Imprement", txtImprement.Text);
                comm.Parameters.AddWithValue("@TreatmentPrice", txtCurePrice.Text);
                comm.Parameters.AddWithValue("@TotalPrice", IbNetPrice.Text);
                comm.Parameters.AddWithValue("@VeterrinaryID", txtVeterID.Text);
                comm.Parameters.AddWithValue("@PetID", txtAnimalID.Text);

                comm.ExecuteNonQuery();

                //อ่านข้อมูล รหัสของ Receipt รายการล่าสุดไว้ในตัวแปร LastOrderID
                String sql = "Select top 1 TreatmentID from Treatment Order by TreatmentID desc";
                SqlCommand comm1 = new SqlCommand(sql, conn, tr);
                SqlDataReader dr = comm1.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    LastOrderID = dr.GetInt32(dr.GetOrdinal("TreatmentID"));
                }
                dr.Close();
                //เพิ่มรายการสินค้าใน DB Detail โดบรหัส LastOrderID
                String ls = "";
                for (int i = 0; i <= lsvCure.Items.Count - 1; i++)
                {
                    SqlCommand comm3 = new SqlCommand("InsertDispenseDrug", conn, tr);
                    comm3.CommandType = CommandType.StoredProcedure;
                    comm3.Parameters.AddWithValue("@TreatmentID", LastOrderID);
                    comm3.Parameters.AddWithValue("@QuantityDrug", lsvCure.Items[i].SubItems[3].Text);
                    comm3.Parameters.AddWithValue("@UnitPrice", lsvCure.Items[i].SubItems[2].Text);
                    comm3.Parameters.AddWithValue("@DrugID", lsvCure.Items[i].SubItems[0].Text);
                    comm3.ExecuteNonQuery();
                }
                tr.Commit();
                conn.Close();
                MessageBox.Show("TreatmentID" + LastOrderID.ToString() + Environment.NewLine
                            + ls
                            + "Total Price" + IbNetPrice.Text);
            }
            txtAnimalID.Text = "";
            txtAnimalName.Text = "";
            txtSymptom.Text = "";
            txtImprement.Text = "";
            txtCurePrice.Text = "";
            txtCustomerName.Text = "";
            IbtotaldrugPrice.Text = "0.00";
            btnCancel.PerformClick(); //คำสั่งให้ยกเลิกปุ่ม btncancel เพื่อเริ่มรายการใหม่
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lsvCure.Clear();
            ClearProductData();
            ListViewFormat();
            IbNetPrice.Text = "0.00";
            IbtotaldrugPrice.Text = "0.00";
            txtAnimalID.Text = "";
            txtAnimalName.Text = "";
            txtSymptom.Text = "";
            txtImprement.Text = "";
            txtCurePrice.Text = "";
            txtCustomerName.Text = "";
            txtDrugID.Focus();
            txtDrugID.SelectAll();
        }

        
    }
}
