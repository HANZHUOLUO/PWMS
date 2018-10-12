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
    public partial class F_Find : DevExpress.XtraEditors.XtraForm
    {
        public F_Find()
        {
            InitializeComponent();
        }
        ModuleClass.MyModule myModule = new ModuleClass.MyModule();
        DataClass.MyMeans MyMeans = new DataClass.MyMeans();
        public static DataSet My_Ds_grid;
        public string Arsign = " AND ";
        public static string sUT_sql= " select ID as 编号,StuffName as 职工姓名,Folk as 民族类别,Birthday as 出生日期,Age as 年龄,Kultur as 文化程度,Marriage as 婚姻,Sex as 性别,Visage as 政治面貌,IDCard as 身份证号,Workdate as 单位工作时间,WorkLength as 工龄,Employee as 职工类别,Business as 职务类别,Laborage as 工资类别,Branch as 部门类别,Duthcall as 职称类别,Phone as 电话,Handset as 手机,School as 毕业学校,Speciality as 主修专业,GraduateDate as 毕业时间,M_Pay as 月工资,Bank as 银行帐号,Pact_B as 合同开始时间,Pact_E as 合同结束时间,Pact_Y as 合同年限,BeAware as 籍贯所在省,City as 籍贯所在市 from tb_Stuffbasic "
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region 清空控件集上的空间信息
        private void Clear_BOX( int n ,Control.ControlCollection Gbox,string TName)
        {
            for (int i=0;i<n;i++)
            {
                foreach (Control C in Gbox)
                {
                    if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                        if (C.Name.IndexOf(TName)>-1)
                        {
                            C.Text = "";
                        }
                }

            }

        }

        #endregion
        /// <summary>
        /// 单据加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void F_Find_Load(object sender, EventArgs e)
        {
            myModule.CoPassData(Find_Folk,"tb_Folk");//向民族类别列表框添加信息
            myModule.CoPassData(Find_Kultur,"tb_Kultur");//向文化程度列表框中添加信息
            myModule.CoPassData(Find_Visage,"tb_Visage");//向政治面貌列表框中添加信息
            myModule.CoPassData(Find_Employee, "tb_EmployeeGenre");  //向"职工类别”列表框中添加信息
            myModule.CoPassData(Find_Business, "tb_Business");  //向"职务类别”列表框中添加信息
            myModule.CoPassData(Find_Laborage, "tb_Laborage");  //向"工资类别”列表框中添加信息
            myModule.CoPassData(Find_Branch, "tb_Branch");  //向"部门类别”列表框中添加信息
            myModule.CoPassData(Find_Duthcall, "tb_Duthcall");  //向"职称类别”列表框中添加信息
            ///向下拉列表中添加省名
            myModule.CityInfo(Find_BeAware,"SELECT DISTINCT BEAWARE FROM TB_CITY ",0);
            ///向下拉列表中添加市名
            myModule.CityInfo(Find_School,"select distinct school from tb_stuffbasic",0);
            ///向下拉列表中添加主修专业
            myModule.CityInfo(Find_Speciality,"select distinct speciality from tb_stuffbasic",0);
            myModule.MaskedTextBox_Format(Find1_WorkDate);//格式化
            myModule.MaskedTextBox_Format(Find2_WorkDate);
            //填充datagridview
            My_Ds_grid = MyMeans.GetDataSet(sUT_sql,"tb_stuffbasic");
            dataGridView1.DataSource = My_Ds_grid.Tables[0];
       
        }
    }

}