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
    public partial class FromLogin : Form
    {
        SqlConnection PosConnection;
        public FromLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command1;
            SqlDataReader dataReader;
            String strSQL;
            string Name = "", LName = "";
            strSQL = $"Select EmpID,EmpFName,EmpLName from Employee where EmpID ='{textBoxUser.Text}' and EmpPass ='{textBoxPass.Text}'";
            command1 = new SqlCommand(strSQL, PosConnection);
            dataReader = command1.ExecuteReader();
            string user = Convert.ToString(textBoxUser.Text);
            string pass = Convert.ToString(textBoxPass.Text);
            if (user == "admin" && pass == "admin")
            {
                PosConnection.Dispose();
                dataReader.Close();
                GetValue.EnID = "EMP001";
                using (MainMenu MM = new MainMenu())
                {
                    MM.ShowDialog();
                }
                this.Close();
            }
            else
            {
                if (dataReader.Read())
                {
                    GetValue.EnID = Convert.ToString(dataReader.GetValue(0));
                    Name = Convert.ToString(dataReader.GetValue(1));
                    LName = Convert.ToString(dataReader.GetValue(2));
                    MessageBox.Show($"ยินต้อนรับคุณ {Name} {LName}");
                    dataReader.Close();
                    using (MainMenu MM = new MainMenu())
                    {
                        MM.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("ไอดีหรือรหัสผ่านไม่ถูกต้อง");
                    dataReader.Close();
                }
                dataReader.Close();
            }
        }

        private void FromLogin_Load(object sender, EventArgs e)
        {
            PosConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=JewelryDB;" +
            "User ID=user1;Password=mypass1");
            PosConnection.Open();
        }
    }
}
