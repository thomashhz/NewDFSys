using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysDF._10销售模块
{
    public partial class 销售发票管理 : SysDF.BaseForm.BsdrFormDJ
    {
        public 销售发票管理()
        {
            InitializeComponent();

        }
        private Boolean IsSaved = false;
        private void toolSetTrue(Boolean t)
        {
            toolAdd.Enabled = t;
            toolEdit.Enabled = t;
            toolDel.Enabled = t;


            toolSave.Enabled = !t;
            toolCancel.Enabled = !t;
            groupBox2.Enabled = !t;
            groupBox1.Enabled = !t;

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolFind_Click(object sender, EventArgs e)
        {
            if (gBFindWhere.Width == 283)
            {
                gBFindWhere.Width = 2;
                tabControl1.Left = 5;
                tabControl1.Width = this.Width - 5;
            }
            else
            {

                gBFindWhere.Width = 283;
                tabControl1.Left = 288;
                tabControl1.Width = this.Width - 5 - 288;
            }
        }

        private void 销售订单管理_Load(object sender, EventArgs e)
        {
            inigbFindwhereGrid();
        }

        private void inigbFindwhereGrid()
        {
            string sPath1= System.IO.Directory.GetCurrentDirectory() + "\\CellFormat\\销售订单管理.flx";
            gdFindList.OpenFile(sPath1);

            //初始化查询条件

            //gridFindWhere.Column(0).Width = 0;
            //gridFindWhere.Row(0).Height = 0;

            //gdFindWhere.SelectionMode = FlexCell.SelectionModeEnum.ByCell;
            //返回或设置ComboBox子控件是否禁键盘输入，如果Locked设置为True，只能从下拉框中选择列表项。
            gdFindWhere.ComboBox(0).Locked = true;
            gdFindWhere.ReadonlyFocusRect = FlexCell.FocusRectEnum.Solid;


            gdFindWhere.Rows = 10;
            //gdFindWhere.Width = gBFindWhere.Width-10;
            gdFindWhere.Column(0).Width = 100;
            gdFindWhere.Column(1).Width = 150;
            gdFindWhere.Cell(0, 0).Text = "FindWhere";
            gdFindWhere.Cell(0, 1).Text = "Value";

            gdFindWhere.Cell(1, 0).Text = "日期类型：";
            gdFindWhere.Cell(1, 1).CellType = FlexCell.CellTypeEnum.ComboBox;
            gdFindWhere.Cell(1, 1).Text = "单据日期";
            gdFindWhere.Cell(1, 1).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            //只能在ComboDropDown事件中向Grid.ComboBox(0)添加下拉项
            //FlexCell.ComboBox cb = gdFindWhere.ComboBox(1);
            //cb.Items.Add("单据日期");
            //cb.Items.Add("审核日期");


            gdFindWhere.Cell(2, 0).Text = "开始日期：";
            gdFindWhere.Cell(2, 1).CellType = FlexCell.CellTypeEnum.Calendar;
            //本月第一天
            gdFindWhere.Cell(2, 1).Text = string.Format("{0:d}", DateTime.Now.AddDays(1 - DateTime.Now.Day).Date);
            gdFindWhere.Cell(2, 1).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            gdFindWhere.Cell(3, 0).Text = "结束日期：";
            gdFindWhere.Cell(3, 1).CellType = FlexCell.CellTypeEnum.Calendar;
            //本月最后一天
            gdFindWhere.Cell(3, 1).Text = string.Format("{0:d}", DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddMonths(1).AddSeconds(-1));
            gdFindWhere.Cell(3, 1).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            //快递确认
            gdFindWhere.Cell(4, 0).Text = "已确认快递";
            gdFindWhere.Cell(4, 1).CellType = FlexCell.CellTypeEnum.CheckBox;
            //单据编号
            gdFindWhere.Cell(5, 0).Text = "单据编号";
            //gdFindWhere.Cell(5, 1).CellType = FlexCell.CellTypeEnum.CheckBox;
            //客户
            gdFindWhere.Cell(6, 0).Text = "客户";
            gdFindWhere.Cell(6, 1).CellType = FlexCell.CellTypeEnum.Button;

            //区域
            gdFindWhere.Cell(7, 0).Text = "区域";
            gdFindWhere.Cell(7, 1).CellType = FlexCell.CellTypeEnum.Button;

            //司机或业务
            gdFindWhere.Cell(8, 0).Text = "司机或业务";
            gdFindWhere.Cell(8, 1).CellType = FlexCell.CellTypeEnum.Button;

        }

        private void toolAdd_Click(object sender, EventArgs e)
        {

            //新增
            toolSetTrue(false);
            groupBox2.Text = "新增";
            groupBox2.Tag = "0";
            IsSaved = true;
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            //修改
            //判断是否允许修改，审核的单据不允许修改

            toolSetTrue(false);
            groupBox2.Text = "修改";
            //groupBox2.Tag = textBox1.Text.ToString();
            IsSaved = true; //
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            //取消
            toolSetTrue(true);
            IsSaved = false;

        }
    }
}
