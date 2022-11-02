namespace Clinic
{
    partial class frmAnimals
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
            this.dvgAnimals = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnimalSpecies = new System.Windows.Forms.TextBox();
            this.txtAnimalAge = new System.Windows.Forms.TextBox();
            this.txtAnimalColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnimalDes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAnimals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgAnimals
            // 
            this.dvgAnimals.AllowUserToAddRows = false;
            this.dvgAnimals.AllowUserToDeleteRows = false;
            this.dvgAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAnimals.Location = new System.Drawing.Point(14, 303);
            this.dvgAnimals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgAnimals.Name = "dvgAnimals";
            this.dvgAnimals.ReadOnly = true;
            this.dvgAnimals.RowHeadersWidth = 51;
            this.dvgAnimals.RowTemplate.Height = 25;
            this.dvgAnimals.Size = new System.Drawing.Size(894, 281);
            this.dvgAnimals.TabIndex = 13;
            this.dvgAnimals.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgAnimals_CellMouseUp);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(155, 264);
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
            this.btnDelete.Location = new System.Drawing.Point(497, 264);
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
            this.btnUpdate.Location = new System.Drawing.Point(323, 264);
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
            this.btnClearForm.Location = new System.Drawing.Point(671, 264);
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
            this.groupBox1.Controls.Add(this.cboCustomer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAnimalSpecies);
            this.groupBox1.Controls.Add(this.txtAnimalAge);
            this.groupBox1.Controls.Add(this.txtAnimalColor);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAnimalDes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAnimalName);
            this.groupBox1.Controls.Add(this.txtAnimalID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 245);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animals";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Enabled = false;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(156, 196);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(291, 28);
            this.cboCustomer.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Animal Type :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(156, 158);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(291, 27);
            this.txtCustomerID.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Customer ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Customer Name :";
            // 
            // txtAnimalSpecies
            // 
            this.txtAnimalSpecies.Location = new System.Drawing.Point(557, 92);
            this.txtAnimalSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalSpecies.Name = "txtAnimalSpecies";
            this.txtAnimalSpecies.Size = new System.Drawing.Size(300, 27);
            this.txtAnimalSpecies.TabIndex = 62;
            // 
            // txtAnimalAge
            // 
            this.txtAnimalAge.Location = new System.Drawing.Point(731, 48);
            this.txtAnimalAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalAge.Name = "txtAnimalAge";
            this.txtAnimalAge.Size = new System.Drawing.Size(126, 27);
            this.txtAnimalAge.TabIndex = 61;
            // 
            // txtAnimalColor
            // 
            this.txtAnimalColor.Location = new System.Drawing.Point(557, 48);
            this.txtAnimalColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalColor.Name = "txtAnimalColor";
            this.txtAnimalColor.Size = new System.Drawing.Size(125, 27);
            this.txtAnimalColor.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Species :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Age :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Color :";
            // 
            // txtAnimalDes
            // 
            this.txtAnimalDes.Location = new System.Drawing.Point(557, 128);
            this.txtAnimalDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalDes.Multiline = true;
            this.txtAnimalDes.Name = "txtAnimalDes";
            this.txtAnimalDes.Size = new System.Drawing.Size(302, 51);
            this.txtAnimalDes.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Description :";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(156, 121);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(291, 27);
            this.txtType.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 53;
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(156, 83);
            this.txtAnimalName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(291, 27);
            this.txtAnimalName.TabIndex = 52;
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(156, 44);
            this.txtAnimalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.ReadOnly = true;
            this.txtAnimalID.Size = new System.Drawing.Size(291, 27);
            this.txtAnimalID.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Animal Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Animal ID :";
            // 
            // frmAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dvgAnimals);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAnimals";
            this.Text = "Animals From";
            this.Load += new System.EventHandler(this.frmAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAnimals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dvgAnimals;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearForm;
        private GroupBox groupBox1;
        private ComboBox cboCustomer;
        private Label label6;
        private TextBox txtCustomerID;
        private Label label5;
        private Label label4;
        private TextBox txtAnimalSpecies;
        private TextBox txtAnimalAge;
        private TextBox txtAnimalColor;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtAnimalDes;
        private Label label10;
        private TextBox txtType;
        private Label label8;
        private TextBox txtAnimalName;
        private TextBox txtAnimalID;
        private Label label3;
        private Label label2;
    }
}