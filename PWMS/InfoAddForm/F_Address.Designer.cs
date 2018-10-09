namespace PWMS.InfoAddForm
{
    partial class F_Address
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Address_2 = new System.Windows.Forms.ComboBox();
            this.Address_7 = new System.Windows.Forms.TextBox();
            this.Address_6 = new System.Windows.Forms.TextBox();
            this.Address_5 = new System.Windows.Forms.TextBox();
            this.Address_4 = new System.Windows.Forms.TextBox();
            this.Address_3 = new System.Windows.Forms.TextBox();
            this.Address_1 = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblQQ = new System.Windows.Forms.Label();
            this.lblJobTel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 261);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancle);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(371, 73);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Address_2);
            this.groupBox1.Controls.Add(this.Address_7);
            this.groupBox1.Controls.Add(this.Address_6);
            this.groupBox1.Controls.Add(this.Address_5);
            this.groupBox1.Controls.Add(this.Address_4);
            this.groupBox1.Controls.Add(this.Address_3);
            this.groupBox1.Controls.Add(this.Address_1);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblQQ);
            this.groupBox1.Controls.Add(this.lblJobTel);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯录信息";
            // 
            // Address_2
            // 
            this.Address_2.AutoCompleteCustomSource.AddRange(new string[] {
            "131231231"});
            this.Address_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Address_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Address_2.FormattingEnabled = true;
            this.Address_2.Items.AddRange(new object[] {
            "男",
            "女",
            "21312321312"});
            this.Address_2.Location = new System.Drawing.Point(197, 19);
            this.Address_2.Name = "Address_2";
            this.Address_2.Size = new System.Drawing.Size(48, 22);
            this.Address_2.TabIndex = 13;
            this.Address_2.TextUpdate += new System.EventHandler(this.Address_2_TextUpdate);
            this.Address_2.TextChanged += new System.EventHandler(this.Address_2_TextChanged);
            // 
            // Address_7
            // 
            this.Address_7.Location = new System.Drawing.Point(258, 81);
            this.Address_7.Name = "Address_7";
            this.Address_7.Size = new System.Drawing.Size(206, 22);
            this.Address_7.TabIndex = 12;
            // 
            // Address_6
            // 
            this.Address_6.Location = new System.Drawing.Point(52, 81);
            this.Address_6.Name = "Address_6";
            this.Address_6.Size = new System.Drawing.Size(149, 22);
            this.Address_6.TabIndex = 11;
            // 
            // Address_5
            // 
            this.Address_5.Location = new System.Drawing.Point(331, 47);
            this.Address_5.Name = "Address_5";
            this.Address_5.Size = new System.Drawing.Size(136, 22);
            this.Address_5.TabIndex = 10;
            // 
            // Address_4
            // 
            this.Address_4.Location = new System.Drawing.Point(52, 47);
            this.Address_4.Name = "Address_4";
            this.Address_4.Size = new System.Drawing.Size(193, 22);
            this.Address_4.TabIndex = 9;
            // 
            // Address_3
            // 
            this.Address_3.Location = new System.Drawing.Point(304, 19);
            this.Address_3.Name = "Address_3";
            this.Address_3.Size = new System.Drawing.Size(163, 22);
            this.Address_3.TabIndex = 8;
            // 
            // Address_1
            // 
            this.Address_1.Location = new System.Drawing.Point(52, 19);
            this.Address_1.Name = "Address_1";
            this.Address_1.Size = new System.Drawing.Size(100, 22);
            this.Address_1.TabIndex = 7;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(211, 84);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 14);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Location = new System.Drawing.Point(13, 84);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(29, 14);
            this.lblQQ.TabIndex = 5;
            this.lblQQ.Text = "QQ:";
            // 
            // lblJobTel
            // 
            this.lblJobTel.AutoSize = true;
            this.lblJobTel.Location = new System.Drawing.Point(266, 52);
            this.lblJobTel.Name = "lblJobTel";
            this.lblJobTel.Size = new System.Drawing.Size(59, 14);
            this.lblJobTel.TabIndex = 4;
            this.lblJobTel.Text = "工作电话:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 52);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 14);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "手机：";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(266, 22);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 14);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "电话：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(158, 22);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 14);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // F_Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.panel1);
            this.Name = "F_Address";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "F_Address";
            this.Load += new System.EventHandler(this.F_AddressList_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.Label lblJobTel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox Address_2;
        private System.Windows.Forms.TextBox Address_7;
        private System.Windows.Forms.TextBox Address_6;
        private System.Windows.Forms.TextBox Address_5;
        private System.Windows.Forms.TextBox Address_4;
        private System.Windows.Forms.TextBox Address_3;
        private System.Windows.Forms.TextBox Address_1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
    }
}