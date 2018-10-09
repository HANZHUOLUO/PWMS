using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS.PerForm
{
    public partial class F_ClearData : Form
    {
        public F_ClearData()
        {
            InitializeComponent();
        }
        ///实例化公共类
        ModuleClass.MyModule MyModule = new ModuleClass.MyModule();
        /// <summary>
        /// 清空按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_clear_Click(object sender, EventArgs e)
        {
            MyModule.Clear_Table(groupBox1.Controls,"Table_");
        }
        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ALL_Table_MouseDown(object sender, MouseEventArgs e)
        {
            bool tt = false;
            if (((CheckBox)sender).Checked == true)
                tt = false;
            else
                tt = true;
            foreach (Control C in groupBox1.Controls)
            {
                string sID = C.Name;
                if (sID.IndexOf("Table_")>-1)
                {
                    ((CheckBox)C).Checked = tt;
                }
            }
        }
        /// <summary>
        /// 部门类别点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Table_Branch_MouseUp(object sender, MouseEventArgs e)
        {
            if (((CheckBox)sender).Checked==false)
            {
                ALL_Table.Checked = false;
            }
        }
        /// <summary>
        /// 退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
