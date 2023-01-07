
namespace JewelryPOS
{
    partial class EditMember
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAddressSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAddressTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberLockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMember = new JewelryPOS.DataSetMember();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddressTax = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.memberTableAdapter = new JewelryPOS.DataSetMemberTableAdapters.MemberTableAdapter();
            this.comboBoxLock = new System.Windows.Forms.ComboBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberFNameDataGridViewTextBoxColumn,
            this.memberLNameDataGridViewTextBoxColumn,
            this.memberEmailDataGridViewTextBoxColumn,
            this.memberAddressSendDataGridViewTextBoxColumn,
            this.memberAddressTaxDataGridViewTextBoxColumn,
            this.memberTelDataGridViewTextBoxColumn,
            this.memberLockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberFNameDataGridViewTextBoxColumn
            // 
            this.memberFNameDataGridViewTextBoxColumn.DataPropertyName = "MemberFName";
            this.memberFNameDataGridViewTextBoxColumn.HeaderText = "MemberFName";
            this.memberFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberFNameDataGridViewTextBoxColumn.Name = "memberFNameDataGridViewTextBoxColumn";
            this.memberFNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberFNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberLNameDataGridViewTextBoxColumn
            // 
            this.memberLNameDataGridViewTextBoxColumn.DataPropertyName = "MemberLName";
            this.memberLNameDataGridViewTextBoxColumn.HeaderText = "MemberLName";
            this.memberLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberLNameDataGridViewTextBoxColumn.Name = "memberLNameDataGridViewTextBoxColumn";
            this.memberLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberLNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberEmailDataGridViewTextBoxColumn
            // 
            this.memberEmailDataGridViewTextBoxColumn.DataPropertyName = "MemberEmail";
            this.memberEmailDataGridViewTextBoxColumn.HeaderText = "MemberEmail";
            this.memberEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberEmailDataGridViewTextBoxColumn.Name = "memberEmailDataGridViewTextBoxColumn";
            this.memberEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberAddressSendDataGridViewTextBoxColumn
            // 
            this.memberAddressSendDataGridViewTextBoxColumn.DataPropertyName = "MemberAddressSend";
            this.memberAddressSendDataGridViewTextBoxColumn.HeaderText = "MemberAddressSend";
            this.memberAddressSendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberAddressSendDataGridViewTextBoxColumn.Name = "memberAddressSendDataGridViewTextBoxColumn";
            this.memberAddressSendDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberAddressSendDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberAddressTaxDataGridViewTextBoxColumn
            // 
            this.memberAddressTaxDataGridViewTextBoxColumn.DataPropertyName = "MemberAddressTax";
            this.memberAddressTaxDataGridViewTextBoxColumn.HeaderText = "MemberAddressTax";
            this.memberAddressTaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberAddressTaxDataGridViewTextBoxColumn.Name = "memberAddressTaxDataGridViewTextBoxColumn";
            this.memberAddressTaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberAddressTaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberTelDataGridViewTextBoxColumn
            // 
            this.memberTelDataGridViewTextBoxColumn.DataPropertyName = "MemberTel";
            this.memberTelDataGridViewTextBoxColumn.HeaderText = "MemberTel";
            this.memberTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberTelDataGridViewTextBoxColumn.Name = "memberTelDataGridViewTextBoxColumn";
            this.memberTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberLockDataGridViewTextBoxColumn
            // 
            this.memberLockDataGridViewTextBoxColumn.DataPropertyName = "MemberLock";
            this.memberLockDataGridViewTextBoxColumn.HeaderText = "MemberLock";
            this.memberLockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberLockDataGridViewTextBoxColumn.Name = "memberLockDataGridViewTextBoxColumn";
            this.memberLockDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberLockDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.dataSetMember;
            // 
            // dataSetMember
            // 
            this.dataSetMember.DataSetName = "DataSetMember";
            this.dataSetMember.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Snow;
            this.buttonUpdate.Location = new System.Drawing.Point(887, 411);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(180, 43);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "แก้ไขข้อมูล";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Snow;
            this.buttonInsert.Location = new System.Drawing.Point(887, 362);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(180, 43);
            this.buttonInsert.TabIndex = 21;
            this.buttonInsert.Text = "สมัครสมาชิก";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(156, 472);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(214, 34);
            this.textBoxTel.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "เบอร์โทร :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(156, 432);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(214, 34);
            this.textBoxEmail.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email :";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(156, 392);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(214, 34);
            this.textBoxLName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "นามสกุล :";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(156, 352);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(214, 34);
            this.textBoxFName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "ชื่อจริง :";
            // 
            // textBoxMemID
            // 
            this.textBoxMemID.Location = new System.Drawing.Point(156, 312);
            this.textBoxMemID.Name = "textBoxMemID";
            this.textBoxMemID.Size = new System.Drawing.Size(214, 34);
            this.textBoxMemID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "รหัสสมาชิก :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "ที่อยู่ใบกำกับภาษี :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "ที่อยู่จัดส่ง :";
            // 
            // textBoxAddressTax
            // 
            this.textBoxAddressTax.Location = new System.Drawing.Point(560, 312);
            this.textBoxAddressTax.Multiline = true;
            this.textBoxAddressTax.Name = "textBoxAddressTax";
            this.textBoxAddressTax.Size = new System.Drawing.Size(321, 219);
            this.textBoxAddressTax.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(156, 521);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(329, 176);
            this.textBoxAddress.TabIndex = 6;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxLock
            // 
            this.comboBoxLock.FormattingEnabled = true;
            this.comboBoxLock.Items.AddRange(new object[] {
            "Unlock",
            "Lock"});
            this.comboBoxLock.Location = new System.Drawing.Point(560, 537);
            this.comboBoxLock.Name = "comboBoxLock";
            this.comboBoxLock.Size = new System.Drawing.Size(121, 37);
            this.comboBoxLock.TabIndex = 23;
            // 
            // buttonLock
            // 
            this.buttonLock.BackColor = System.Drawing.Color.Snow;
            this.buttonLock.Location = new System.Drawing.Point(687, 533);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(194, 43);
            this.buttonLock.TabIndex = 21;
            this.buttonLock.Text = "เปลี่ยนสถานะ";
            this.buttonLock.UseVisualStyleBackColor = false;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Snow;
            this.buttonCheck.Location = new System.Drawing.Point(887, 315);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(180, 43);
            this.buttonCheck.TabIndex = 24;
            this.buttonCheck.Text = "เช็คข้อมูล";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Snow;
            this.buttonDel.Location = new System.Drawing.Point(887, 460);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(180, 43);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "ลบสมาชิก";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Snow;
            this.buttonClear.Location = new System.Drawing.Point(887, 509);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(180, 42);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1075, 705);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.comboBoxLock);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddressTax);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMember";
            this.Load += new System.EventHandler(this.EditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddressTax;
        private System.Windows.Forms.TextBox textBoxAddress;
        private DataSetMember dataSetMember;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DataSetMemberTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAddressSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAddressTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberLockDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxLock;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonClear;
    }
}