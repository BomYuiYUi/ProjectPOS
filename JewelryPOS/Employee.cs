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
    public partial class Employee : Form
    {
        SqlConnection PosConnection;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEmployee.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSetEmployee.Employee);
            PosConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=JewelryDB;" +
            "User ID=user1;Password=mypass1");
            PosConnection.Open();

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBoxEmpID.Text);
            string b = Convert.ToString(textBoxFName.Text);
            string c = Convert.ToString(textBoxLName.Text);
            string d = Convert.ToString(textBoxPass.Text);
            string g = Convert.ToString(textBoxAddress.Text);
            if (a == "" || b == "" || c == "" || d == "" || g == "")
            {
                MessageBox.Show("ท่านกรอกข้อมูลไม่ครบ");
                return;
            }
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"INSERT INTO Employee(EmpID,EmpFName,EmpLName,EmpAddress,EmpPass) VALUES('{textBoxEmpID.Text}','{textBoxFName.Text}','{textBoxLName.Text}','{textBoxAddress.Text}','{textBoxPass.Text}')";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Fill(this.dataSetEmployee.Employee);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Update Employee set EmpFName = '{textBoxFName.Text}',EmpLName = '{textBoxLName.Text}',EmpAddress = '{textBoxAddress.Text}',EmpPass = '{textBoxPass.Text}' where EmpID ='{textBoxEmpID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Fill(this.dataSetEmployee.Employee);
            command.Dispose();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Employee where EmpID = '{textBoxEmpID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Fill(this.dataSetEmployee.Employee);
            command.Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxEmpID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxPass.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmpID.Text = "";
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxPass.Text = "";
            textBoxAddress.Text = "";
        }
    }
}
