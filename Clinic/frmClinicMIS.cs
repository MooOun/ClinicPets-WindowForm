using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmClinicMIS : Form
    {
        public frmClinicMIS()
        {
            InitializeComponent();
        }
        public int VeterID { get; set; }
        public string VeterName { get; set; }
        public string position { get; set; }
        public string userName { get; set; }

        private void frmClinicMIS_Load(object sender, EventArgs e)
        {
            ShowMenu(true, false); // เลือกให้เเสดงเมนูเเรก
        }
        private void ShowMenu(bool menu_Login, bool menu_Veter)
        {
            mnuLogin.Visible = menu_Login;
            mnuVeter.Visible = menu_Veter;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // จบการทำงาน
        }

        private void mnuLoginForm_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.VeterID = f.VeterID;
            this.VeterName = f.VeterName;
            this.position = f.position;
            this.userName = f.userName;

            if (userName == "")
            {
                ShowMenu(true, false);
                return;
            }
            if (userName != "")
            {
                ShowMenu(false, true);
                String msg = " Name : " + VeterName + " Position : " + position;
                this.Text += " ::: " + msg;
                MessageBox.Show("Welcome To 106 Clinic", "106 Clinic");
            }
            
        }

        private void mnuVeterLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LogOut();
        }
        private void LogOut()
        {
            VeterID = 0;
            VeterName = "";
            position = "";
            userName = "";
            ShowMenu(true, false);
            this.Text = "Clinic 106";
        }
        private void mnuCure_Click(object sender, EventArgs e)
        {
            frmTreatment frm = new frmTreatment();
            frm.MdiParent = this;
            frm.VeterID = VeterID;
            frm.VeterName = VeterName;
            frm.position = position;
            frm.userName = userName;
            frm.Show();
        }

        private void mnuAnimal_Click(object sender, EventArgs e)
        {
            frmAnimals frm = new frmAnimals();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuVet_Click(object sender, EventArgs e)
        {
            frmVertinary frm = new frmVertinary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnudrug_Click(object sender, EventArgs e)
        {
            frmDrugs frm = new frmDrugs();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDealers_Click(object sender, EventArgs e)
        {
            frmDealers frm = new frmDealers();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
