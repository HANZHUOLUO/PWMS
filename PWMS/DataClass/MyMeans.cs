using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Sql;

namespace PWMS.DataClass
{
    class MyMeans
    {
        #region  全局变量
        public static string Login_ID = "";//定义全局变量，记录当前登录的用户编码
        public static string Login_Name = "";//当以全局变量，记录当前登录的用户名
        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";//定义全局变量，“基础信息”个窗体中的表名及sql语句
        public static SqlConnection My_con;/// 定义全局变量  SQL连接 用于判断数据库是否连接成功
        public static string M_str_sqlcon = "server=kingdee;database=db_pwms;uid=sa;pwd=123123";///sa身份登录
        //public static string M_str_sqlcon = "server=kingdee;database=db_pwms;Integrated Security=TRUE";///WINDOWS登录
        public static int Login_n = 0;//用户登录与重新登录标识
        public static string AllSql = "Select * from tb_Stuffbasic"; //查询员工基本信息表
        //string constr=System.Configuration.ConfigurationManager
        #endregion
        #region 建立数据库连接
        /// <summary>
        /// 建立数据库连接
        /// </summary>
        /// <returns>返回SqlConnection对象</returns>
        public static SqlConnection Getcon()
        {
            My_con = new SqlConnection(M_str_sqlcon); ///用SqlConnection对象与制定的数据库连接
            My_con.Open();//打开数据库连接
            return My_con;//返回SqlConnection对象的信息

        }
        #endregion
        #region 测试数据库是否附加
        /// <summary>
        /// 测试数据库是否附加
        /// </summary>
        public void Con_open()
        {

            Getcon();
        }
        #endregion
        #region 关闭数据库连接
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Con_close()
        {
            if (My_con.State== ConnectionState.Open) ///判断是否打开数据库连接
            {
                My_con.Close();//关闭数据库的连接
                My_con.Dispose();//释放My_con变量的所有空间
            }
         }
        #endregion
        #region 读取指定表中的信息
        /// <summary>
        /// 读取指定表中的信息
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns>返回bool类型</returns>
        public SqlDataReader Getcom(string Sqlstr)
        {
            Getcon();//打开数据库连接
            SqlCommand cmd = new SqlCommand(Sqlstr,Getcon());
            SqlDataReader My_read = cmd.ExecuteReader();///执行SQL语句，生成一个SqlDataReader对象
            return My_read;
        }
        #endregion

        #region 执行Sqlcommand命令
        /// <summary>
        /// 执行SqlCommand
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        public void GetSql(string Sqlstr)
        {
            Getcon();//打开数据库连接
            SqlCommand sqlcom = new SqlCommand(Sqlstr, Getcon());//创建一个SqlCommand对象，用于执行SQL语句
            sqlcom.ExecuteNonQuery();//执行sql语句
            sqlcom.Dispose();//释放空间
            Con_close();
        }
        #endregion
        #region 创建DataSet对象
        /// <summary>
        /// 创建一个DataSet对象
        /// </summary>
        /// <param name="Sqlstr">SQL语句</param>
        /// <param name="TableName">表名</param>
        /// <returns></returns>
        public DataSet GetDataSet(string Sqlstr,string TableName)
        {
            Getcon();//打开数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(Sqlstr,Getcon());///创建一个SqlDataAdpter对象，并获取指定数据表信息
            DataSet My_dataset = new DataSet();///创建Dataset对象
            sda.Fill(My_dataset,TableName);//填充内存表
            Con_close();//关闭数据库连接
            return My_dataset;//返回Dataset对象的信息
        }
        #endregion
    }
}
