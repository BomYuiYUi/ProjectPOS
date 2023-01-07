
namespace JewelryPOS
{
    partial class MainMenu
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productTypeLabel;
            System.Windows.Forms.Label productMaterialLabel;
            System.Windows.Forms.Label productPriceLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxPayType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMemID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonSummarize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProdList = new JewelryPOS.DataSetProdList();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProdDetail = new JewelryPOS.DataSetProdDetail();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productTypeTextBox = new System.Windows.Forms.TextBox();
            this.productMaterialTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.receiptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReceipt = new JewelryPOS.DataSetReceipt();
            this.productTableAdapter = new JewelryPOS.DataSetProdDetailTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new JewelryPOS.DataSetProdDetailTableAdapters.TableAdapterManager();
            this.productTableAdapter1 = new JewelryPOS.DataSetProdListTableAdapters.ProductTableAdapter();
            this.receiptTableAdapter = new JewelryPOS.DataSetReceiptTableAdapters.ReceiptTableAdapter();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInspect = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAll = new System.Windows.Forms.Button();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEmp = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrice = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonProfit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productTypeLabel = new System.Windows.Forms.Label();
            productMaterialLabel = new System.Windows.Forms.Label();
            productPriceLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReceipt)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(6, 50);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(112, 29);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "รหัสสินค้า:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(6, 90);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(97, 29);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "ชื่อสินค้า:";
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Location = new System.Drawing.Point(6, 130);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new System.Drawing.Size(93, 29);
            productTypeLabel.TabIndex = 4;
            productTypeLabel.Text = "ประเภท:";
            // 
            // productMaterialLabel
            // 
            productMaterialLabel.AutoSize = true;
            productMaterialLabel.Location = new System.Drawing.Point(6, 170);
            productMaterialLabel.Name = "productMaterialLabel";
            productMaterialLabel.Size = new System.Drawing.Size(57, 29);
            productMaterialLabel.TabIndex = 6;
            productMaterialLabel.Text = "วัสดุ:";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new System.Drawing.Point(6, 210);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new System.Drawing.Size(100, 29);
            productPriceLabel.TabIndex = 8;
            productPriceLabel.Text = "ราคาขาย:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxPayType);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxChange);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxMemID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxMoney);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(821, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 156);
            this.panel3.TabIndex = 29;
            // 
            // comboBoxPayType
            // 
            this.comboBoxPayType.FormattingEnabled = true;
            this.comboBoxPayType.Items.AddRange(new object[] {
            "เงินสด",
            "บัตรเคดิต",
            "โอนเงิน"});
            this.comboBoxPayType.Location = new System.Drawing.Point(104, 42);
            this.comboBoxPayType.Name = "comboBoxPayType";
            this.comboBoxPayType.Size = new System.Drawing.Size(124, 37);
            this.comboBoxPayType.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "จ่ายด้วย :";
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(104, 119);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(124, 34);
            this.textBoxChange.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "เงินทอน :";
            // 
            // textBoxMemID
            // 
            this.textBoxMemID.Location = new System.Drawing.Point(104, 6);
            this.textBoxMemID.Name = "textBoxMemID";
            this.textBoxMemID.Size = new System.Drawing.Size(124, 34);
            this.textBoxMemID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "สมาชิก :";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(104, 82);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(124, 34);
            this.textBoxMoney.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "เงิน :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Snow;
            this.buttonUpdate.Location = new System.Drawing.Point(264, 73);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(186, 34);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "เพิ่มจำนวนสินค้า";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Snow;
            this.buttonAdd.Location = new System.Drawing.Point(264, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(186, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ใส่สินค้าลงตะกร้า";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "จำนวน :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสสินค้า :";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(129, 72);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(90, 34);
            this.textBoxQuantity.TabIndex = 0;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(129, 33);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(129, 34);
            this.textBoxID.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Snow;
            this.buttonReset.Location = new System.Drawing.Point(177, 77);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(175, 71);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "ลบทั้งรายการ";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Snow;
            this.buttonDel.Location = new System.Drawing.Point(3, 77);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(175, 71);
            this.buttonDel.TabIndex = 0;
            this.buttonDel.Text = "ลบรายการ";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Snow;
            this.buttonPay.Location = new System.Drawing.Point(177, 3);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(175, 71);
            this.buttonPay.TabIndex = 0;
            this.buttonPay.Text = "ชำระเงิน";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonSummarize
            // 
            this.buttonSummarize.BackColor = System.Drawing.Color.Snow;
            this.buttonSummarize.Location = new System.Drawing.Point(3, 3);
            this.buttonSummarize.Name = "buttonSummarize";
            this.buttonSummarize.Size = new System.Drawing.Size(175, 71);
            this.buttonSummarize.TabIndex = 0;
            this.buttonSummarize.Text = "สรุปข้อมูลสั่งซื้อ";
            this.buttonSummarize.UseVisualStyleBackColor = false;
            this.buttonSummarize.Click += new System.EventHandler(this.buttonSummarize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 487);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ชื่อสินค้า";
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.DataSource = this.productBindingSource1;
            this.listBoxProduct.DisplayMember = "ProductName";
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 29;
            this.listBoxProduct.Location = new System.Drawing.Point(8, 33);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(242, 439);
            this.listBoxProduct.TabIndex = 0;
            this.listBoxProduct.ValueMember = "ProductID";
            this.listBoxProduct.SelectedIndexChanged += new System.EventHandler(this.listBoxProduct_SelectedIndexChanged);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.dataSetProdList;
            // 
            // dataSetProdList
            // 
            this.dataSetProdList.DataSetName = "DataSetProdList";
            this.dataSetProdList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(productIDLabel);
            this.groupBox2.Controls.Add(this.productIDTextBox);
            this.groupBox2.Controls.Add(productNameLabel);
            this.groupBox2.Controls.Add(this.productNameTextBox);
            this.groupBox2.Controls.Add(productTypeLabel);
            this.groupBox2.Controls.Add(this.productTypeTextBox);
            this.groupBox2.Controls.Add(productMaterialLabel);
            this.groupBox2.Controls.Add(this.productMaterialTextBox);
            this.groupBox2.Controls.Add(productPriceLabel);
            this.groupBox2.Controls.Add(this.productPriceTextBox);
            this.groupBox2.Location = new System.Drawing.Point(274, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 257);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายละเอียดสินค้า";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.BackColor = System.Drawing.Color.White;
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(124, 47);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(169, 34);
            this.productIDTextBox.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dataSetProdDetail;
            // 
            // dataSetProdDetail
            // 
            this.dataSetProdDetail.DataSetName = "DataSetProdDetail";
            this.dataSetProdDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.White;
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(124, 87);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(169, 34);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productTypeTextBox
            // 
            this.productTypeTextBox.BackColor = System.Drawing.Color.White;
            this.productTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductType", true));
            this.productTypeTextBox.Location = new System.Drawing.Point(124, 127);
            this.productTypeTextBox.Name = "productTypeTextBox";
            this.productTypeTextBox.ReadOnly = true;
            this.productTypeTextBox.Size = new System.Drawing.Size(169, 34);
            this.productTypeTextBox.TabIndex = 5;
            // 
            // productMaterialTextBox
            // 
            this.productMaterialTextBox.BackColor = System.Drawing.Color.White;
            this.productMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductMaterial", true));
            this.productMaterialTextBox.Location = new System.Drawing.Point(124, 167);
            this.productMaterialTextBox.Name = "productMaterialTextBox";
            this.productMaterialTextBox.ReadOnly = true;
            this.productMaterialTextBox.Size = new System.Drawing.Size(169, 34);
            this.productMaterialTextBox.TabIndex = 7;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.BackColor = System.Drawing.Color.White;
            this.productPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductPrice", true));
            this.productPriceTextBox.Location = new System.Drawing.Point(124, 207);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.ReadOnly = true;
            this.productPriceTextBox.Size = new System.Drawing.Size(169, 34);
            this.productPriceTextBox.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewReceipt);
            this.groupBox3.Location = new System.Drawing.Point(573, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 257);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ตะกร้าสินค้า";
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.AllowUserToAddRows = false;
            this.dataGridViewReceipt.AllowUserToDeleteRows = false;
            this.dataGridViewReceipt.AutoGenerateColumns = false;
            this.dataGridViewReceipt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.receiptQuantityDataGridViewTextBoxColumn,
            this.receiptPriceDataGridViewTextBoxColumn,
            this.receiptProfitDataGridViewTextBoxColumn});
            this.dataGridViewReceipt.DataSource = this.receiptBindingSource;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.ReadOnly = true;
            this.dataGridViewReceipt.RowHeadersWidth = 51;
            this.dataGridViewReceipt.RowTemplate.Height = 24;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(475, 218);
            this.dataGridViewReceipt.TabIndex = 0;
            this.dataGridViewReceipt.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewReceipt_RowHeaderMouseClick);
            // 
            // receiptIDDataGridViewTextBoxColumn
            // 
            this.receiptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.HeaderText = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptIDDataGridViewTextBoxColumn.Name = "receiptIDDataGridViewTextBoxColumn";
            this.receiptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptIDDataGridViewTextBoxColumn.Visible = false;
            this.receiptIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiptQuantityDataGridViewTextBoxColumn
            // 
            this.receiptQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReceiptQuantity";
            this.receiptQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.receiptQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptQuantityDataGridViewTextBoxColumn.Name = "receiptQuantityDataGridViewTextBoxColumn";
            this.receiptQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptPriceDataGridViewTextBoxColumn
            // 
            this.receiptPriceDataGridViewTextBoxColumn.DataPropertyName = "ReceiptPrice";
            this.receiptPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.receiptPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptPriceDataGridViewTextBoxColumn.Name = "receiptPriceDataGridViewTextBoxColumn";
            this.receiptPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptProfitDataGridViewTextBoxColumn
            // 
            this.receiptProfitDataGridViewTextBoxColumn.DataPropertyName = "ReceiptProfit";
            this.receiptProfitDataGridViewTextBoxColumn.HeaderText = "ReceiptProfit";
            this.receiptProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptProfitDataGridViewTextBoxColumn.Name = "receiptProfitDataGridViewTextBoxColumn";
            this.receiptProfitDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptProfitDataGridViewTextBoxColumn.Visible = false;
            this.receiptProfitDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.dataSetReceipt;
            // 
            // dataSetReceipt
            // 
            this.dataSetReceipt.DataSetName = "DataSetReceipt";
            this.dataSetReceipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = JewelryPOS.DataSetProdDetailTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.Location = new System.Drawing.Point(906, 310);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(148, 34);
            this.textBoxPrice.TabIndex = 33;
            this.textBoxPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "ราคาสุทธิ";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(906, 390);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(148, 34);
            this.textBoxTotal.TabIndex = 33;
            this.textBoxTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "ราคารวม";
            // 
            // textBoxTax
            // 
            this.textBoxTax.BackColor = System.Drawing.Color.White;
            this.textBoxTax.Location = new System.Drawing.Point(906, 350);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(148, 34);
            this.textBoxTax.TabIndex = 33;
            this.textBoxTax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "ภาษี";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonUpdate);
            this.groupBox4.Controls.Add(this.buttonAdd);
            this.groupBox4.Controls.Add(this.textBoxID);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxQuantity);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(274, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 112);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ใส่สินค้า";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonPay);
            this.panel1.Controls.Add(this.buttonSummarize);
            this.panel1.Location = new System.Drawing.Point(274, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 154);
            this.panel1.TabIndex = 27;
            // 
            // buttonInspect
            // 
            this.buttonInspect.BackColor = System.Drawing.Color.Snow;
            this.buttonInspect.Location = new System.Drawing.Point(640, 426);
            this.buttonInspect.Name = "buttonInspect";
            this.buttonInspect.Size = new System.Drawing.Size(175, 54);
            this.buttonInspect.TabIndex = 36;
            this.buttonInspect.Text = "ตรวจสอบสมาชิก";
            this.buttonInspect.UseVisualStyleBackColor = false;
            this.buttonInspect.Click += new System.EventHandler(this.buttonInspect_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(897, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(157, 34);
            this.dateTimePicker.TabIndex = 37;
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.Snow;
            this.buttonAll.Location = new System.Drawing.Point(20, 545);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(242, 37);
            this.buttonAll.TabIndex = 38;
            this.buttonAll.Text = "เลือกสินค้าทั้งหมด";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Snow;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonProduct,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButtonEditMember,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripButtonEmp,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripButtonPrice,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButtonProfit,
            this.toolStripLabel5});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1061, 27);
            this.toolStripMenu.TabIndex = 39;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonProduct
            // 
            this.toolStripButtonProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProduct.Image = global::JewelryPOS.Properties.Resources._22222;
            this.toolStripButtonProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProduct.Name = "toolStripButtonProduct";
            this.toolStripButtonProduct.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonProduct.Text = "toolStripButton1";
            this.toolStripButtonProduct.Click += new System.EventHandler(this.toolStripButtonProduct_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 24);
            this.toolStripLabel1.Text = "เพิ่มสินค้า";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEditMember
            // 
            this.toolStripButtonEditMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditMember.Image = global::JewelryPOS.Properties.Resources._33333;
            this.toolStripButtonEditMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditMember.Name = "toolStripButtonEditMember";
            this.toolStripButtonEditMember.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEditMember.Text = "toolStripButton2";
            this.toolStripButtonEditMember.Click += new System.EventHandler(this.toolStripButtonEditMember_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel2.Text = "สมาชิก";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEmp
            // 
            this.toolStripButtonEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEmp.Image = global::JewelryPOS.Properties.Resources._11111;
            this.toolStripButtonEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEmp.Name = "toolStripButtonEmp";
            this.toolStripButtonEmp.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEmp.Text = "toolStripButton3";
            this.toolStripButtonEmp.Click += new System.EventHandler(this.toolStripButtonEmp_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 24);
            this.toolStripLabel3.Text = "พนักงาน";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonPrice
            // 
            this.toolStripButtonPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrice.Image = global::JewelryPOS.Properties.Resources._2222;
            this.toolStripButtonPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrice.Name = "toolStripButtonPrice";
            this.toolStripButtonPrice.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonPrice.Text = "toolStripButton1";
            this.toolStripButtonPrice.Click += new System.EventHandler(this.toolStripButtonPrice_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel4.Text = "รายงานยอดขาย";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonProfit
            // 
            this.toolStripButtonProfit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProfit.Image = global::JewelryPOS.Properties.Resources._3333;
            this.toolStripButtonProfit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProfit.Name = "toolStripButtonProfit";
            this.toolStripButtonProfit.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonProfit.Text = "toolStripButton2";
            this.toolStripButtonProfit.Click += new System.EventHandler(this.toolStripButtonProfit_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(105, 24);
            this.toolStripLabel5.Text = "รายงานกำไรสุทธิ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1061, 596);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonInspect);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReceipt)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxPayType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonSummarize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private DataSetProdDetail dataSetProdDetail;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataSetProdDetailTableAdapters.ProductTableAdapter productTableAdapter;
        private DataSetProdDetailTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productTypeTextBox;
        private System.Windows.Forms.TextBox productMaterialTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private DataSetProdList dataSetProdList;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DataSetProdListTableAdapters.ProductTableAdapter productTableAdapter1;
        private DataSetReceipt dataSetReceipt;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private DataSetReceiptTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInspect;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonProduct;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditMember;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEmp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrice;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonProfit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
    }
}

