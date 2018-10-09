using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PWMS.PerForm
{
    public partial class F_AddressList : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 实例化SQL公共类
        /// </summary>
        DataClass.MyMeans myMeans = new DataClass.MyMeans();
        /// <summary>
        /// 实例化变量公共类
        /// </summary>
        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();
        public static DataSet MyDS_Grid;
        public static string AllSql = "Select ID,FName as 性名,FSex as 性别,Phone as 电话,WordPhone as 工作电话,Handset as 手机, QQ as QQ号,E_Mail as 邮箱地址 from tb_AddressBook";
        public static string Find_Field = "";///查询类型
        public F_AddressList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 自定义查询方法
        /// </summary>
        public void Show_All()
        {
            ModuleClass.MyModule.Address_ID = "";///通讯录修改时的ID
            ///调用datagridview控件显示职工名称
            MyDS_Grid = myMeans.GetDataSet(AllSql, "tb_AddressBook");///填充dataset对象
            dgvDataTable.DataSource = MyDS_Grid.Tables[0];
            dgvDataTable.Columns[0].Visible = false;///dgv第一列隐藏
            dgvDataTable.Rows[0].Selected = true;///默认选中第一行
            ///判断dgv是否有存在数据
            if (dgvDataTable.RowCount>1)
            {
                Address_Amend.Enabled = true; ///修改按钮可从操作
                Address_Delete.Enabled = true;///删除按钮可操作
            }
            else
            {
                Address_Amend.Enabled = false; ///修改按钮不可从操作
                Address_Delete.Enabled = false;///删除按钮不可操作

            }

        }
        /// <summary>
        /// 查询类型变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Find_Field = "FName";
                        break;
                    }
                case 1:
                    {
                        Find_Field = "FSex";
                        break;
                    }
                case 2:
                    {
                        Find_Field = "E_Mail";
                        break;
                    }

            }

        }
        /// <summary>
        /// 查询操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()==string.Empty)
            {
                MessageBox.Show("查询条件不能为空！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ModuleClass.MyModule.Address_ID = "";
            MyDS_Grid = myMeans.GetDataSet(AllSql+" where "+Find_Field+" like '%"+textBox1.Text.Trim()+"%'" , "tb_AddressBook");
            //用DataGridView控件显示职工的名称
            dgvDataTable.DataSource = MyDS_Grid.Tables[0];
            dgvDataTable.Columns[0].Visible = false;
            if (dgvDataTable.RowCount>1)
            {
                Address_Amend.Enabled = true;
                Address_Delete.Enabled = true;
            }
            else
            {
                Address_Amend.Enabled = false;
                Address_Delete.Enabled = false;
            }

        }
        /// <summary>
        /// 全部按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            Show_All();///显示所有通讯录表中的信息
        }


        /// <summary>
        /// 增加操作事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_Add_Click(object sender, EventArgs e)
        {
            InfoAddForm.F_Address f_Address = new InfoAddForm.F_Address();
            f_Address.Text = "通讯录添加操作";
            f_Address.Tag = 1;
            f_Address.ShowDialog(this);
            Show_All();
        }
               
        /// <summary>
        /// 修改操作事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_Amend_Click(object sender, EventArgs e)
        {
            InfoAddForm.F_Address f_Address = new InfoAddForm.F_Address();
            f_Address.Text = "通讯录修改操作";
            f_Address.Tag = 2;
            f_Address.ShowDialog(this);
            Show_All();
        }
         /// <summary>
        /// 删除操作事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                myMeans.Getcom("DELETE  tb_AddressBook WHERE ID = '"+ModuleClass.MyModule.Address_ID+" '");
                Show_All();
            }
        }
         /// <summary>
        /// 退出操作事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_AddressList_Load(object sender, EventArgs e)
        {
            Show_All();
        }
        /// <summary>
        /// 获取单元格焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDataTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataTable.RowCount>1)
            {
                ModuleClass.MyModule.Address_ID = dgvDataTable[0,dgvDataTable.CurrentCell.RowIndex].Value.ToString();
                Address_Amend.Enabled = true;
                Address_Delete.Enabled = true;
            }
            else
            {
                Address_Amend.Enabled = false;
                Address_Delete.Enabled = false;
            }
        }
    }
}