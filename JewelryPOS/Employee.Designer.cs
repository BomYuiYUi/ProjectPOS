
namespace JewelryPOS
{
    partial class Employee
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
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEmployee = new JewelryPOS.DataSetEmployee();
            this.employeeTableAdapter = new JewelryPOS.DataSetEmployeeTableAdapters.EmployeeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployee)).BeginInit();
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
            this.empIDDataGridViewTextBoxColumn,
            this.empFNameDataGridViewTextBoxColumn,
            this.empLNameDataGridViewTextBoxColumn,
            this.empAddressDataGridViewTextBoxColumn,
            this.empPassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empFNameDataGridViewTextBoxColumn
            // 
            this.empFNameDataGridViewTextBoxColumn.DataPropertyName = "EmpFName";
            this.empFNameDataGridViewTextBoxColumn.HeaderText = "EmpFName";
            this.empFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empFNameDataGridViewTextBoxColumn.Name = "empFNameDataGridViewTextBoxColumn";
            this.empFNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empFNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empLNameDataGridViewTextBoxColumn
            // 
            this.empLNameDataGridViewTextBoxColumn.DataPropertyName = "EmpLName";
            this.empLNameDataGridViewTextBoxColumn.HeaderText = "EmpLName";
            this.empLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empLNameDataGridViewTextBoxColumn.Name = "empLNameDataGridViewTextBoxColumn";
            this.empLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empLNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empAddressDataGridViewTextBoxColumn
            // 
            this.empAddressDataGridViewTextBoxColumn.DataPropertyName = "EmpAddress";
            this.empAddressDataGridViewTextBoxColumn.HeaderText = "EmpAddress";
            this.empAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empAddressDataGridViewTextBoxColumn.Name = "empAddressDataGridViewTextBoxColumn";
            this.empAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.empAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // empPassDataGridViewTextBoxColumn
            // 
            this.empPassDataGridViewTextBoxColumn.DataPropertyName = "EmpPass";
            this.empPassDataGridViewTextBoxColumn.HeaderText = "EmpPass";
            this.empPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empPassDataGridViewTextBoxColumn.Name = "empPassDataGridViewTextBoxColumn";
            this.empPassDataGridViewTextBoxColumn.ReadOnly = true;
            this.empPassDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSetEmployee;
            // 
            // dataSetEmployee
            // 
            this.dataSetEmployee.DataSetName = "DataSetEmployee";
            this.dataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสพนักงาน :";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(165, 213);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(182, 34);
            this.textBoxEmpID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อจริง :";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(165, 254);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(182, 34);
            this.textBoxFName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "นามสกุล :";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(165, 293);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(182, 34);
            this.textBoxLName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "ที่อยู่ :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(423, 213);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(269, 155);
            this.textBoxAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "รหัสผ่าน :";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(165, 336);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(182, 34);
            this.textBoxPass.TabIndex = 2;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Snow;
            this.buttonInsert.Location = new System.Drawing.Point(41, 392);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(207, 45);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "เพิ่มข้อมูลพนักงาน";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Snow;
            this.buttonDel.Location = new System.Drawing.Point(467, 392);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(207, 45);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "ลบข้อมูลพนักงาน";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Snow;
            this.buttonUpdate.Location = new System.Drawing.Point(254, 392);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(207, 45);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "แก้ไขข้อมูลพนักงาน";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Snow;
            this.buttonClear.Location = new System.Drawing.Point(254, 443);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(206, 45);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(696, 491);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetEmployee dataSetEmployee;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSetEmployeeTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
    }
}