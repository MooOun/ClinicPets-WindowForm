namespace Clinic
{
    partial class frmClinicMIS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuLogin = new System.Windows.Forms.MenuStrip();
            this.mnuLoginForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeter = new System.Windows.Forms.MenuStrip();
            this.mnuVet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCure = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudrug = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDealers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeterLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin.SuspendLayout();
            this.mnuVeter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuLogin
            // 
            this.mnuLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mnuLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoginForm,
            this.mnuExit});
            this.mnuLogin.Location = new System.Drawing.Point(0, 28);
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(800, 28);
            this.mnuLogin.TabIndex = 1;
            this.mnuLogin.Text = "menuStrip2";
            // 
            // mnuLoginForm
            // 
            this.mnuLoginForm.Name = "mnuLoginForm";
            this.mnuLoginForm.Size = new System.Drawing.Size(66, 24);
            this.mnuLoginForm.Text = "LOGIN";
            this.mnuLoginForm.Click += new System.EventHandler(this.mnuLoginForm_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(52, 24);
            this.mnuExit.Text = "EXIT";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuVeter
            // 
            this.mnuVeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuVeter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuVeter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVet,
            this.mnuCustomer,
            this.mnuAnimal,
            this.mnuCure,
            this.mnudrug,
            this.mnuDealers,
            this.mnuVeterLogout});
            this.mnuVeter.Location = new System.Drawing.Point(0, 0);
            this.mnuVeter.Name = "mnuVeter";
            this.mnuVeter.Size = new System.Drawing.Size(800, 28);
            this.mnuVeter.TabIndex = 2;
            this.mnuVeter.Text = "menuStrip1";
            // 
            // mnuVet
            // 
            this.mnuVet.Name = "mnuVet";
            this.mnuVet.Size = new System.Drawing.Size(107, 24);
            this.mnuVet.Text = "VETERINARY";
            this.mnuVet.Click += new System.EventHandler(this.mnuVet_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(99, 24);
            this.mnuCustomer.Text = "CUSTOMER";
            this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
            // 
            // mnuAnimal
            // 
            this.mnuAnimal.Name = "mnuAnimal";
            this.mnuAnimal.Size = new System.Drawing.Size(47, 24);
            this.mnuAnimal.Text = "PET";
            this.mnuAnimal.Click += new System.EventHandler(this.mnuAnimal_Click);
            // 
            // mnuCure
            // 
            this.mnuCure.Name = "mnuCure";
            this.mnuCure.Size = new System.Drawing.Size(106, 24);
            this.mnuCure.Text = "TREATMENT";
            this.mnuCure.Click += new System.EventHandler(this.mnuCure_Click);
            // 
            // mnudrug
            // 
            this.mnudrug.Name = "mnudrug";
            this.mnudrug.Size = new System.Drawing.Size(63, 24);
            this.mnudrug.Text = "DRUG";
            this.mnudrug.Click += new System.EventHandler(this.mnudrug_Click);
            // 
            // mnuDealers
            // 
            this.mnuDealers.Name = "mnuDealers";
            this.mnuDealers.Size = new System.Drawing.Size(76, 24);
            this.mnuDealers.Text = "DEALER";
            this.mnuDealers.Click += new System.EventHandler(this.mnuDealers_Click);
            // 
            // mnuVeterLogout
            // 
            this.mnuVeterLogout.Name = "mnuVeterLogout";
            this.mnuVeterLogout.Size = new System.Drawing.Size(80, 24);
            this.mnuVeterLogout.Text = "LOGOUT";
            this.mnuVeterLogout.Click += new System.EventHandler(this.mnuVeterLogout_Click);
            // 
            // frmClinicMIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuLogin);
            this.Controls.Add(this.mnuVeter);
            this.IsMdiContainer = true;
            this.Name = "frmClinicMIS";
            this.Text = "Program Clinic 106";
            this.Load += new System.EventHandler(this.frmClinicMIS_Load);
            this.mnuLogin.ResumeLayout(false);
            this.mnuLogin.PerformLayout();
            this.mnuVeter.ResumeLayout(false);
            this.mnuVeter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuLogin;
        private ToolStripMenuItem mnuLoginForm;
        private ToolStripMenuItem mnuExit;
        private MenuStrip mnuVeter;
        private ToolStripMenuItem mnuCustomer;
        private ToolStripMenuItem mnuAnimal;
        private ToolStripMenuItem mnuCure;
        private ToolStripMenuItem mnuVeterLogout;
        private ToolStripMenuItem mnuVet;
        private ToolStripMenuItem mnudrug;
        private ToolStripMenuItem mnuDealers;
    }
}