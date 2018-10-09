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

namespace PWMS.InfoAddForm
{
    public partial class F_Address : DevExpress.XtraEditors.XtraForm
    {
        DataClass.MyMeans myMeans = new DataClass.MyMeans();
        ModuleClass.MyModule myModule = new ModuleClass.MyModule();
        public static DataSet MyDs_Grid;
        public static string Address_ID="";
        public F_Address()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Address_1.Text!="")
            {
                myModule.Part_SaveClass("ID,FName,FSex,Phone,Handset,WordPhone,QQ,E_Mail",Address_ID,"",this.groupBox1.Controls,"Address_", "tb_AddressBook", 8,int.Parse( this.Tag.ToString()));
                myMeans.Getcom(ModuleClass.MyModule.ADDs);
                this.Close();
            }
            else
            {
                MessageBox.Show("人员姓名不能为空。");
            }

        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_AddressList_Load(object sender, EventArgs e)
        {
           
            if (int.Parse(this.Tag.ToString())==1)
            {
                Address_ID = myModule.GetAutocoding("tb_AddressBook","ID");
               
            }
            if (int.Parse(this.Tag.ToString()) == 2)
            {
                MyDs_Grid = myMeans.GetDataSet("select ID,FName,FSex,Phone,Handset,WordPhone,QQ,E_Mail from tb_AddressBook where ID='" + ModuleClass.MyModule.Address_ID + "'", "tb_AddressBook");
                Address_ID = MyDs_Grid.Tables[0].Rows[0][0].ToString();
                Address_1.Text = MyDs_Grid.Tables[0].Rows[0][1].ToString();
                Address_2.Text = MyDs_Grid.Tables[0].Rows[0][2].ToString();
                Address_3.Text = MyDs_Grid.Tables[0].Rows[0][3].ToString();
                Address_4.Text = MyDs_Grid.Tables[0].Rows[0][4].ToString();
                Address_5.Text = MyDs_Grid.Tables[0].Rows[0][5].ToString();
                Address_6.Text = MyDs_Grid.Tables[0].Rows[0][6].ToString();
                Address_7.Text = MyDs_Grid.Tables[0].Rows[0][7].ToString();
            }
        }
        /// <summary>
        /// cbox模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_2_TextChanged(object sender, EventArgs e)
        {
            //string FindText = Address_2.Text;
            //int index = Address_2.FindString(FindText);
            //if (index>=0)
            //{
            //    Address_2.SelectedIndex = index;
            //    Address_2.Select(FindText.Length,Address_2.Text.Length);
            //}
        }
        /// <summary>
        /// xbox文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Address_2_TextUpdate(object sender, EventArgs e)
        {

        }
    }
}