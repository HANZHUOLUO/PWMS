using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PWMS
{
    public partial class F_Login : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 实例化SQL公共类
        /// </summary>
        DataClass.MyMeans Means = new DataClass.MyMeans();
        public F_Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textName.Text.Trim() == string.Empty & textPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请将登录信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ///根据填写内容查询是否存在此用户
                SqlDataReader temDR = Means.Getcom("SELECT * FROM tb_Login WHERE Name='"+textName.Text.Trim()+"' AND Pass='"+textPwd.Text.Trim()+"'");
                bool ifcom = temDR.Read();
                if (ifcom)
                {
                    DataClass.MyMeans.Login_Name = textName.Text.Trim(); ///获取登录名
                    DataClass.MyMeans.Login_ID = temDR.GetString(0);///用户ID
                    DataClass.MyMeans.My_con.Close();///关闭数据库连接
                    DataClass.MyMeans.My_con.Dispose();///释放空间
                    DataClass.MyMeans.Login_n = (int)(this.Tag);///登录标识
                    this.Close();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误！","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ///清空用户名和密码
                    textName.Text = string.Empty;
                    textPwd.Text = string.Empty;
                }
                Means.Con_close();
            }

        }
        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            if ((int)(this.Tag) == 1)
            {
                DataClass.MyMeans.Login_n = 3;
                Application.Exit();
            }
            else
                if ((int)(this.Tag) == 2)
                this.Close();

        }
        /// <summary>
        /// 窗体的触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_Login_Activated(object sender, EventArgs e)
        {
            
            textName.Focus();///为用户名设置焦点
        }
        /// <summary>
        /// 用户名按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) {
                textPwd.Focus();///为密码设置焦点
            }
        }
        /// <summary>
        /// 密码案件事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) {
                btnLogin.Focus();///登陆按钮设置按键
            }
        }
        /// <summary>
        /// /窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_Login_Load(object sender, EventArgs e)
        {
            try
            {
                Means.Con_open();//连接数据库
                Means.Con_close();
                ///清空用户名和密码
                textName.Text = string.Empty;
                textPwd.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show("数据库连接失败！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

    
    }
}
