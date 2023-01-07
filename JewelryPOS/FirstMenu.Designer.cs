
namespace JewelryPOS
{
    partial class FirstMenu
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
            this.buttonMember = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMember
            // 
            this.buttonMember.BackColor = System.Drawing.Color.Snow;
            this.buttonMember.Location = new System.Drawing.Point(12, 71);
            this.buttonMember.Name = "buttonMember";
            this.buttonMember.Size = new System.Drawing.Size(306, 52);
            this.buttonMember.TabIndex = 0;
            this.buttonMember.Text = "สมัครสมาชิกสำหรับลูกค้า";
            this.buttonMember.UseVisualStyleBackColor = false;
            this.buttonMember.Click += new System.EventHandler(this.buttonMember_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Snow;
            this.buttonLogin.Location = new System.Drawing.Point(106, 13);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(122, 52);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "เข้าสู่ระบบ";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(331, 135);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FirstMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าแรก";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMember;
        private System.Windows.Forms.Button buttonLogin;
    }
}