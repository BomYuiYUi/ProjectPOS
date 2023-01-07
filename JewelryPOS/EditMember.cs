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
    public partial class EditMember : Form
    {
        SqlConnection PosConnection;
        public EditMember()
        {
            InitializeComponent();
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMember.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.dataSetMember.Member);
            PosConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=JewelryDB;" +
            "User ID=user1;Password=mypass1");
            PosConnection.Open();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBoxMemID.Text);
            string b = Convert.ToString(textBoxFName.Text);
            string c = Convert.ToString(textBoxLName.Text);
            string d = Convert.ToString(textBoxTel.Text);
            string g = Convert.ToString(textBoxTel.Text);
            string f = Convert.ToString(textBoxAddress.Text);
            if (a == "" || b == "" || c == "" || d == "" || g == "" || f == "")
            {
                MessageBox.Show("ท่านกรอกข้อมูลไม่ครบ");
                return;
            }
            SqlCommand command3;
            SqlDataReader dataReader3;
            string strSQL = $"Select MemberID from Member where MemberID = '{textBoxMemID.Text}' ";
            command3 = new SqlCommand(strSQL, PosConnection);
            dataReader3 = command3.ExecuteReader();
            if (dataReader3.Read())
            {
                MessageBox.Show("ไอดีนี้มีคนใช้แล้ว");
                textBoxMemID.Text = "";
                dataReader3.Close();
                return;
            }
            dataReader3.Close();
            string Id, Fname, Lname, email, tel, add, addTax;
            Id = textBoxMemID.Text.ToString();
            Fname = textBoxFName.Text.ToString();
            Lname = textBoxLName.Text.ToString();
            email = textBoxEmail.Text.ToString();
            tel = textBoxTel.Text.ToString();
            add = textBoxAddress.Text.ToString();
            addTax = textBoxAddressTax.Text.ToString();
            string result = $"ไอดี : {Id}\n" +
                $"ชื่อจริง : {Fname}   นามสกุล : {Lname}\n" +
                $"Email : {email}   \nเบอร์โทร : {tel}\n" +
                $"ที่อยู่ : {add} \n" +
                $"ที่อยู่ออกใบกำกับภาษี : {addTax}";
            MessageBox.Show(result);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBoxMemID.Text);
            string b = Convert.ToString(textBoxFName.Text);
            string c = Convert.ToString(textBoxLName.Text);
            string d = Convert.ToString(textBoxTel.Text);
            string g = Convert.ToString(textBoxEmail.Text);
            string f = Convert.ToString(textBoxAddress.Text);
            if (a == "" || b == "" || c == "" || d == "" || g == "" || f == "")
            {
                MessageBox.Show("ท่านกรอกข้อมูลไม่ครบ");
                return;
            }
            string Check = "Unlock";
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"INSERT INTO Member(MemberID,MemberFName,MemberLName,MemberEmail,MemberAddressSend,MemberAddressTax,MemberTel,MemberLock) " +
                $"VALUES('{textBoxMemID.Text}','{textBoxFName.Text}','{textBoxLName.Text}','{textBoxEmail.Text}','{textBoxAddress.Text}','{textBoxAddressTax.Text}','{textBoxTel.Text}','{Check}')";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.dataSetMember.Member);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Update Member set MemberFName = '{textBoxFName.Text}',MemberLName = '{textBoxLName.Text}',MemberEmail = '{textBoxEmail.Text}',MemberAddressSend = '{textBoxAddress.Text}',MemberAddressTax = '{textBoxAddressTax.Text}',MemberTel = '{textBoxTel.Text}' where MemberID='{textBoxMemID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.dataSetMember.Member);
            command.Dispose();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxLock.SelectedIndex);
            string status = "";
            if(i == -1)
            {
                MessageBox.Show("ท่านไม่ได้เลือกสถานะ");
            }
            else if (i ==0)
            {
                status = "Unlock";
            }
            else if (i == 1)
            {
                status = "Lock";
            }
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Update Member set MemberLock = '{status}' where MemberID='{textBoxMemID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.dataSetMember.Member);
            command.Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxMemID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxAddressTax.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Member where MemberID = '{textBoxMemID.Text}'";
            command = new SqlCommand(sql, PosConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.memberTableAdapter.Fill(this.dataSetMember.Member);
            command.Dispose();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMemID.Text = "";
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxEmail.Text = "";
            textBoxTel.Text = "";
            textBoxAddress.Text = "";
            textBoxAddressTax.Text = "";
        }
    }
}
