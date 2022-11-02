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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public int VeterID { get; set; }
        public string VeterName { get; set; }
        public string position { get; set; }
        public string userName { get; set; }
        // Conection
        SqlConnection conn;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new ConnectDB().SqlStrCon();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "select VeterrinaryID , Title , FirstName+SPACE(2)+LastName VeterName, Username , Position " +
                         " from Veterinarys" +
                         " where username = @username and Password = @password";
            SqlCommand comn = new SqlCommand(sql, conn);
            comn.Parameters.AddWithValue("@username", txtUsername.Text);
            comn.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataAdapter da = new SqlDataAdapter(comn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                VeterID = Convert.ToInt32(ds.Tables[0].Rows[0]["VeterrinaryID"]);
                VeterName = ds.Tables[0].Rows[0]["VeterName"].ToString();
                position = ds.Tables[0].Rows[0]["position"].ToString();
                userName = ds.Tables[0].Rows[0]["username"].ToString();
                MessageBox.Show("Veterinary ID : " + VeterID + " " + "Name : " + VeterName + " ", "WelCome To 106 Clinic");
                this.Close();
            }
            else 
            {
                MessageBox.Show("Access is Denied", "Something Wrong");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ปุ่ม Cancel
            VeterID = 0;
            VeterName = "";
            userName = "";
            this.Close();
        }
    }
}
