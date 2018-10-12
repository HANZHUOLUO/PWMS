using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PWMS.ModuleClass
{
    class MyModule
    {
        #region 公共变量
        DataClass.MyMeans MyDataClass = new DataClass.MyMeans();//声明MyMean类的一个对象，已调用其方法
        public static string ADDs = "";//用来存储添加或修改的sql语句
        public static string FindValue = "";//存储查询条件
        public static string Address_ID = "";//存储通讯录添加修改时的ID编号
        public static string User_ID = "";//存储用户的ID编号
        public static string User_Name = "";//存储用户名
        #endregion
        #region 窗体调用
        /// <summary>
        /// 窗体的调用.
        /// </summary>
        /// <param name="FrmName">调用窗体的Text属性值</param>
        /// <param name="n">标识</param>
        //public void Show_Form(string FrmName, int n)
        //{
        //    if (n == 1)
        //    {
        //        if (FrmName == "人事档案管理")  //判断当前要打开的窗体
        //        {
        //            PerForm.F_ManFile FrmManFile = new PWMS.PerForm.F_ManFile();
        //            FrmManFile.Text = "人事档案管理";   //设置窗体名称
        //            FrmManFile.ShowDialog();    //显示窗体
        //            FrmManFile.Dispose();
        //        }
        //        if (FrmName == "人事资料查询")
        //        {
        //            PerForm.F_Find FrmFind = new PWMS.PerForm.F_Find();
        //            FrmFind.Text = "人事资料查询";
        //            FrmFind.ShowDialog();
        //            FrmFind.Dispose();
        //        }
        //        if (FrmName == "人事资料统计")
        //        {
        //            PerForm.F_Stat FrmStat = new PWMS.PerForm.F_Stat();
        //            FrmStat.Text = "人事资料统计";
        //            FrmStat.ShowDialog();
        //            FrmStat.Dispose();
        //        }
        //        if (FrmName == "员工生日提示")
        //        {
        //            InfoAddForm.F_ClewSet FrmClewSet = new PWMS.InfoAddForm.F_ClewSet();
        //            FrmClewSet.Text = "员工生日提示";   //设置窗体名称
        //            FrmClewSet.Tag = 1; //设置窗体的Tag属性，用于在打开窗体时判断窗体的显示类形
        //            FrmClewSet.ShowDialog();    //显示窗体
        //            FrmClewSet.Dispose();
        //        }
        //        if (FrmName == "员工合同提示")
        //        {
        //            InfoAddForm.F_ClewSet FrmClewSet = new PWMS.InfoAddForm.F_ClewSet();
        //            FrmClewSet.Text = "员工合同提示";
        //            FrmClewSet.Tag = 2;
        //            FrmClewSet.ShowDialog();
        //            FrmClewSet.Dispose();
        //        }
        //        if (FrmName == "日常记事")
        //        {
        //            PerForm.F_WordPad FrmWordPad = new PWMS.PerForm.F_WordPad();
        //            FrmWordPad.Text = "日常记事";
        //            FrmWordPad.ShowDialog();
        //            FrmWordPad.Dispose();
        //        }
        //        if (FrmName == "通讯录")
        //        {
        //            PerForm.F_AddressList FrmAddressList = new PWMS.PerForm.F_AddressList();
        //            FrmAddressList.Text = "通讯录";
        //            FrmAddressList.ShowDialog();
        //            FrmAddressList.Dispose();
        //        }
        //        if (FrmName == "备份/还原数据库")
        //        {
        //            PerForm.F_HaveBack FrmHaveBack = new PWMS.PerForm.F_HaveBack();
        //            FrmHaveBack.Text = "备份/还原数据库";
        //            FrmHaveBack.ShowDialog();
        //            FrmHaveBack.Dispose();
        //        }
        //        if (FrmName == "清空数据库")
        //        {
        //            PerForm.F_ClearData FrmClearData = new PWMS.PerForm.F_ClearData();
        //            FrmClearData.Text = "清空数据库";
        //            FrmClearData.ShowDialog();
        //            FrmClearData.Dispose();
        //        }

        //        if (FrmName == "重新登录")
        //        {
        //            F_Login FrmLogin = new F_Login();
        //            FrmLogin.Tag = 2;
        //            FrmLogin.ShowDialog();
        //            FrmLogin.Dispose();
        //        }
        //        if (FrmName == "用户设置")
        //        {
        //            PerForm.F_User FrmUser = new PWMS.PerForm.F_User();
        //            FrmUser.Text = "用户设置";
        //            FrmUser.ShowDialog();
        //            FrmUser.Dispose();
        //        }
        //        if (FrmName == "计算器")
        //        {
        //            System.Diagnostics.Process.Start("calc.exe");
        //        }
        //        if (FrmName == "记事本")
        //        {
        //            System.Diagnostics.Process.Start("notepad.exe");
        //        }
        //        if (FrmName == "系统帮助")
        //        {
        //            System.Diagnostics.Process.Start("readme.doc");
        //        }
        //    }
        //    if (n == 2)
        //    {
        //        String FrmStr = ""; //记录窗体名称
        //        if (FrmName == "民族类别设置")  //判断要打开的窗体
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Folk";   //SQL语句
        //            DataClass.MyMeans.Mean_Table = "tb_Folk";   //表名
        //            DataClass.MyMeans.Mean_Field = "FolkName";  //添加、修改数据的字段名
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "职工类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_EmployeeGenre";
        //            DataClass.MyMeans.Mean_Table = "tb_EmployeeGenre";
        //            DataClass.MyMeans.Mean_Field = "EmployeeName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "文化程度设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Kultur";
        //            DataClass.MyMeans.Mean_Table = "tb_Kultur";
        //            DataClass.MyMeans.Mean_Field = "KulturName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "政治面貌设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Visage";
        //            DataClass.MyMeans.Mean_Table = "tb_Visage";
        //            DataClass.MyMeans.Mean_Field = "VisageName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "部门类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Branch";
        //            DataClass.MyMeans.Mean_Table = "tb_Branch";
        //            DataClass.MyMeans.Mean_Field = "BranchName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "工资类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Laborage";
        //            DataClass.MyMeans.Mean_Table = "tb_Laborage";
        //            DataClass.MyMeans.Mean_Field = "LaborageName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "职务类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Business";
        //            DataClass.MyMeans.Mean_Table = "tb_Business";
        //            DataClass.MyMeans.Mean_Field = "BusinessName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "职称类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_Duthcall";
        //            DataClass.MyMeans.Mean_Table = "tb_Duthcall";
        //            DataClass.MyMeans.Mean_Field = "DuthcallName";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "奖惩类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_RPKind";
        //            DataClass.MyMeans.Mean_Table = "tb_RPKind";
        //            DataClass.MyMeans.Mean_Field = "RPKind";
        //            FrmStr = FrmName;
        //        }
        //        if (FrmName == "记事本类别设置")
        //        {
        //            DataClass.MyMeans.Mean_SQL = "select * from tb_WordPad";
        //            DataClass.MyMeans.Mean_Table = "tb_WordPad";
        //            DataClass.MyMeans.Mean_Field = "WordPad";
        //            FrmStr = FrmName;
        //        }
        //        InfoAddForm.F_Basic FrmBasic = new PWMS.InfoAddForm.F_Basic();
        //        FrmBasic.Text = FrmStr; //设置窗体名称
        //        FrmBasic.ShowDialog();  //显示调用的窗体
        //        FrmBasic.Dispose();
        //    }
        //}

        #endregion
        #region  保存添加或修改的信息
        /// <summary>
        /// 保存添加或修改的信息.
        /// </summary>
        /// <param name="Sarr">数据表中的所有字段</param>
        /// <param name="ID1">第一个字段值</param>
        /// <param name="ID2">第二个字段值</param>
        /// <param name="Contr">指定控件的数据集</param>
        /// <param name="BoxName">要搜索的控件名称</param>
        /// <param name="TableName">数据表名称</param>
        /// <param name="n">控件的个数</param>
        /// <param name="m">标识，用于判断是添加还是修改</param>
        public void Part_SaveClass(string Sarr, string ID1, string ID2, Control.ControlCollection Contr, string BoxName, string TableName, int n, int m)
        {
            string tem_Field = "", tem_Value = "";
            int p = 2;
            if (m == 1)
            {    //当m为1时，表示添加数据信息
                if (ID1 != "" && ID2 == "")
                { //根据参数值判断添加的字段
                    tem_Field = "ID";
                    tem_Value = "'" + ID1 + "'";
                    p = 1;
                }
                else
                {
                    tem_Field = "Stu_ID,ID";
                    tem_Value = "'" + ID1 + "','" + ID2 + "'";
                }
            }
            else
                if (m == 2)
            {    //当m为2时，表示修改数据信息
                if (ID1 != "" && ID2 == "")
                { //根据参数值判断添加的字段
                    tem_Value = "ID='" + ID1 + "'";
                    p = 1;
                }
                else
                    tem_Value = "Stu_ID='" + ID1 + "',ID='" + ID2 + "'";
            }

            if (m > 0)
            { //生成部份添加、修改语句
                string[] Parr = Sarr.Split(Convert.ToChar(','));
                for (int i = p; i < n; i++)
                {
                    string sID = BoxName + i.ToString();    //通过BoxName参数获取要进行操作的控件名称
                    foreach (Control C in Contr)
                    {   //遍历控件集中的相关控件
                        if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                            if (C.Name == sID)
                            { //如果在控件集中找到相应的组件
                                string Ctext = C.Text;
                                if (C.GetType().Name == "MaskedTextBox")    //如果当前是MaskedTextBox控件
                                    Ctext = Date_Format(C.Text);    //对当前控件的值进行格式化
                                if (m == 1)
                                {    //组合SQL语句中insert的相关语句
                                    tem_Field = tem_Field + "," + Parr[i];
                                    if (Ctext == "")
                                        tem_Value = tem_Value + "," + "NULL";
                                    else
                                        tem_Value = tem_Value + "," + "'" + Ctext + "'";
                                }
                                if (m == 2)
                                {    //组合SQL语句中update的相关语句
                                    if (Ctext == "")
                                        tem_Value = tem_Value + "," + Parr[i] + "=NULL";
                                    else
                                        tem_Value = tem_Value + "," + Parr[i] + "='" + Ctext + "'";
                                }
                            }
                    }
                }
                ADDs = "";
                if (m == 1) //生成SQL的添加语句
                    ADDs = "insert into " + TableName + " (" + tem_Field + ") values(" + tem_Value + ")";
                if (m == 2) //生成SQL的修改语句
                    if (ID2 == "")  //根据ID2参数，判断修改语句的条件
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID1 + "'";
                    else
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID2 + "'";
            }
        }
        #endregion
        #region  将日期转换成指定的格式
        /// <summary>
        /// 将日期转换成yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <returns>返回String对象</returns>
        public string Date_Format(string NDate)
        {
            string sm, sd;
            int y, m, d;
            try
            {
                y = Convert.ToDateTime(NDate).Year;
                m = Convert.ToDateTime(NDate).Month;
                d = Convert.ToDateTime(NDate).Day;
            }
            catch
            {
                return "";
            }
            if (y == 1900)
                return "";
            if (m < 10)
                sm = "0" + Convert.ToString(m);
            else
                sm = Convert.ToString(m);
            if (d < 10)
                sd = "0" + Convert.ToString(d);
            else
                sd = Convert.ToString(d);
            return Convert.ToString(y) + "-" + sm + "-" + sd;
        }
        #endregion
        #region  自动编号
        /// <summary>
        /// 在添加信息时自动计算编号.
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="ID">字段名</param>
        /// <returns>返回String对象</returns>
        public String GetAutocoding(string TableName, string ID)
        {
            //查找指定表中ID号为最大的记录
            SqlDataReader MyDR = MyDataClass.Getcom("select max(" + ID + ") NID from " + TableName);
            int Num = 0;
            if (MyDR.HasRows)   //当查找到记录时
            {
                MyDR.Read();    //读取当前记录
                if (MyDR[0].ToString() == "")
                    return "0001";
                Num = Convert.ToInt32(MyDR[0].ToString());  //将当前找到的最大编号转换成整数
                ++Num;  //最大编号加1
                string s = string.Format("{0:0000}", Num);  //将整数值转换成指定格式的字符串
                return s;   //返回自动生成的编号
            }
            else
            {
                return "0001";  //当数据表没有记录时，返回0001
            }
        }
        #endregion

        #region  清空所有数据表
        /// <summary>
        /// 清空数据库中的所有数据表.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        public void Clear_Table(Control.ControlCollection GBox, string TName)
        {
            string sID = "";
            foreach (Control C in GBox)
            {
                if (C.GetType().Name == "CheckBox")
                {
                    sID = C.Name;
                    if (sID.IndexOf(TName) > -1)
                    {
                        if (((CheckBox)C).Checked == true)
                        {
                            string TableName = "";
                            string[] Astr = sID.Split(Convert.ToChar('_'));
                            TableName = "tb_" + Astr[1];
                            if (Astr[1].ToUpper() == ("Clew").ToUpper())
                            {
                                MyDataClass.GetSql("update " + TableName + " set Fate=0,Unlock=0 where ID>0");
                            }
                            else
                            {
                                MyDataClass.GetSql("Delete " + TableName);
                                if (Astr[1].ToUpper() == ("Login").ToUpper())
                                {
                                    MyDataClass.GetSql("insert into " + TableName + " (ID,Name,Pass) values('0001','TSoft','111')");
                                    ADD_Pope("0001", 1);
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region  添加用户权限
        /// <summary>
        /// 在添加用户时，将权限模版中的信息添加到用户权限表中.
        /// </summary>
        /// <param name="ID">用户编号</param>
        /// <param name="n">权限值</param>
        /// <>
        public void ADD_Pope(string ID, int n)
        {
            DataSet DSet;
            DSet = MyDataClass.GetDataSet("select PopeName from tb_PopeModel", "tb_PopeModel");
            for (int i = 0; i < DSet.Tables[0].Rows.Count; i++)
            {
                MyDataClass.GetSql("insert into tb_UserPope (ID,PopeName,Pope) values('" + ID + "','" + Convert.ToString(DSet.Tables[0].Rows[i][0]) + "'," + n + ")");
            }
        }
        #endregion
        #region  向comboBox控件传递数据表中的数据
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加数据.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="TableName">数据表名称</param>
        public void CoPassData(ComboBox cobox, string TableName)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClsaa = new PWMS.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClsaa.Getcom("select * from " + TableName);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[1].ToString() != "" && MyDR[1].ToString() != null)
                        cobox.Items.Add(MyDR[1].ToString());
                }
            }
        }
        #endregion

        #region  向comboBox控件传递各省市的名称
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加省名.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="SQLstr">SQL语句</param>
        /// <param name="n">字段位数</param>
        public void CityInfo(ComboBox cobox, string SQLstr, int n)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClsaa = new PWMS.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClsaa.Getcom(SQLstr);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[n].ToString() != "" && MyDR[n].ToString() != null)
                        cobox.Items.Add(MyDR[n].ToString());
                }
            }
        }
        #endregion
        #region  设置MaskedTextBox控件的格式
        /// <summary>
        /// 将MaskedTextBox控件的格式设为yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <param name="ID">数据表名称</param>
        /// <returns>返回String对象</returns>
        public void MaskedTextBox_Format(MaskedTextBox MTBox)
        {
            MTBox.Mask = "0000-00-00";
            MTBox.ValidatingType = typeof(System.DateTime);
        }
        #endregion
    }
}
