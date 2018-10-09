namespace PWMS.PerForm
{
    partial class F_AddressList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSelectj = new System.Windows.Forms.Label();
            this.lblSelectType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDataTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Address_Quit = new System.Windows.Forms.Button();
            this.Address_Delete = new System.Windows.Forms.Button();
            this.Address_Amend = new System.Windows.Forms.Button();
            this.Address_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblSelectj);
            this.groupBox1.Controls.Add(this.lblSelectType);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(460, 25);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(43, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "全部";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(410, 25);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(43, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lblSelectj
            // 
            this.lblSelectj.AutoSize = true;
            this.lblSelectj.Location = new System.Drawing.Point(232, 30);
            this.lblSelectj.Name = "lblSelectj";
            this.lblSelectj.Size = new System.Drawing.Size(67, 14);
            this.lblSelectj.TabIndex = 3;
            this.lblSelectj.Text = "查询条件：";
            // 
            // lblSelectType
            // 
            this.lblSelectType.AutoSize = true;
            this.lblSelectType.Location = new System.Drawing.Point(29, 30);
            this.lblSelectType.Name = "lblSelectType";
            this.lblSelectType.Size = new System.Drawing.Size(59, 14);
            this.lblSelectType.TabIndex = 2;
            this.lblSelectType.Text = "查询类型:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "姓名",
            "性别",
            "邮箱地址"});
            this.comboBox1.Location = new System.Drawing.Point(94, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 170);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDataTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 170);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据表";
            // 
            // dgvDataTable
            // 
            this.dgvDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataTable.Location = new System.Drawing.Point(3, 18);
            this.dgvDataTable.Name = "dgvDataTable";
            this.dgvDataTable.RowTemplate.Height = 23;
            this.dgvDataTable.Size = new System.Drawing.Size(539, 149);
            this.dgvDataTable.TabIndex = 0;
            this.dgvDataTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTable_CellEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Address_Quit);
            this.panel2.Controls.Add(this.Address_Delete);
            this.panel2.Controls.Add(this.Address_Amend);
            this.panel2.Controls.Add(this.Address_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 81);
            this.panel2.TabIndex = 2;
            // 
            // Address_Quit
            // 
            this.Address_Quit.Location = new System.Drawing.Point(410, 32);
            this.Address_Quit.Name = "Address_Quit";
            this.Address_Quit.Size = new System.Drawing.Size(75, 23);
            this.Address_Quit.TabIndex = 3;
            this.Address_Quit.Text = "退出";
            this.Address_Quit.UseVisualStyleBackColor = true;
            this.Address_Quit.Click += new System.EventHandler(this.Address_Quit_Click);
            // 
            // Address_Delete
            // 
            this.Address_Delete.Location = new System.Drawing.Point(290, 32);
            this.Address_Delete.Name = "Address_Delete";
            this.Address_Delete.Size = new System.Drawing.Size(75, 23);
            this.Address_Delete.TabIndex = 2;
            this.Address_Delete.Text = "删除";
            this.Address_Delete.UseVisualStyleBackColor = true;
            this.Address_Delete.Click += new System.EventHandler(this.Address_Delete_Click);
            // 
            // Address_Amend
            // 
            this.Address_Amend.Location = new System.Drawing.Point(162, 32);
            this.Address_Amend.Name = "Address_Amend";
            this.Address_Amend.Size = new System.Drawing.Size(75, 23);
            this.Address_Amend.TabIndex = 1;
            this.Address_Amend.Text = "修改";
            this.Address_Amend.UseVisualStyleBackColor = true;
            this.Address_Amend.Click += new System.EventHandler(this.Address_Amend_Click);
            // 
            // Address_Add
            // 
            this.Address_Add.Location = new System.Drawing.Point(45, 32);
            this.Address_Add.Name = "Address_Add";
            this.Address_Add.Size = new System.Drawing.Size(75, 23);
            this.Address_Add.TabIndex = 0;
            this.Address_Add.Text = "增加";
            this.Address_Add.UseVisualStyleBackColor = true;
            this.Address_Add.Click += new System.EventHandler(this.Address_Add_Click);
            // 
            // F_AddressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(545, 325);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "F_AddressList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_AddressList";
            this.Load += new System.EventHandler(this.F_AddressList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSelectj;
        private System.Windows.Forms.Label lblSelectType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Address_Quit;
        private System.Windows.Forms.Button Address_Delete;
        private System.Windows.Forms.Button Address_Amend;
        private System.Windows.Forms.Button Address_Add;
        private System.Windows.Forms.DataGridView dgvDataTable;
    }
}