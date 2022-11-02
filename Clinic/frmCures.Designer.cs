namespace Clinic
{
    partial class frmTreatment
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtVeterID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVeterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.txtDrugID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.IbNetPrice = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lsvCure = new System.Windows.Forms.ListView();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.IbtotaldrugPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.txtImprement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurePrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCureDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 97;
            // 
            // txtVeterID
            // 
            this.txtVeterID.Location = new System.Drawing.Point(109, 16);
            this.txtVeterID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeterID.Name = "txtVeterID";
            this.txtVeterID.Size = new System.Drawing.Size(70, 27);
            this.txtVeterID.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Veterinary ID :";
            // 
            // txtVeterName
            // 
            this.txtVeterName.Location = new System.Drawing.Point(310, 17);
            this.txtVeterName.Name = "txtVeterName";
            this.txtVeterName.ReadOnly = true;
            this.txtVeterName.Size = new System.Drawing.Size(184, 27);
            this.txtVeterName.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Veterinary Name :";
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(268, 32);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.ReadOnly = true;
            this.txtDrugName.Size = new System.Drawing.Size(92, 27);
            this.txtDrugName.TabIndex = 121;
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(85, 32);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(91, 27);
            this.txtDrugID.TabIndex = 120;
            this.txtDrugID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrugID_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 119;
            this.label15.Text = "Drug Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 118;
            this.label16.Text = "Drug ID :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(85, 62);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(91, 27);
            this.txtQuantity.TabIndex = 125;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(269, 62);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(91, 27);
            this.txtPrice.TabIndex = 124;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 123;
            this.label12.Text = "Quantity :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 122;
            this.label13.Text = "UnitPrice :";
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.Location = new System.Drawing.Point(85, 95);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.ReadOnly = true;
            this.txtTotalprice.Size = new System.Drawing.Size(91, 27);
            this.txtTotalprice.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 126;
            this.label9.Text = "TotalPrice :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(513, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 28);
            this.label17.TabIndex = 129;
            this.label17.Text = "Total Price :";
            // 
            // IbNetPrice
            // 
            this.IbNetPrice.AutoSize = true;
            this.IbNetPrice.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IbNetPrice.Location = new System.Drawing.Point(658, 13);
            this.IbNetPrice.Name = "IbNetPrice";
            this.IbNetPrice.Size = new System.Drawing.Size(53, 28);
            this.IbNetPrice.TabIndex = 128;
            this.IbNetPrice.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(732, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 28);
            this.label18.TabIndex = 130;
            this.label18.Text = "Bath";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.Text = "Cancel Cures";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(98, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 29);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(193, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 132;
            this.btnClear.Text = "ClearForm";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 29);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lsvCure
            // 
            this.lsvCure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCure.Location = new System.Drawing.Point(400, 104);
            this.lsvCure.Name = "lsvCure";
            this.lsvCure.Size = new System.Drawing.Size(391, 334);
            this.lsvCure.TabIndex = 135;
            this.lsvCure.UseCompatibleStateImageBehavior = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(461, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 28);
            this.label19.TabIndex = 137;
            this.label19.Text = "Total Price Drug :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(732, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 28);
            this.label20.TabIndex = 139;
            this.label20.Text = "Bath";
            // 
            // IbtotaldrugPrice
            // 
            this.IbtotaldrugPrice.AutoSize = true;
            this.IbtotaldrugPrice.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IbtotaldrugPrice.Location = new System.Drawing.Point(658, 57);
            this.IbtotaldrugPrice.Name = "IbtotaldrugPrice";
            this.IbtotaldrugPrice.Size = new System.Drawing.Size(53, 28);
            this.IbtotaldrugPrice.TabIndex = 138;
            this.IbtotaldrugPrice.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAnimalName);
            this.groupBox1.Controls.Add(this.txtImprement);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSymptom);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCurePrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCureDate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAnimalID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 195);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treatment";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(140, 87);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(220, 27);
            this.txtCustomerName.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 150;
            this.label1.Text = "Customer Name :";
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(98, 55);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.ReadOnly = true;
            this.txtAnimalName.Size = new System.Drawing.Size(262, 27);
            this.txtAnimalName.TabIndex = 149;
            // 
            // txtImprement
            // 
            this.txtImprement.Location = new System.Drawing.Point(92, 156);
            this.txtImprement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImprement.Name = "txtImprement";
            this.txtImprement.Size = new System.Drawing.Size(268, 27);
            this.txtImprement.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 147;
            this.label4.Text = "Imprement :";
            // 
            // txtSymptom
            // 
            this.txtSymptom.Location = new System.Drawing.Point(259, 124);
            this.txtSymptom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.Size = new System.Drawing.Size(101, 27);
            this.txtSymptom.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 145;
            this.label11.Text = "Symptom :";
            // 
            // txtCurePrice
            // 
            this.txtCurePrice.Location = new System.Drawing.Point(92, 121);
            this.txtCurePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurePrice.Name = "txtCurePrice";
            this.txtCurePrice.Size = new System.Drawing.Size(83, 27);
            this.txtCurePrice.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 143;
            this.label10.Text = "Cure Price :";
            // 
            // txtCureDate
            // 
            this.txtCureDate.Location = new System.Drawing.Point(240, 25);
            this.txtCureDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCureDate.Name = "txtCureDate";
            this.txtCureDate.ReadOnly = true;
            this.txtCureDate.Size = new System.Drawing.Size(120, 27);
            this.txtCureDate.TabIndex = 142;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 141;
            this.label14.Text = "Cure Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 140;
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(69, 25);
            this.txtAnimalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(78, 27);
            this.txtAnimalID.TabIndex = 139;
            this.txtAnimalID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnimalID_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Pet Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 137;
            this.label2.Text = "Pet ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDrugID);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTotalprice);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtDrugName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(17, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 136);
            this.groupBox2.TabIndex = 141;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispense Drug";
            // 
            // frmTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.IbtotaldrugPrice);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lsvCure);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.IbNetPrice);
            this.Controls.Add(this.txtVeterName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVeterID);
            this.Controls.Add(this.label6);
            this.Name = "frmTreatment";
            this.Text = "Treatment From";
            this.Load += new System.EventHandler(this.frmCures_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private TextBox txtVeterID;
        private Label label6;
        private TextBox txtVeterName;
        private Label label7;
        private TextBox txtDrugName;
        private TextBox txtDrugID;
        private Label label15;
        private Label label16;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label12;
        private Label label13;
        private TextBox txtTotalprice;
        private Label label9;
        private Label label17;
        private Label IbNetPrice;
        private Label label18;
        private Button btnCancel;
        private Button btnSave;
        private Button btnClear;
        private Button btnAdd;
        private ListView lsvCure;
        private Label label19;
        private Label label20;
        private Label IbtotaldrugPrice;
        private GroupBox groupBox1;
        private TextBox txtAnimalName;
        private TextBox txtImprement;
        private Label label4;
        private TextBox txtSymptom;
        private Label label11;
        private TextBox txtCurePrice;
        private Label label10;
        private TextBox txtCureDate;
        private Label label14;
        private Label label8;
        private TextBox txtAnimalID;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtCustomerName;
        private Label label1;
    }
}