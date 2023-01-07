
namespace JewelryPOS
{
    partial class PrintOrderProfit
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
            this.ordersProfitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetOrder = new JewelryPOS.DataSetOrder();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdersProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersProfitTableAdapter = new JewelryPOS.DataSetOrderTableAdapters.OrdersProfitTableAdapter();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dateTimePickerFD = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersProfitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersProfitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersProfitBindingSource1
            // 
            this.ordersProfitBindingSource1.DataMember = "OrdersProfit";
            this.ordersProfitBindingSource1.DataSource = this.DataSetOrder;
            // 
            // DataSetOrder
            // 
            this.DataSetOrder.DataSetName = "DataSetOrder";
            this.DataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ordersProfitBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JewelryPOS.ReportProfit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(854, 353);
            this.reportViewer1.TabIndex = 0;
            // 
            // OrdersProfitBindingSource
            // 
            this.OrdersProfitBindingSource.DataMember = "OrdersProfit";
            this.OrdersProfitBindingSource.DataSource = this.DataSetOrder;
            // 
            // OrdersProfitTableAdapter
            // 
            this.OrdersProfitTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(448, 27);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(108, 39);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dateTimePickerFD
            // 
            this.dateTimePickerFD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFD.Location = new System.Drawing.Point(220, 32);
            this.dateTimePickerFD.Name = "dateTimePickerFD";
            this.dateTimePickerFD.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerFD.TabIndex = 6;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "ยอดกำไรสุทธิรายวัน",
            "ยอดกำไรสุทธิรายสัปดาห์",
            "ยอดกำไรสุทธิรายเดือน",
            "ยอดกำไรสุทธิรายปี"});
            this.comboBoxDay.Location = new System.Drawing.Point(12, 29);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(193, 37);
            this.comboBoxDay.TabIndex = 5;
            // 
            // PrintOrderProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 439);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dateTimePickerFD);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PrintOrderProfit";
            this.Text = "PrintOrderProfit";
            this.Load += new System.EventHandler(this.PrintOrderProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersProfitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersProfitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdersProfitBindingSource;
        private DataSetOrder DataSetOrder;
        private DataSetOrderTableAdapters.OrdersProfitTableAdapter OrdersProfitTableAdapter;
        private System.Windows.Forms.BindingSource ordersProfitBindingSource1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DateTimePicker dateTimePickerFD;
        private System.Windows.Forms.ComboBox comboBoxDay;
    }
}