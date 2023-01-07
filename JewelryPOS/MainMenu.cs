using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JewelryPOS
{
    public partial class MainMenu : Form
    {
        SqlConnection PosConnection;
        int OrdID = 0, ReceID = 0,OrdDetail = 0,PaymID;
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReceipt.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            // TODO: This line of code loads data into the 'dataSetProdList.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.dataSetProdList.Product);
            PosConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=JewelryDB;" +
            "User ID=user1;Password=mypass1");
            PosConnection.Open();

        }

        private void GetPaymentID()
        {
            string query = "Select PaymentID From Payment order by PaymentID desc";
            SqlCommand com0;
            SqlDataReader reader0;
            com0 = new SqlCommand(query, PosConnection);
            reader0 = com0.ExecuteReader();
            if (reader0.Read())
            {
                int id = int.Parse(reader0[0].ToString()) + 1;
                PaymID = id;
            }
            reader0.Close();
        }













        private void GetReceiptID()
        {
            string query = "Select ReceiptID From Receipt order by ReceiptID desc";
            SqlCommand com0;
            SqlDataReader reader0;
            com0 = new SqlCommand(query, PosConnection);
            reader0 = com0.ExecuteReader();
            if (reader0.Read())
            {
                int id = int.Parse(reader0[0].ToString()) + 1;
                ReceID = id;
            }
            reader0.Close();
        }
        private void GetOrderDetailID()
        {
            string query = "Select OrderDetailID From OrderDetail order by OrderDetailID desc";
            SqlCommand com0;
            SqlDataReader reader0;
            com0 = new SqlCommand(query, PosConnection);
            reader0 = com0.ExecuteReader();
            if (reader0.Read())
            {
                int id = int.Parse(reader0[0].ToString()) + 1;
                OrdDetail = id;
            }
            reader0.Close();

        }
        private void GetOrderID()
        {
            string query = "Select OrderID From Orders order by OrderID desc";
            SqlCommand com0;
            SqlDataReader reader0;
            com0 =  new SqlCommand(query, PosConnection);
            reader0 = com0.ExecuteReader();
            if (reader0.Read())
            {
                int id = int.Parse(reader0[0].ToString()) + 1;
                OrdID = id;
            }
            reader0.Close();
        }
        private void Calculator()
        {
            SqlCommand command3;
            SqlDataReader dataReader3;
            double A = 0, PriceAll = 0;
            string strSQL = $"Select ReceiptPrice from Receipt";
            command3 = new SqlCommand(strSQL, PosConnection);
            dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                A = Convert.ToDouble(dataReader3.GetValue(0));
                PriceAll += A;
            }
            double tax = PriceAll * 0.02;
            double total = PriceAll + tax;
            textBoxPrice.Text = Convert.ToString(PriceAll);
            textBoxTax.Text = Convert.ToString(tax);
            textBoxTotal.Text = Convert.ToString(total);
            dataReader3.Close();
        }
        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProID = Convert.ToInt32(listBoxProduct.SelectedValue);
            if (ProID == 0)
            {
                return;
            }
            this.productTableAdapter.Fill(this.dataSetProdDetail.Product, ((short)(System.Convert.ChangeType(listBoxProduct.SelectedValue, typeof(short)))));
            textBoxID.Text = Convert.ToString(ProID);
            textBoxQuantity.Text = "1";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strSQL;
            SqlCommand command2;
            SqlDataReader dataReader2;
            strSQL = $"Select ProductID from Receipt where ProductID ='{textBoxID.Text}'";
            command2 = new SqlCommand(strSQL, PosConnection);
            dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {

                MessageBox.Show("มีสินค้านี้อยู่ในตะกร้าแล้วถ้าต้องการเพิ่มสินค้าให้กดปุ่มเพิ่มจำนวนสินค้า");
                dataReader2.Close();
                return;
            }
            dataReader2.Close();
            SqlCommand command1;
            SqlDataReader dataReader;
            string Name = "";
            double Price = 0.00;
            double Cost = 0.00;
            strSQL = $"Select ProductName,ProductPrice,ProductCost from Product where ProductID ='{textBoxID.Text}'";
            command1 = new SqlCommand(strSQL, PosConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                Name = Convert.ToString(dataReader.GetValue(0));
                Price = Convert.ToDouble(dataReader.GetValue(1));
                Cost = Convert.ToDouble(dataReader.GetValue(2));
            }
            dataReader.Close();
            int quan = Convert.ToInt32(textBoxQuantity.Text);

            double PriceResult = Price * quan;
            double CostSum = Price - Cost;
            double CostResult = CostSum * quan;
            GetReceiptID();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"INSERT INTO Receipt(ReceiptID,ProductID,ProductName,ReceiptQuantity,ReceiptPrice,ReceiptProfit) " +
                $"VALUES('{ReceID}','{textBoxID.Text}','{Name}','{quan}','{PriceResult}','{CostResult}')";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            command.Dispose();

            Calculator();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command1;
            SqlDataReader dataReader;
            string Name = "";
            double Price = 0.00;
            double Cost = 0.00;
            string strSQL;
            strSQL = $"Select ProductName,ProductPrice,ProductCost from Product where ProductID ='{textBoxID.Text}'";
            command1 = new SqlCommand(strSQL, PosConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                Name = Convert.ToString(dataReader.GetValue(0));
                Price = Convert.ToDouble(dataReader.GetValue(1));
                Cost = Convert.ToDouble(dataReader.GetValue(2));
            }
            dataReader.Close();
            int quan = Convert.ToInt32(textBoxQuantity.Text);

            double PriceResult = Price * quan;
            double CostSum = Price - Cost;
            double CostResult = CostSum * quan;


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Update Receipt set ReceiptQuantity = '{textBoxQuantity.Text}',ReceiptPrice = '{PriceResult}',ReceiptProfit = '{CostResult}' where ProductID='{textBoxID.Text}' ";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            command.Dispose();
            Calculator();
        }

        private void dataGridViewReceipt_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridViewReceipt.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxQuantity.Text = dataGridViewReceipt.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Receipt";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            command.Dispose();
            Calculator();
        }

        private void buttonSummarize_Click(object sender, EventArgs e)
        {
            Calculator();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            int asum = listBoxProduct.Items.Count;
            int[] AID = new int[asum];
            SqlCommand commanw;
            SqlDataReader dataReadew;
            string strSQLL = $"Select ProductID from Product";
            commanw = new SqlCommand(strSQLL, PosConnection);
            dataReadew = commanw.ExecuteReader();
            int sum = 0;
            while (dataReadew.Read())
            {
                AID[sum] = Convert.ToInt32(dataReadew.GetValue(0));
                sum = sum + 1;
            }
            dataReadew.Close();


            for(int i = 0; i < asum; i++)
            {
                string strSQL;
                SqlCommand command2;
                SqlDataReader dataReader2;
                strSQL = $"Select ProductID from Receipt where ProductID ='{AID[i]}'";
                command2 = new SqlCommand(strSQL, PosConnection);
                dataReader2 = command2.ExecuteReader();
                if (dataReader2.Read())
                {
                    dataReader2.Close();
                    return;
                }
                dataReader2.Close();
                SqlCommand command1;
                SqlDataReader dataReader;
                string Name = "";
                double Price = 0.00;
                double Cost = 0.00;
                strSQL = $"Select ProductName,ProductPrice,ProductCost from Product where ProductID ='{AID[i]}'";
                command1 = new SqlCommand(strSQL, PosConnection);
                dataReader = command1.ExecuteReader();
                if (dataReader.Read())
                {
                    Name = Convert.ToString(dataReader.GetValue(0));
                    Price = Convert.ToDouble(dataReader.GetValue(1));
                    Cost = Convert.ToDouble(dataReader.GetValue(2));
                }
                dataReader.Close();
                int quan = 1;

                double PriceResult = Price * quan;
                double CostSum = Price - Cost;
                double CostResult = CostSum * quan;
                GetReceiptID();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                var sql = $"INSERT INTO Receipt(ReceiptID,ProductID,ProductName,ReceiptQuantity,ReceiptPrice,ReceiptProfit) " +
                    $"VALUES('{ReceID}','{AID[i]}','{Name}','{quan}','{PriceResult}','{CostResult}')";
                command = new SqlCommand(sql, PosConnection);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
                command.Dispose();

                Calculator();


            }

        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            using (ProductM P1 = new ProductM())
            {
                P1.ShowDialog();
            }
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            this.productTableAdapter1.Fill(this.dataSetProdList.Product);
            Calculator();
        }

        private void toolStripButtonEditMember_Click(object sender, EventArgs e)
        {
            using (EditMember edit = new EditMember())
            {
                edit.ShowDialog();
            }
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            this.productTableAdapter1.Fill(this.dataSetProdList.Product);
            Calculator();
        }

        private void toolStripButtonEmp_Click(object sender, EventArgs e)
        {
            using (Employee emp = new Employee())
            {
                emp.ShowDialog();
            }
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            this.productTableAdapter1.Fill(this.dataSetProdList.Product);
            Calculator();
        }

        private void toolStripButtonPrice_Click(object sender, EventArgs e)
        {
            using (PrintOrderPrice orderPrice = new PrintOrderPrice())
            {
                orderPrice.ShowDialog();
            }
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            this.productTableAdapter1.Fill(this.dataSetProdList.Product);
            Calculator();
        }

        private void toolStripButtonProfit_Click(object sender, EventArgs e)
        {
            using (PrintOrderProfit orderProfit = new PrintOrderProfit())
            {
                orderProfit.ShowDialog();
            }
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            this.productTableAdapter1.Fill(this.dataSetProdList.Product);
            Calculator();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Receipt where ProductID = '{textBoxID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            command.Dispose();
            Calculator();
        }

        private void buttonInspect_Click(object sender, EventArgs e)
        {
            SqlCommand comman;
            SqlDataReader dataReade;
            string Check1 = "";
            string strSQLL = $"Select MemberLock from Member where MemberID = '{textBoxMemID.Text}'";
            comman = new SqlCommand(strSQLL, PosConnection);
            dataReade = comman.ExecuteReader();
            if (dataReade.Read())
            {
                Check1 = Convert.ToString(dataReade.GetValue(0));
            }
            dataReade.Close();
            if (Check1 == "Lock")
            {
                MessageBox.Show("ไอดีลูกค้าท่านนี้ล็อคไว้ไม่สามารถใช่ได้");
                textBoxMemID.Text = "";
                return;
            }
            else
            {
                string Mem = Convert.ToString(textBoxMemID.Text);
                if (Mem == "")
                {
                    return;
                }
                else
                {
                    SqlCommand command3;
                    SqlDataReader dataReader3;
                    string FName = "", LName = "";
                    string strSQL = $"Select MemberFName,MemberLName from Member where MemberID = '{textBoxMemID.Text}'";
                    command3 = new SqlCommand(strSQL, PosConnection);
                    dataReader3 = command3.ExecuteReader();
                    if (dataReader3.Read())
                    {
                        FName = Convert.ToString(dataReader3.GetValue(0));
                        LName = Convert.ToString(dataReader3.GetValue(1));
                        MessageBox.Show($"คุณ {FName} {LName}");
                        dataReader3.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("ไม่มีสมาชิกท่านนี้");
                        dataReader3.Close();
                        return;
                    }
                }
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            //Check
            string checkID = Convert.ToString(textBoxMemID.Text);
            SqlCommand comman;
            SqlDataReader dataReade;
            string Check1 = "";
            string strSQLL = $"Select MemberLock from Member where MemberID = '{textBoxMemID.Text}'";
            comman = new SqlCommand(strSQLL, PosConnection);
            dataReade = comman.ExecuteReader();
            if (dataReade.Read())
            {
                Check1 = Convert.ToString(dataReade.GetValue(0));
            }
            dataReade.Close();
            if (Check1 == "Lock")
            {
                MessageBox.Show("ไอดีลูกค้าท่านนี้ล็อคไว้ไม่สามารถใช่ได้");
                textBoxMemID.Text = "";
                return;
            }
            string EmpID = GetValue.EnID;//"EMP001";//GetValue.EnID;
            int PayT = Convert.ToInt32(comboBoxPayType.SelectedIndex);
            double total = Convert.ToDouble(textBoxTotal.Text);
            double all = 0.00;
            if(PayT == -1)
            {
                MessageBox.Show("ท่านไม่ได้เลือกประเภทการชำระ");
                return;
            }
            else if(PayT == 0)
            {
                double money = Convert.ToDouble(textBoxMoney.Text);
                if (total > money)
                {
                    MessageBox.Show("จำนวนเงินไม่ครบ");
                    return;
                }
                all = money - total;
                textBoxChange.Text = Convert.ToString(all);
            }
            else
            {
                textBoxMoney.Text = Convert.ToString(all);
                all = all - total;
                int result = Convert.ToInt32(all);
                textBoxChange.Text = Convert.ToString(result);
            }
            //Check


            //Order
            SqlCommand command3;
            SqlDataReader dataReader3;
            double A = 0, Profit = 0;
            string strSQL = $"Select ReceiptProfit from Receipt";
            command3 = new SqlCommand(strSQL, PosConnection);
            dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                A = Convert.ToDouble(dataReader3.GetValue(0));
                Profit += A;
            }
            dataReader3.Close();
            GetOrderID();
            dateTimePicker.Value = DateTime.Today;
            string Date = dateTimePicker.Value.Day.ToString();
            string Month = dateTimePicker.Value.Month.ToString();
            string Year = dateTimePicker.Value.Year.ToString();
            string Today = Month + "/" + Date + "/" + Year;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = "";
            if (checkID == "")
            {
                sql = $"INSERT INTO Orders(OrderID,EmpID,OrderDate,OrderPrice,OrderProfit,OrderTax) " +
                  $"VALUES('{OrdID}','{EmpID}','{Today}','{textBoxPrice.Text}','{Profit}','{textBoxTax.Text}')";
            }
            else
            {
                sql = $"INSERT INTO Orders(OrderID,MemberID,EmpID,OrderDate,OrderPrice,OrderProfit,OrderTax) " +
                  $"VALUES('{OrdID}','{textBoxMemID.Text}','{EmpID}','{Today}','{textBoxPrice.Text}','{Profit}','{textBoxTax.Text}')";
            }
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            command.Dispose();
            //Order

            //OrderDetail
            int rowC = Convert.ToInt32(dataGridViewReceipt.Rows.Count);
            int[] ID = new int[rowC];
            int[] Qu = new int[rowC];
            double[] Pr = new double[rowC];
            SqlCommand command4;
            SqlDataReader dataReader4;
            int PID = 0, Qua = 0;
            double Pri = 0;
            strSQL = $"Select ProductID,ReceiptQuantity,ReceiptPrice from Receipt";
            command4 = new SqlCommand(strSQL, PosConnection);
            int reads = 0;
            dataReader4 = command4.ExecuteReader();
            while (dataReader4.Read())
            {
                PID = Convert.ToInt32(dataReader4.GetValue(0));
                Qua = Convert.ToInt32(dataReader4.GetValue(1));
                Pri = Convert.ToDouble(dataReader4.GetValue(2));
                ID[reads] = PID;
                Qu[reads] = Qua;
                Pr[reads] = Pri;
                reads = reads + 1;
            }
            dataReader4.Close();
            for(int i = 0; i < rowC; i++)
            {
                GetOrderDetailID();
                SqlCommand command1;
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                var sql1 = $"INSERT INTO OrderDetail(OrderDetailID,OrderID,ProductID,Quantity,OrderDetailSum) " +
                    $"VALUES('{OrdDetail}','{OrdID}','{ID[i]}','{Qu[i]}','{Pr[i]}')";
                command1 = new SqlCommand(sql1, PosConnection);
                adapter1.InsertCommand = command1;
                adapter1.InsertCommand.ExecuteNonQuery();
                this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
                command1.Dispose();
            }
            //OrderDetail



            //Payment
            string PayType = "";

            if(PayT == 0)
            {
                PayType = "เงินสด";

            }
            else if (PayT == 1)
            {
                PayType = "บัตรเคดิต";

            }
            else if (PayT == 2)
            {
                PayType = "โอนเงิน";
            }
            GetPaymentID();
            SqlCommand command5;
            SqlDataAdapter adapter5 = new SqlDataAdapter();
            var sql2 = $"INSERT INTO Payment(PaymentID,OrderID,PaymentType,PaymentAmount) " +
                $"VALUES('{PaymID}','{OrdID}','{PayType}','{textBoxTotal.Text}')";
            command5 = new SqlCommand(sql2, PosConnection);
            adapter5.InsertCommand = command5;
            adapter5.InsertCommand.ExecuteNonQuery();
            this.receiptTableAdapter.Fill(this.dataSetReceipt.Receipt);
            command5.Dispose();
            //Payment


        }
    }
}
