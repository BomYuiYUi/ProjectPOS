
namespace JewelryPOS
{
    partial class ProductM
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
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProduct = new JewelryPOS.DataSetProduct();
            this.productTableAdapter = new JewelryPOS.DataSetProductTableAdapters.ProductTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduct)).BeginInit();
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
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productMaterialDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productMaterialDataGridViewTextBoxColumn
            // 
            this.productMaterialDataGridViewTextBoxColumn.DataPropertyName = "ProductMaterial";
            this.productMaterialDataGridViewTextBoxColumn.HeaderText = "ProductMaterial";
            this.productMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productMaterialDataGridViewTextBoxColumn.Name = "productMaterialDataGridViewTextBoxColumn";
            this.productMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            this.productCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dataSetProduct;
            // 
            // dataSetProduct
            // 
            this.dataSetProduct.DataSetName = "DataSetProduct";
            this.dataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสสินค้า :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(136, 262);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(198, 34);
            this.textBoxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อสินค้า :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 302);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 34);
            this.textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "ชนิดสินค้า :";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(136, 342);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(198, 34);
            this.textBoxType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "วัสดุ :";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(136, 382);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(198, 34);
            this.textBoxM.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "ต้นทุน :";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(136, 422);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(198, 34);
            this.textBoxCost.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "ราคาขาย :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(136, 462);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(198, 34);
            this.textBoxPrice.TabIndex = 2;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Snow;
            this.buttonInsert.Location = new System.Drawing.Point(355, 260);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(160, 38);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "เพิ่มสินค้า";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Snow;
            this.buttonUpdate.Location = new System.Drawing.Point(355, 301);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 36);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "แก้ไขสินค้า";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Snow;
            this.buttonDel.Location = new System.Drawing.Point(355, 343);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 32);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "ลบสินค้า";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Snow;
            this.buttonAdd.Location = new System.Drawing.Point(355, 381);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 33);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "เพิ่มสินค้าลงตะกร้า";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Snow;
            this.buttonClear.Location = new System.Drawing.Point(355, 421);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(160, 33);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ProductM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(830, 516);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductM_FormClosing);
            this.Load += new System.EventHandler(this.ProductM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetProduct dataSetProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataSetProductTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
    }
}