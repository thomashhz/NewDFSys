using Hhz.dbdata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SysDF._10销售模块
{
    public partial class 销售订单管理 : SysDF.BaseForm.BsdrFormDJ
    {
        public 销售订单管理()
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

            //日期类型
            gdFindWhere.Cell(1, 0).Text = "日期类型：";
            
            gdFindWhere.Cell(1,1).CellType = FlexCell.CellTypeEnum.ComboBox;
            gdFindWhere.Cell(1, 1).Text = "单据日期";
                    

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

            //单据状态
            gdFindWhere.Cell(4, 0).Text = "单据状态";
            gdFindWhere.Cell(4, 1).CellType = FlexCell.CellTypeEnum.ComboBox;

            //单据编号
            gdFindWhere.Cell(5, 0).Text = "单据编号";
            gdFindWhere.Cell(5, 1).CellType = FlexCell.CellTypeEnum.TextBox;

            //微信订单号
            gdFindWhere.Cell(6, 0).Text = "微信订单号";
            gdFindWhere.Cell(6, 1).CellType = FlexCell.CellTypeEnum.TextBox;

            //客户
            gdFindWhere.Cell(7, 0).Text = "客户";
            gdFindWhere.Cell(7, 1).CellType = FlexCell.CellTypeEnum.Button;

            //司机或业务
            gdFindWhere.Cell(8, 0).Text = "司机或业务";
            gdFindWhere.Cell(8, 1).CellType = FlexCell.CellTypeEnum.Button;


            //快递确认
            gdFindWhere.Cell(9, 0).Text = "快递确认";
            gdFindWhere.Cell(9, 1).CellType = FlexCell.CellTypeEnum.CheckBox;



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
            groupBox2.Text = "单据表头";
            groupBox2.Tag = "-1";

        }

        private void gdFindWhere_ComboDropDown(object Sender, FlexCell.Grid.ComboDropDownEventArgs e)
        {
            FlexCell.ComboBox cb = gdFindWhere.ComboBox(0);
            cb.DropDownFont = gdFindWhere.DefaultFont;
            
            switch (e.Row)
            {
                case 1: // 日期类型
                    cb.DropDownWidth = 0;
                    cb.Items.Add("单据日期");
                    cb.Items.Add("审核日期");
                    break;
                case 4: // 日期类型
                    cb.DropDownWidth = 0;
                    cb.Items.Add("已审核");
                    cb.Items.Add("未审核");
                    break;
            }
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string sSql = " ";
            string sItem = " ";
            // AreaID,AreaName,PrevID
            sSql = "select  h.* ";
            sSql += ",o.orderStatus,u.isWXFocus,o.CustWXnum ";
            sSql = sSql + " ,case o.orderStatus ";
            sSql = sSql + " when -10 then '已取消'";
            sSql = sSql + " when 10 then '已完成'";
            sSql = sSql + " when 11 then '未付款待发货'";
            sSql = sSql + " when 12 then '未付款已受理'";
            sSql = sSql + " when 13 then '未付款正在备货'";
            sSql = sSql + " when 14 then '未付款已发货'";
            sSql = sSql + " when 15 then '未付款已签收'";
            sSql = sSql + " when 21 then '已付款待发货'";
            sSql = sSql + " when 22 then '已付款已受理'";
            sSql = sSql + " when 23 then '已付款正在备货'";
            sSql = sSql + " when 24 then '已付款已发货'";
            sSql = sSql + " Else ''";
            sSql = sSql + " end orderStatusName";

            sSql += " from inv_evi h  ";
            sSql += " left join DefWeixin.dbo.WxOrder o on h.evino = o.orderno ";
            sSql += "  left join DefWeixin.dbo.WxUserCust u on o.CustWXnum = u.openid ";

            if (gdFindWhere.Cell(1,1).Text =="单据日期")
            {
                sSql += " where h.evidate between '"+ gdFindWhere.Cell(2,1).Text  + "' and '" + gdFindWhere.Cell(3, 1).Text + "' ";
            }
            else  //审核日期
            {
                sSql += " where h.Verifierdate between '" + gdFindWhere.Cell(2, 1).Text + "' and '" + gdFindWhere.Cell(3, 1).Text + "' ";
            }

            if (gdFindWhere.Cell(4, 1).Text == "已审核")  //单据状态
            {
                sSql += " and h.Verified='1' ";
            }else if (gdFindWhere.Cell(4, 1).Text == "未审核")  //单据状态
            {
                sSql += " and h.Verified<>'1' ";
            }
            //客户编号
            if (gdFindWhere.Cell(7, 1).Text != "")  
            {
                sSql += " and (h.custid like '%"+ gdFindWhere.Cell(7, 1).Text + "%'  or h.custname like '%" + gdFindWhere.Cell(7, 1).Text + "%' ) ";
            }
            //确认快递
            if (gdFindWhere.Cell(9, 1).Text == "1")  
            {
                sSql += " and h.iskd=1 ";
            }


            DataSet ds = DbHelperSQL.Query(sSql);
            //SqlDataReader dr
            //SqlDataReader dr = DbHelperSQL.ExecuteReader(sSql);
            gdFindList.Rows = 1;
            gdFindList.AutoRedraw = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sItem = "";
                    try
                    {
                        sItem += "\t" + ds.Tables[0].Rows[i]["evino"].ToString().Trim();   //dr["evino"].ToString();
                        //是否排产  PCBZ
                        sItem += "\t " + ds.Tables[0].Rows[i]["PCBZ"].ToString();

                        sItem += "\t" + ds.Tables[0].Rows[i]["iskd"].ToString();   // dr["iskd"].ToString();  //是否快递

                        sItem += "\t" + ds.Tables[0].Rows[i]["Verified"].ToString();   //dr["Verified"].ToString(); //是否 审批
                        sItem += "\t" + ds.Tables[0].Rows[i]["payed"].ToString();   //dr["payed"].ToString(); //是否 付款

                        sItem += "\t" + ds.Tables[0].Rows[i]["evidate"].ToString().Substring(0, 10);   // dr["evidate"].ToString().Substring(0, 10); // 单据日期
                        sItem += "\t" + ds.Tables[0].Rows[i]["driver"].ToString();   // dr["driver"].ToString(); //司机

                        // var wxno = dr["Wxorderno"].ToString();
                        //sItem += "\t" + ds.Tables[0].Rows[i]["Wxorderno"] == null ? "" : ds.Tables[0].Rows[i]["Wxorderno"].ToString(); //, PubFun.Nz(dr["Wxorderno"].ToString(), "");
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["Wxorderno"], "");  //微信订单号
                        //微信订单状态
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["orderStatus"], "") + "|" + PubFun.Nz(ds.Tables[0].Rows[i]["orderStatusName"], "");
                        //微信号 CustWXnum
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["CustWXnum"], "");
                        //是否取消关注 isWXFocus  -1 已取消
                        if(ds.Tables[0].Rows[i]["isWXFocus"].ToString() == "-1")
                        {
                            sItem += "\t已取消" ;
                        }
                        else{
                            sItem += "\t";
                        }
                        
                        //客户
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["custid"], "") + "|" + PubFun.Nz(ds.Tables[0].Rows[i]["custname"], "");
                        //单据 重量
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["SumWeight"], "");
                        //单据 罐数
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["SumQty"], "");
                        //单据 件数
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["SumNQty"], "");
                        //单据 金额
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["SumAmount"], "");

                        //单据 联系人
                        sItem += "\t" ;

                        //单据 手机
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["tel"], "");

                        //单据 固话
                        sItem += "\t";

                        //单据 地址
                        sItem += "\t" + PubFun.Nz(ds.Tables[0].Rows[i]["caddress"], "");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("提示！:" + ex);
                        break;
                    }
                    gdFindList.AddItem(sItem);
                    //标识已取消关注为红色
                    gdFindList.Cell(gdFindList.Rows - 1, 12).ForeColor =Color.Red ;
                    //客户换行
                    gdFindList.Cell(gdFindList.Rows - 1, 13).WrapText = true;

                    //客户手机
                    gdFindList.Cell(gdFindList.Rows - 1, 19).WrapText = true;
                    //客户地址
                    gdFindList.Cell(gdFindList.Rows - 1, 21).WrapText = true;

                }

            }

            gdFindList.AutoRedraw = true;
            gdFindList.Refresh();

            //while (dr.Read())
            //{
            //    sItem = "";
            //   // string  getID = dr["lsbh"].ToString();
            //    try
            //    {
            //        //ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim();
            //        sItem += "\t" + dr["evino"].ToString();

            //        sItem += "\t " ;  //是否排产

            //        sItem += "\t" + dr["iskd"].ToString() ;  //是否快递

            //        sItem += "\t" + dr["Verified"].ToString(); //是否 审批
            //        sItem += "\t" + dr["payed"].ToString(); //是否 付款

            //        sItem += "\t" + dr["evidate"].ToString().Substring(0,10) ; // 单据日期
            //        sItem += "\t" + dr["driver"].ToString(); //司机
            //        var wxno = dr["Wxorderno"].ToString();
            //        sItem += "\t" + PubFun.Nz(dr["Wxorderno"].ToString(),"");

            //        //if(dr["Wxorderno"].ToString().IsNullOrEmpty())
            //        //{
            //        //    sItem += "\t";
            //        //}
            //        //else
            //        //{
            //        //    sItem += "\t" + dr["Wxorderno"].ToString();
            //        //}

            //        //if(dr["Wxorderno"].ToString()==null) //微信订单号
            //        //{
            //        //    sItem += "\t" ; 
            //        //}
            //        //else
            //        //{
            //        //    sItem += "\t" + dr["Wxorderno"].ToString(); 
            //        //}

            //        gdFindList.AddItem(sItem);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("提示！:" + ex);
            //        break;
            //    }


            //}


        }

        private void gdFindList_EnterRow(object Sender, FlexCell.Grid.EnterRowEventArgs e)
        {
            //列表 row  变化后，明细数据也 发生变化
            //获取当前单据号
            string StrEviNo = gdFindList.Cell(e.Row,2).Text .ToString();
            if(EviNO.Text .ToString()!=StrEviNo.ToString ())
            {
                //当前行的单号不等于明细的单号，则刷新明细数据
                //此处调用函数显示明细数据
            }

        }
    }
}
