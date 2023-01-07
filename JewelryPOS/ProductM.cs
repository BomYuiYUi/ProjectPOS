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
    public partial class ProductM : Form
    {
        SqlConnection PosConnection;
        public ProductM()
        {
            InitializeComponent();
        }
        int ProdID = 0, ReceID =0;

        private void ProductM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataSetProduct.Product);
            PosConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=JewelryDB;" +
            "User ID=user1;Password=mypass1");
            PosConnection.Open();
        }
        private void GetPrductID()
        {
            string query = "Select ProductID From Product order by ProductID desc";
            SqlCommand com0;
            SqlDataReader reader0;
            com0 = new SqlCommand(query, PosConnection);
            reader0 = com0.ExecuteReader();
            if (reader0.Read())
            {
                int id = int.Parse(reader0[0].ToString()) + 1;
                ProdID = id;
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            GetPrductID();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"INSERT INTO Product(ProductID,ProductName,ProductType,ProductMaterial,ProductCost,ProductPrice) " +
                $"VALUES('{ProdID}','{textBoxName.Text}','{textBoxType.Text}','{textBoxM.Text}','{textBoxCost.Text}','{textBoxPrice.Text}')";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.productTableAdapter.Fill(this.dataSetProduct.Product);
            command.Dispose();
            textBoxID.Text = ProdID.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Update Product set ProductName = '{textBoxName.Text}',ProductType = '{textBoxType.Text}',ProductMaterial = '{textBoxM.Text}',ProductCost = '{textBoxCost.Text}',ProductPrice = '{textBoxPrice.Text}' where ProductID ='{textBoxID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.productTableAdapter.Fill(this.dataSetProduct.Product);
            command.Dispose();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Product where ProductID = '{textBoxID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.productTableAdapter.Fill(this.dataSetProduct.Product);
            command.Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxM.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxCost.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void ProductM_FormClosing(object sender, FormClosingEventArgs e)
        {
            PosConnection.Close();
            PosConnection.Dispose();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxType.Text = "";
            textBoxM.Text = "";
            textBoxCost.Text = "";
            textBoxPrice.Text = "";
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
            int quan = 1;

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
            command.Dispose();
        }
    }
}
