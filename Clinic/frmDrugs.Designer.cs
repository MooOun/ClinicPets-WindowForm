namespace Clinic
{
    partial class frmDrugs
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
            this.dvgDrug = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCompanyDealer = new System.Windows.Forms.ComboBox();
            this.txtSizeDrug = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPriceDrug = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantityDrug = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.txtDrugID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDrug)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgDrug
            // 
            this.dvgDrug.AllowUserToAddRows = false;
            this.dvgDrug.AllowUserToDeleteRows = false;
            this.dvgDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDrug.Location = new System.Drawing.Point(8, 230);
            this.dvgDrug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgDrug.Name = "dvgDrug";
            this.dvgDrug.ReadOnly = true;
            this.dvgDrug.RowHeadersWidth = 51;
            this.dvgDrug.RowTemplate.Height = 25;
            this.dvgDrug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDrug.Size = new System.Drawing.Size(894, 357);
            this.dvgDrug.TabIndex = 13;
            this.dvgDrug.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgDrug_CellMouseUp);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(571, 102);
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
            this.btnDelete.Location = new System.Drawing.Point(571, 145);
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
            this.btnUpdate.Location = new System.Drawing.Point(746, 102);
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
            this.btnClearForm.Location = new System.Drawing.Point(746, 145);
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
            this.groupBox1.Controls.Add(this.cboCompanyDealer);
            this.groupBox1.Controls.Add(this.btnClearForm);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtSizeDrug);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtPriceDrug);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtQuantityDrug);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDrugName);
            this.groupBox1.Controls.Add(this.txtDrugID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 198);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drugs";
            // 
            // cboCompanyDealer
            // 
            this.cboCompanyDealer.FormattingEnabled = true;
            this.cboCompanyDealer.Location = new System.Drawing.Point(591, 44);
            this.cboCompanyDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCompanyDealer.Name = "cboCompanyDealer";
            this.cboCompanyDealer.Size = new System.Drawing.Size(278, 28);
            this.cboCompanyDealer.TabIndex = 54;
            // 
            // txtSizeDrug
            // 
            this.txtSizeDrug.Location = new System.Drawing.Point(114, 145);
            this.txtSizeDrug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSizeDrug.Name = "txtSizeDrug";
            this.txtSizeDrug.Size = new System.Drawing.Size(124, 27);
            this.txtSizeDrug.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "SizeDrug :";
            // 
            // txtPriceDrug
            // 
            this.txtPriceDrug.Location = new System.Drawing.Point(329, 110);
            this.txtPriceDrug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceDrug.Name = "txtPriceDrug";
            this.txtPriceDrug.Size = new System.Drawing.Size(127, 27);
            this.txtPriceDrug.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "UnitPrice :";
            // 
            // txtQuantityDrug
            // 
            this.txtQuantityDrug.Location = new System.Drawing.Point(113, 110);
            this.txtQuantityDrug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantityDrug.Name = "txtQuantityDrug";
            this.txtQuantityDrug.Size = new System.Drawing.Size(127, 27);
            this.txtQuantityDrug.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Quantity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 47;
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(113, 78);
            this.txtDrugName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(343, 27);
            this.txtDrugName.TabIndex = 46;
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(114, 41);
            this.txtDrugID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.ReadOnly = true;
            this.txtDrugID.Size = new System.Drawing.Size(127, 27);
            this.txtDrugID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "DealerCompany :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "DrugName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "DrugID :";
            // 
            // frmDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgDrug);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDrugs";
            this.Text = "Drug Form";
            this.Load += new System.EventHandler(this.frmDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDrug)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dvgDrug;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearForm;
        private GroupBox groupBox1;
        private ComboBox cboCompanyDealer;
        private TextBox txtSizeDrug;
        private Label label11;
        private TextBox txtPriceDrug;
        private Label label10;
        private TextBox txtQuantityDrug;
        private Label label14;
        private Label label8;
        private TextBox txtDrugName;
        private TextBox txtDrugID;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}