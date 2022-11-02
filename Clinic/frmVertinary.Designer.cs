namespace Clinic
{
    partial class frmVertinary
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
            this.dvgVeterinary = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVeterExp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVeterPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVeterPassword = new System.Windows.Forms.TextBox();
            this.txtVeterUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVeterTel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVeterAddress = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtVeterID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVeterinary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgVeterinary
            // 
            this.dvgVeterinary.AllowUserToAddRows = false;
            this.dvgVeterinary.AllowUserToDeleteRows = false;
            this.dvgVeterinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgVeterinary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgVeterinary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVeterinary.Location = new System.Drawing.Point(14, 397);
            this.dvgVeterinary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgVeterinary.Name = "dvgVeterinary";
            this.dvgVeterinary.ReadOnly = true;
            this.dvgVeterinary.RowHeadersWidth = 51;
            this.dvgVeterinary.RowTemplate.Height = 25;
            this.dvgVeterinary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgVeterinary.Size = new System.Drawing.Size(894, 187);
            this.dvgVeterinary.TabIndex = 13;
            this.dvgVeterinary.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgVeterinary_CellFormatting);
            this.dvgVeterinary.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgVeterinary_CellMouseUp);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(178, 350);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 31);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(488, 351);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(335, 351);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 31);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(653, 351);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(118, 31);
            this.btnClearForm.TabIndex = 17;
            this.btnClearForm.Text = "ClearForm";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVeterExp);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtVeterPasswordConfirm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVeterPassword);
            this.groupBox1.Controls.Add(this.txtVeterUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtVeterTel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtVeterAddress);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.txtVeterID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 332);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veterinarys";
            // 
            // txtVeterExp
            // 
            this.txtVeterExp.Location = new System.Drawing.Point(572, 48);
            this.txtVeterExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterExp.Multiline = true;
            this.txtVeterExp.Name = "txtVeterExp";
            this.txtVeterExp.Size = new System.Drawing.Size(279, 132);
            this.txtVeterExp.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "Expert Skil :";
            // 
            // txtVeterPasswordConfirm
            // 
            this.txtVeterPasswordConfirm.Location = new System.Drawing.Point(572, 282);
            this.txtVeterPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterPasswordConfirm.Name = "txtVeterPasswordConfirm";
            this.txtVeterPasswordConfirm.PasswordChar = '*';
            this.txtVeterPasswordConfirm.Size = new System.Drawing.Size(279, 27);
            this.txtVeterPasswordConfirm.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Comfirm Password :";
            // 
            // txtVeterPassword
            // 
            this.txtVeterPassword.Location = new System.Drawing.Point(572, 232);
            this.txtVeterPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterPassword.Name = "txtVeterPassword";
            this.txtVeterPassword.PasswordChar = '*';
            this.txtVeterPassword.Size = new System.Drawing.Size(279, 27);
            this.txtVeterPassword.TabIndex = 53;
            // 
            // txtVeterUsername
            // 
            this.txtVeterUsername.Location = new System.Drawing.Point(572, 188);
            this.txtVeterUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterUsername.Name = "txtVeterUsername";
            this.txtVeterUsername.Size = new System.Drawing.Size(279, 27);
            this.txtVeterUsername.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Username :";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(287, 89);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(123, 27);
            this.txtPosition.TabIndex = 49;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Position :";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(112, 168);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(298, 27);
            this.txtLastname.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Lastname :";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(112, 89);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(80, 27);
            this.txtTitle.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Title :";
            // 
            // txtVeterTel
            // 
            this.txtVeterTel.Location = new System.Drawing.Point(114, 281);
            this.txtVeterTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterTel.Name = "txtVeterTel";
            this.txtVeterTel.Size = new System.Drawing.Size(298, 27);
            this.txtVeterTel.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 20);
            this.label16.TabIndex = 42;
            this.label16.Text = "Phone :";
            // 
            // txtVeterAddress
            // 
            this.txtVeterAddress.Location = new System.Drawing.Point(114, 204);
            this.txtVeterAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterAddress.Multiline = true;
            this.txtVeterAddress.Name = "txtVeterAddress";
            this.txtVeterAddress.Size = new System.Drawing.Size(298, 69);
            this.txtVeterAddress.TabIndex = 41;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(112, 133);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(298, 27);
            this.txtFirstname.TabIndex = 40;
            // 
            // txtVeterID
            // 
            this.txtVeterID.Location = new System.Drawing.Point(112, 44);
            this.txtVeterID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterID.Name = "txtVeterID";
            this.txtVeterID.ReadOnly = true;
            this.txtVeterID.Size = new System.Drawing.Size(175, 27);
            this.txtVeterID.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Firstname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Veterinary ID :";
            // 
            // frmVertinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dvgVeterinary);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVertinary";
            this.Text = "VertinaryForm";
            this.Load += new System.EventHandler(this.frmVertinary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVeterinary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dvgVeterinary;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearForm;
        private GroupBox groupBox1;
        private TextBox txtVeterExp;
        private Label label14;
        private TextBox txtVeterPasswordConfirm;
        private Label label7;
        private TextBox txtVeterPassword;
        private TextBox txtVeterUsername;
        private Label label6;
        private Label label5;
        private TextBox txtPosition;
        private Label label10;
        private TextBox txtLastname;
        private Label label9;
        private TextBox txtTitle;
        private Label label8;
        private TextBox txtVeterTel;
        private Label label16;
        private TextBox txtVeterAddress;
        private TextBox txtFirstname;
        private TextBox txtVeterID;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}