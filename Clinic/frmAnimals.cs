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
using System.Windows.Forms.VisualStyles;

namespace Clinic
{
    public partial class frmAnimals : Form
    {
        public frmAnimals()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void frmAnimals_Load(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
            setCustomerName();
            ShowData();
            ClearData();
        }

        private void setCustomerName()
        {
            String sql = "select CustomerID , CustomerName from Customers ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboCustomer.DataSource = ds.Tables[0];
            cboCustomer.DisplayMember = "CustomerName"; //เเสดงชื่อหมวดหมู่สินค้า
            cboCustomer.ValueMember = "CustomerID"; //ค่าที่เก็บใน DB
            cboCustomer.SelectedItem = null;
            cboCustomer.SelectedText = "-- Customer Name --";

        }

        private void ClearData()
        {
            txtAnimalAge.Text = "";
            txtAnimalName.Text = "";
            txtAnimalColor.Text = "";
            txtAnimalDes.Text = "";
            txtAnimalID.Text = "";
            txtAnimalSpecies.Text = "";
            txtCustomerID.Text = "";
            txtType.Text = "";
            setCustomerName();
        }

        private void ShowData()
        {
            string sql = "select * from Pets";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgAnimals.DataSource = ds.Tables[0];
        }

        private void dvgAnimals_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = dvgAnimals.CurrentRow.Cells;
            txtAnimalID.Text = x["PetID"].Value.ToString();
            txtAnimalName.Text = x["PetName"].Value.ToString();
            txtType.Text = x["AnimalType"].Value.ToString();
            txtAnimalSpecies.Text = x["Species"].Value.ToString();
            txtAnimalDes.Text = x["Description"].Value.ToString();
            txtAnimalColor.Text = x["Color"].Value.ToString();
            txtAnimalAge.Text = x["Age"].Value.ToString();
            txtCustomerID.Text = x["CustomerID"].Value.ToString();
            cboCustomer.SelectedValue = x["CustomerID"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckInputAnimals();
            SqlCommand comm = new SqlCommand("InsertPets", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@PetName", txtAnimalName.Text.Trim());
            comm.Parameters.AddWithValue("@AnimalType", txtType.Text.Trim());
            comm.Parameters.AddWithValue("@Age", txtAnimalAge.Text);
            comm.Parameters.AddWithValue("@Color", txtAnimalColor.Text);
            comm.Parameters.AddWithValue("@Description", txtAnimalDes.Text);
            comm.Parameters.AddWithValue("@Species", txtAnimalSpecies.Text);
            comm.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Insert Animal Has Ploblem" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private bool CheckInputAnimals()
        {
            if (String.IsNullOrEmpty(txtAnimalName.Text.Trim()))
            {
                MessageBox.Show("Please Insert AnimalName", "Something Wrong !!");
                return false;
            }
            if (String.IsNullOrEmpty(txtType.Text.Trim()))
            {
                MessageBox.Show("Please Insert AnimalType", "Something Wrong !!");
                return false;
            }
            if (String.IsNullOrEmpty(txtAnimalSpecies.Text.Trim()))
            {
                MessageBox.Show("Please Insert AnimalSpecies", "Something Wrong !!");
                return false;
            }
           
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAnimalID.Text.Trim() == "")
            {
                MessageBox.Show("Plsase Choose Animal To Delete !", "Something Wrong !!");
                return;
            }

            if (MessageBox.Show("Delete this Animals ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // Delete 
            SqlCommand comm = new SqlCommand("DeletePets", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@PetID", txtAnimalID.Text.ToString());
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Delete Data Has Ploblem !!" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInputAnimals())
            {
                return;
            }
            // update
            SqlCommand comm = new SqlCommand("UpdatePets", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@PetID", txtAnimalID.Text.Trim());
            comm.Parameters.AddWithValue("@PetName", txtAnimalName.Text.Trim());
            comm.Parameters.AddWithValue("@AnimalType", txtType.Text.Trim());
            comm.Parameters.AddWithValue("@Age", txtAnimalAge.Text);
            comm.Parameters.AddWithValue("@Color", txtAnimalColor.Text);
            comm.Parameters.AddWithValue("@Description", txtAnimalDes.Text);
            comm.Parameters.AddWithValue("@Species", txtAnimalSpecies.Text);
            comm.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearData();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Update Animal Has Ploblem !!" + Environment.NewLine + ex.Message;
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
