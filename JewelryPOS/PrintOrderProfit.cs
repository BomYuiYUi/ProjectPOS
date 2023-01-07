using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryPOS
{
    public partial class PrintOrderProfit : Form
    {
        public PrintOrderProfit()
        {
            InitializeComponent();
        }

        private void PrintOrderProfit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetOrder.OrdersProfit' table. You can move, or remove it, as needed.
            //this.OrdersProfitTableAdapter.Fill(this.DataSetOrder.OrdersProfit);

            //this.reportViewer1.RefreshReport();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(comboBoxDay.SelectedIndex);
            string b = "", c = "", h = "", fd = "", ld = "";
            if (a == -1)
            {
                MessageBox.Show("ท่านไม่ได้เลือกประเภทยอดขายด้านหน้า");
                return;
            }
            else if (a == 0)
            {
                string Date = dateTimePickerFD.Value.Day.ToString();
                string Month = dateTimePickerFD.Value.Month.ToString();
                string Year = dateTimePickerFD.Value.Year.ToString();
                int yeartrue = Convert.ToInt32(Year);
                string use = Date + "/" + Month + "/" + yeartrue;
                yeartrue = yeartrue + 543;
                Year = Convert.ToString(yeartrue);
                string All = Year + "-" + Month + "-" + Date;
                b = All;
                c = All;
                fd = use;
                ld = use;
                h = "รายวัน";
            }
            else if (a == 1)
            {
                string Date = dateTimePickerFD.Value.Day.ToString();
                string Month = dateTimePickerFD.Value.Month.ToString();
                string Year = dateTimePickerFD.Value.Year.ToString();
                int monthtrue = Convert.ToInt32(Month);
                int datetrue = Convert.ToInt32(Date);
                int yeartrue = Convert.ToInt32(Year);
                int years = yeartrue;
                int days = System.DateTime.DaysInMonth(yeartrue, monthtrue);
                datetrue = datetrue + 6;
                if (datetrue > days)
                {
                    datetrue = datetrue - days;
                    monthtrue = monthtrue + 1;
                    if (monthtrue > 12)
                    {
                        //years = years + 1;
                        monthtrue = 1;
                        years = yeartrue;
                        yeartrue = yeartrue + 1;
                    }
                }
                int fy = years;
                int ly = yeartrue;
                years = years + 543;
                yeartrue = yeartrue + 543;
                string Month1 = Convert.ToString(monthtrue);
                string Date1 = Convert.ToString(datetrue);
                string Year1 = Convert.ToString(yeartrue);
                Year = Convert.ToString(years);
                string sfy = Convert.ToString(fy);
                string sly = Convert.ToString(ly);
                string All = Year + "-" + Month + "-" + Date;
                string All1 = Year1 + "-" + Month1 + "-" + Date1;
                string use = Date + "/" + Month + "/" + sfy;
                string use1 = Date1 + "/" + Month1 + "/" + sly;
                fd = use;
                ld = use1;
                b = All;
                c = All1;
                h = "รายสัปดาห์";
            }
            else if (a == 2)
            {

                //string Date = dateTimePickerFD.Value.Day.ToString();
                string Month = dateTimePickerFD.Value.Month.ToString();
                string Year = dateTimePickerFD.Value.Year.ToString();
                int datef = 1;
                int Mouthtrue = Convert.ToInt32(Month);
                int yeartrue = Convert.ToInt32(Year);
                int days = System.DateTime.DaysInMonth(yeartrue, Mouthtrue);
                int years = yeartrue;
                yeartrue = yeartrue + 543;
                Year = Convert.ToString(yeartrue);
                string All = Year + "-" + Month + "-" + datef;
                string All1 = Year + "-" + Month + "-" + days;
                string use = datef + "/" + Month + "/" + years;
                string use1 = days + "/" + Month + "/" + years;
                fd = use;
                ld = use1;
                b = All;
                c = All1;
                h = "รายเดือน";
            }
            else if (a == 3)
            {
                string Month = "1";
                string Date = "1";
                string Month1 = "12";
                string Date1 = "31";
                string Year = dateTimePickerFD.Value.Year.ToString();
                int yeartrue = Convert.ToInt32(Year);
                int years = yeartrue;
                yeartrue = yeartrue + 543;
                Year = Convert.ToString(yeartrue);
                string All = Year + "-" + Month + "-" + Date;
                string All1 = Year + "-" + Month1 + "-" + Date1;
                string use = Date + "/" + Month + "/" + years;
                string use1 = Date1 + "/" + Month1 + "/" + years;
                fd = use;
                ld = use1;
                b = All;
                c = All1;
                h = "รายปี";
            }
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Phead",h),
                new Microsoft.Reporting.WinForms.ReportParameter("Pfd",fd),
                new Microsoft.Reporting.WinForms.ReportParameter("Pld",ld)
            };

            this.reportViewer1.LocalReport.SetParameters(para);
            this.OrdersProfitTableAdapter.Fill(this.DataSetOrder.OrdersProfit,b,c);
            this.reportViewer1.RefreshReport();
        }
    }
}
