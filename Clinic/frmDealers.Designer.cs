namespace Clinic
{
    partial class frmDealers
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
            this.dvgDealer = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDealerCompany = new System.Windows.Forms.TextBox();
            this.txtDealerTel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDealer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgDealer
            // 
            this.dvgDealer.AllowUserToAddRows = false;
            this.dvgDealer.AllowUserToDeleteRows = false;
            this.dvgDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDealer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDealer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDealer.Location = new System.Drawing.Point(14, 260);
            this.dvgDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgDealer.Name = "dvgDealer";
            this.dvgDealer.ReadOnly = true;
            this.dvgDealer.RowHeadersWidth = 51;
            this.dvgDealer.RowTemplate.Height = 25;
            this.dvgDealer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDealer.Size = new System.Drawing.Size(888, 324);
            this.dvgDealer.TabIndex = 13;
            this.dvgDealer.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgDealer_CellMouseUp);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(527, 64);
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
            this.btnDelete.Location = new System.Drawing.Point(527, 122);
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
            this.btnUpdate.Location = new System.Drawing.Point(700, 64);
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
            this.btnClearForm.Location = new System.Drawing.Point(700, 122);
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
            this.groupBox1.Controls.Add(this.txtDealerCompany);
            this.groupBox1.Controls.Add(this.btnClearForm);
            this.groupBox1.Controls.Add(this.txtDealerTel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.txtDealerID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 216);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer Drugs";
            // 
            // txtDealerCompany
            // 
            this.txtDealerCompany.Location = new System.Drawing.Point(135, 120);
            this.txtDealerCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerCompany.Name = "txtDealerCompany";
            this.txtDealerCompany.Size = new System.Drawing.Size(302, 27);
            this.txtDealerCompany.TabIndex = 44;
            // 
            // txtDealerTel
            // 
            this.txtDealerTel.Location = new System.Drawing.Point(134, 158);
            this.txtDealerTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerTel.Name = "txtDealerTel";
            this.txtDealerTel.Size = new System.Drawing.Size(169, 27);
            this.txtDealerTel.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Dealer Phone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 41;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(134, 81);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(302, 27);
            this.txtEmpName.TabIndex = 40;
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(134, 43);
            this.txtDealerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.ReadOnly = true;
            this.txtDealerID.Size = new System.Drawing.Size(169, 27);
            this.txtDealerID.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "DealerCompany :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Dealername :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "DealerID :";
            // 
            // frmDealers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgDealer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDealers";
            this.Text = "DrugDealers Form";
            this.Load += new System.EventHandler(this.frmDealers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDealer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dvgDealer;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearForm;
        private GroupBox groupBox1;
        private TextBox txtDealerCompany;
        private TextBox txtDealerTel;
        private Label label14;
        private Label label8;
        private TextBox txtEmpName;
        private TextBox txtDealerID;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}