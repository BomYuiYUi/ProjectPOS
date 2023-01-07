
namespace JewelryPOS
{
    partial class PrintOrderPrice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFD = new System.Windows.Forms.DateTimePicker();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetOrder = new JewelryPOS.DataSetOrder();
            this.OrdersPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersPriceTableAdapter = new JewelryPOS.DataSetOrderTableAdapters.OrdersPriceTableAdapter();
            this.ordersPriceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPriceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "ยอดขายรายวัน",
            "ยอดขายรายสัปดาห์",
            "ยอดขายรายเดือน",
            "ยอดขายรายปี"});
            this.comboBoxDay.Location = new System.Drawing.Point(77, 31);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(153, 37);
            this.comboBoxDay.TabIndex = 1;
            // 
            // dateTimePickerFD
            // 
            this.dateTimePickerFD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFD.Location = new System.Drawing.Point(245, 34);
            this.dateTimePickerFD.Name = "dateTimePickerFD";
            this.dateTimePickerFD.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerFD.TabIndex = 2;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(473, 29);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(108, 39);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ordersPriceBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JewelryPOS.ReportPrice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 435);
            this.reportViewer1.TabIndex = 5;
            // 
            // DataSetOrder
            // 
            this.DataSetOrder.DataSetName = "DataSetOrder";
            this.DataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersPriceBindingSource
            // 
            this.OrdersPriceBindingSource.DataMember = "OrdersPrice";
            this.OrdersPriceBindingSource.DataSource = this.DataSetOrder;
            // 
            // OrdersPriceTableAdapter
            // 
            this.OrdersPriceTableAdapter.ClearBeforeFill = true;
            // 
            // ordersPriceBindingSource1
            // 
            this.ordersPriceBindingSource1.DataMember = "OrdersPrice";
            this.ordersPriceBindingSource1.DataSource = this.DataSetOrder;
            // 
            // PrintOrderPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 511);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dateTimePickerFD);
            this.Controls.Add(this.comboBoxDay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PrintOrderPrice";
            this.Text = "PrintOrderPrice";
            this.Load += new System.EventHandler(this.PrintOrderPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPriceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerFD;
        private System.Windows.Forms.Button buttonPrint;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdersPriceBindingSource;
        private DataSetOrder DataSetOrder;
        private DataSetOrderTableAdapters.OrdersPriceTableAdapter OrdersPriceTableAdapter;
        private System.Windows.Forms.BindingSource ordersPriceBindingSource1;
    }
}