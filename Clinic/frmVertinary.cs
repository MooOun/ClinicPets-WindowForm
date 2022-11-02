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
using ProjectMiniZoo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic
{
    public partial class frmVertinary : Form
    {
        public frmVertinary()
        {
            InitializeComponent();
        }

        // ตัวแปรการเชื่อมต่อ 
        SqlConnection conn;
        private void frmVertinary_Load(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
            ClearForm();
            ShowData();
            txtPosition.Text = "Veterinary";

        }

        private void ShowData()
        {
            string sql = "select * from Veterinarys";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgVeterinary.DataSource = ds.Tables[0];
        }

        private void ClearForm()
        {
            txtVeterID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtTitle.Text = "";
            txtVeterAddress.Text = "";
            txtVeterExp.Text = "";
            txtVeterPassword.Text = "";
            txtVeterPasswordConfirm.Text = "";
            txtVeterTel.Text = "";
            txtVeterUsername.Text = "";
        }
        private void dvgVeterinary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.Value != null)
            {
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }
        private void dvgVeterinary_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = dvgVeterinary.CurrentRow.Cells;
            txtVeterID.Text = x["VeterrinaryID"].Value.ToString();
            txtTitle.Text = x["Title"].Value.ToString();
            txtFirstname.Text = x["FirstName"].Value.ToString();
            txtLastname.Text = x["LastName"].Value.ToString();
            txtPosition.Text = x["Position"].Value.ToString();
            txtVeterAddress.Text = x["Address"].Value.ToString();
            txtVeterExp.Text = x["VetExp"].Value.ToString();
            txtVeterTel.Text = x["Tel"].Value.ToString();
            txtVeterUsername.Text = x["UserName"].Value.ToString();
            txtVeterPassword.Text = x["Password"].Value.ToString();
            txtVeterPasswordConfirm.Text = x["Password"].Value.ToString();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkInputVeterinary("Insert") == false)
            {
                return;
            }
            SqlCommand comm = new SqlCommand("InsertVeterinary", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
            comm.Parameters.AddWithValue("@FirstName", txtFirstname.Text.Trim());
            comm.Parameters.AddWithValue("@LastName", txtLastname.Text.Trim());
            comm.Parameters.AddWithValue("@Position", txtPosition.Text.Trim());
            comm.Parameters.AddWithValue("@Address", txtVeterAddress.Text.Trim());
            comm.Parameters.AddWithValue("@Tel", txtVeterTel.Text.Trim());
            comm.Parameters.AddWithValue("@VetExp", txtVeterExp.Text.Trim());
            comm.Parameters.AddWithValue("@Username", txtVeterUsername.Text.Trim());
            comm.Parameters.AddWithValue("@Password", txtVeterPassword.Text.Trim());

            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearForm();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Insert Veterinary has Something Wrong" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Somthing Wrong");
            }
            conn.Close();
        }

        private bool checkInputVeterinary(string Status)
        {
            // ตรวจห้ามเป็นที่ว่าง
            if (String.IsNullOrEmpty(txtFirstname.Text.Trim()))
            {
                MessageBox.Show("Please Insert Your Name", "Somthing Wrong");
                return false;
            }
            if (String.IsNullOrEmpty(txtVeterAddress.Text.Trim()))
            {
                MessageBox.Show("Please Insert Address", "Somthing Wrong");
                return false;
            }
            if (String.IsNullOrEmpty(txtVeterUsername.Text.Trim()))
            {
                MessageBox.Show("Please Insert Username", "Somthing Wrong");
                return false;
            }
            //------------------------------------------------------
            // ตรวจรหัสผ่านห้ามซ้ำ
            if (txtVeterPassword.Text != txtVeterPasswordConfirm.Text)
            {
                MessageBox.Show("Please Check Your Password", "Somthing Wrong");
                return false;
            }
            //String sql = "select count(*) n_user from Veterinarys where username = @username";
            //SqlCommand comm = new SqlCommand(sql, conn);
            //comm.Parameters.AddWithValue("@username", txtVeterUsername.Text);
            //conn.Open();
            //int n = Convert.ToInt16(comm.ExecuteScalar());
            //conn.Close();
            //if (n > 0)
            //{
            //    MessageBox.Show("Already User", "Somthing Wrong");
            //    return false;
            //}
            //if (String.IsNullOrEmpty(txtVeterUsername.Text))
            //{
            //    MessageBox.Show("Please Insert Username", "Somthing Wrong");
            //    return false;
            //}
            string sql = "";

            if (Status == "Insert")
            {
                sql = "select count(*) n_user from Veterinarys where username = @username";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@username", txtVeterUsername.Text);
                conn.Open();
                int n = Convert.ToInt16(comm.ExecuteScalar());
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Already User", "Something Wrong !!");
                    return false;
                }
                if (String.IsNullOrEmpty(txtVeterUsername.Text))
                {
                    MessageBox.Show("Please Insert Username", "Something Wrong !!"); //ว่างไม่ได้
                    return false;
                }

            }
            if (Status == "Update") // Update ข้อมูล
            {
                sql = "select count(*) n_user from Veterinarys where username = @username and veterrinaryID != @veterrinaryID";
                //ถ้านับusername ที่ไม่ใช้รหัสของตัวเอง แล้วได้มากกว่า 0 แสดงว่่าUsername ซั้า
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@username", txtVeterUsername.Text);
                comm.Parameters.AddWithValue("@veterrinaryID", txtVeterID.Text);
                conn.Open();

                int n = Convert.ToInt16(comm.ExecuteScalar());
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Already User", "Something Wrong !!");
                    return false;
                }
                if (String.IsNullOrEmpty(txtVeterUsername.Text))
                {
                    MessageBox.Show("Please Insert Username", "Something Wrong !!"); //ว่างไม่ได้
                    return false;
                }
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (checkInputVeterinary("Update") == false)
            {
                return;
            }
            SqlCommand comm = new SqlCommand("UpdateVeterinary", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@VeterrinaryID", txtVeterID.Text);
            comm.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
            comm.Parameters.AddWithValue("@FirstName", txtFirstname.Text.Trim());
            comm.Parameters.AddWithValue("@LastName", txtLastname.Text.Trim());
            comm.Parameters.AddWithValue("@Address", txtVeterAddress.Text.Trim());
            comm.Parameters.AddWithValue("@Tel", txtVeterTel.Text.Trim());
            comm.Parameters.AddWithValue("@VetExp", txtVeterExp.Text.Trim());
            comm.Parameters.AddWithValue("@Username", txtVeterUsername.Text.Trim());
            comm.Parameters.AddWithValue("@Password", txtVeterPassword.Text.Trim());
            comm.Parameters.AddWithValue("@Position", txtPosition.Text.Trim());
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                ClearForm();
                ShowData();
            }
            catch (Exception ex)
            {
                String msg = "Update Veterinary has Something Wrong" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Something Wrong !!");
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบก่อนลบ 
            if (txtVeterID.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose Veterinary For Delete", "Something Wrong !!");
                return;
            }

            //ยืนยันการลบ 
            if (MessageBox.Show("Delete Veterinary ? ", "Confrim", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            SqlCommand comm = new SqlCommand("DeleteVeterinary", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@VeterrinaryID", txtVeterID.Text);
            conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = "Somthing Wrong IN Database" + Environment.NewLine + ex.Message;
                MessageBox.Show(msg, "Can't Delete Veterinary !");

            }

            conn.Close();

            ShowData();
            ClearForm();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

     
    }
}
