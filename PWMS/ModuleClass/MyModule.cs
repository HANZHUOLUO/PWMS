using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        #endregion

    }
}
