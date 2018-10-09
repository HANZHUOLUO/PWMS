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
using System.Data.SqlClient;

namespace PWMS
{
    public partial class F_Main : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 实例化sql公共类
        /// </summary>
        DataClass.MyMeans myMeans = new DataClass.MyMeans();
        /// <summary>
        /// 实例化变量公共类
        /// </summary>
        ModuleClass.MyModule myModule = new ModuleClass.MyModule();
        public F_Main()
        {
            InitializeComponent();
        }
        #region 通过权限对主窗体进行初始化
        #endregion

    }
}