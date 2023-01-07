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
    public partial class FirstMenu : Form
    {
        public FirstMenu()
        {
            InitializeComponent();
        }

        private void buttonMember_Click(object sender, EventArgs e)
        {
            using (MemberShip member = new MemberShip())
            {
                member.ShowDialog();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (FromLogin Lo = new FromLogin())
            {
                Lo.ShowDialog();
            }
        }
    }
}
