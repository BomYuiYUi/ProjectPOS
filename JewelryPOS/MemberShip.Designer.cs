
namespace JewelryPOS
{
    partial class MemberShip
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxAddressTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(156, 215);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(329, 176);
            this.textBoxAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ที่อยู่จัดส่ง :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสสมาชิก :";
            // 
            // textBoxMemID
            // 
            this.textBoxMemID.Location = new System.Drawing.Point(156, 6);
            this.textBoxMemID.Name = "textBoxMemID";
            this.textBoxMemID.Size = new System.Drawing.Size(214, 34);
            this.textBoxMemID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ชื่อจริง :";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(156, 46);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(214, 34);
            this.textBoxFName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "นามสกุล :";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(156, 86);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(214, 34);
            this.textBoxLName.TabIndex = 3;
            // 
            // textBoxAddressTax
            // 
            this.textBoxAddressTax.Location = new System.Drawing.Point(560, 6);
            this.textBoxAddressTax.Multiline = true;
            this.textBoxAddressTax.Name = "textBoxAddressTax";
            this.textBoxAddressTax.Size = new System.Drawing.Size(321, 219);
            this.textBoxAddressTax.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "ที่อยู่ใบกำกับภาษี :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(156, 126);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(214, 34);
            this.textBoxEmail.TabIndex = 3;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Snow;
            this.buttonCheck.Location = new System.Drawing.Point(560, 231);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(191, 43);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "เช็คข้อมูล";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Snow;
            this.buttonInsert.Location = new System.Drawing.Point(560, 280);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(191, 43);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "สมัครสมาชิก";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "เบอร์โทร :";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(156, 166);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(214, 34);
            this.textBoxTel.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Snow;
            this.buttonClear.Location = new System.Drawing.Point(560, 329);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(191, 42);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(893, 409);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddressTax);
            this.Controls.Add(this.textBoxAddress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MemberShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สมัครสมาชิก";
            this.Load += new System.EventHandler(this.MemberShip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxAddressTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonClear;
    }
}