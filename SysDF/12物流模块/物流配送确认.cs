using Hhz.dbdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using zopsdk_net;

namespace SysDF._12物流模块
{
    public partial class 物流配送确认 : SysDF.BaseForm.BaseForm
    {
        public 物流配送确认()
        {
            InitializeComponent();
        }

        private void 物流配送确认_Load(object sender, EventArgs e)
        {
            iniGiidFormat();        //初始化控件显示
            inigbFindwhereGrid();   //初始化查询条件
            
        }

        private void iniGiidFormat()
        {
            string sPath1 = System.IO.Directory.GetCurrentDirectory() + "\\CellFormat\\快递确认c.flx";

            gdFindList.OpenFile(sPath1);

        }
        private void inigbFindwhereGrid()
        {


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
            gdFindWhere.Cell(1,1).Alignment = FlexCell.AlignmentEnum.CenterCenter;
            
            //只能在ComboDropDown事件中向Grid.ComboBox(0)添加下拉项
            //FlexCell.ComboBox cb = gdFindWhere.ComboBox(1);
            //cb.Items.Add("单据日期");
            //cb.Items.Add("审核日期");


            gdFindWhere.Cell(2, 0).Text = "开始日期：";
            gdFindWhere.Cell(2, 1).CellType = FlexCell.CellTypeEnum.Calendar;
            //本月第一天
            gdFindWhere.Cell(2, 1).Text =string.Format("{0:d}", DateTime.Now.AddDays(1 - DateTime.Now.Day).Date);
            gdFindWhere.Cell(2, 1).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            gdFindWhere.Cell(3, 0).Text = "结束日期：";
            gdFindWhere.Cell(3, 1).CellType = FlexCell.CellTypeEnum.Calendar;
            //本月最后一天
            gdFindWhere.Cell(3, 1).Text =string.Format("{0:d}", DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddMonths(1).AddSeconds(-1));
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

        private void gdFindWhere_ComboDropDown(object Sender, FlexCell.Grid.ComboDropDownEventArgs e)
        {
            FlexCell.ComboBox cb = gdFindWhere.ComboBox(0);

            switch (e.Row)
            {
                case 1: // 日期类型
                    cb.DropDownWidth = 0;
                    cb.DropDownFont = new Font("宋体",10.5f) ;// System.Drawing.Font.;
                    
                    cb.Items.Add("单据日期");
                    cb.Items.Add("审核日期");
                    break;


            }
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            //查询单据
            string sSql = "";
            string strAreaid = gdFindWhere.Cell(8,1).Text.ToString();  //区域

            sSql = " select a.*,d.custname ,d.telname ,d.tel,d.ddtel,d.address,d.city,d.cityid,d.khwxh ";
            sSql += " from  Inv_Evi a  inner join dbo.f_CAreaid('" + strAreaid + "') c on a.areaid =c.AreaID ";
            sSql += " inner join customer d on a.custid=d.custid ";

            sSql += " where 1=1 ";

            if (gdFindWhere.Cell(1, 1).Text.ToString()=="单据日期")
            {
                sSql += " and  a.evidate>='" + gdFindWhere.Cell(2, 1).Text.ToString() + "' and a.evidate <='" + gdFindWhere.Cell(3, 1).Text.ToString() + "'";
            }else if (gdFindWhere.Cell(1, 1).Text.ToString() == "审核日期")
            {
                sSql += " and  a.Verifierdate>='" + gdFindWhere.Cell(2, 1).Text.ToString() + "' and a.Verifierdate <='" + gdFindWhere.Cell(3, 1).Text.ToString() + "'";
            }
            //条件，快递
            if(gdFindWhere.Cell(4,1).Text.ToString()=="1")
            {
                sSql += " and  ISNULL(a.ISKD,0)='1'";
            }else
            {
                sSql += " and  ISNULL(a.ISKD,0)='0'";
            }

            SqlDataReader rd = DbHelperSQL.ExecuteReader(sSql);
            int intR = 1;
            try
            {
                
                while (rd.Read())
                {
                    intR += 1;
                    gdFindList.Rows = intR;
                    gdFindList.Cell(intR - 1, 1).Text = ""; //选择

                    gdFindList.Cell(intR - 1, 2).Text = rd["EviNo"].ToString () ;   //单据编号
                    gdFindList.Cell(intR - 1, 3).Text = PubFun.Nz(rd["isPCFH"].ToString(),"");    //是否排产
                    gdFindList.Cell(intR - 1, 4).Text = rd["isKD"].ToString();      //是否快递
                    gdFindList.Cell(intR - 1, 5).Text = rd["KDDH"].ToString();     //快递单号
                    gdFindList.Cell(intR - 1, 6).Text = rd["driver"].ToString();    //司机
                    gdFindList.Cell(intR - 1, 7).Text = rd["khwxh"].ToString();     //客户微信号
                    gdFindList.Cell(intR - 1, 8).Text = rd["CustName"].ToString();      //客户名称
                    gdFindList.Cell(intR - 1, 8).WrapText = true;                       //换行
                    gdFindList.Cell(intR - 1, 8).Tag = rd["Custid"].ToString();         //客户编号
                    gdFindList.Cell(intR - 1, 9).Text = rd["SumWeight"].ToString();     //重量
                    gdFindList.Cell(intR - 1, 10).Text = rd["SumnQty"].ToString();    //件数
                    gdFindList.Cell(intR - 1, 11).Text = rd["telname"].ToString();     //联系人
                    gdFindList.Cell(intR - 1, 12).Text = rd["Tel"].ToString();       //手机 
                    gdFindList.Cell(intR - 1, 13).Text = rd["DDTel"].ToString();     //固话                    

                    if( rd["cityID"].ToString().Substring(1,2)=="44")
                    {
                        gdFindList.Cell(intR - 1, 14).Text = "广东省" +  rd["Address"].ToString();     //广东地址要加上"广东省"
                    }
                    else
                    {
                        gdFindList.Cell(intR - 1, 14).Text =  rd["Address"].ToString();
                    }
                    gdFindList.Cell(intR - 1, 14).WrapText = true;//换行

                }
            }
            catch { }




        }

        private void toolPrint_Click(object sender, EventArgs e)
        {


            //'设置页边距
            gdFindList.PageSetup.LeftMargin = 1;
            gdFindList.PageSetup.RightMargin = 0;
            gdFindList.PageSetup.TopMargin = 1;
            gdFindList.PageSetup.BottomMargin = 1;
            gdFindList.PageSetup.HeaderMargin = 2;
            gdFindList.PageSetup.FooterMargin = 2;
            gdFindList.PageSetup.PrintFixedRow = true;      //打印固定行
            gdFindList.PageSetup.PrintFixedColumn=true ;  //打印固定列

            gdFindList.PageSetup.Landscape = true;   //横向打印 true, 纵向打印false


            gdFindList.PrintPreview();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string strV = "{\"bagSize\":\"20,10,30\",\"partnerCode\":\"3608036589234\",\"companyCode\":\"GP1551922487\",\"billCode\":null,\"hallCode\":\"S2044\",\"startTime\":null,\"endTime\":null,\"siteCode\":\"\",\"weight\":1.23,\"freight\":0,\"orderSum\":230.12,\"otherCharges\":0,\"packCharges\":0,\"premium\":0,\"price\":0,\"quantity\":\"1\",\"remark\":\"\",\"receiver\":{\"address\":\"外街道00号\",\"city\":\"苏州市\",\"company\":\"中通快递\",\"county\":\"朝阳区\",\"id\":\"\",\"mobile\":\"13262709999\",\"name\":\"黄某\",\"phone\":\"\",\"prov\":\"江苏省\",\"zipCode\":\"\"},\"sender\":{\"address\":\"华志路1685号\",\"city\":\"蚌埠市\",\"company\":\"中通快递股份有限公司\",\"county\":\"怀远县\",\"id\":\"15097756\",\"mobile\":\"15216800000\",\"name\":\"测试\",\"phone\":\"\",\"prov\":\"安徽省\",\"zipCode\":\"\"}}";
            
            this.textBox4.Text = ConvertJsonString(strV.ToString()).ToString();
        }
        private string ConvertJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //创建订单
            //定义：x-companyId -》合作商编码 （在个人中心查看） 和  x-dataDigest -》数据签名
            string str_companyid = "kfpttestCode";
            string str_key = "kfpttestkey==";   //"kfpttestkey==";   //
            ZopProperties ZTps = new ZopProperties(str_companyid, str_key);


            ZopRequest ztreq = new ZopRequest();

            //总队总-下单返回寄件码，测试地址： http://58.40.16.122:8080/plateOrder
            //总队总-下单返回寄件码，正式地址： http://japi.zto.cn/plateOrder

            ztreq.url = "http://58.40.16.122:8080/plateOrder";

            //参数1
            string strK = "systemParameter";
            string strV = textBox3.Text.ToString();  // "{\"serviceCode\":\"StoreDeliverGoods\"}";
            //@"d:\root\subdir"; 转义
            ztreq.addParam(strK, strV);//参数1
            //参数2
            strK = "orderInfo";
            strV = textBox4.Text.ToString(); //"{\"bagSize\":\"20,10,30\",\"partnerCode\":\"3608036589234\",\"companyCode\":\"GP1551922487\",\"billCode\":null,\"hallCode\":\"S2044\",\"startTime\":null,\"endTime\":null,\"siteCode\":\"\",\"weight\":1.23,\"freight\":0,\"orderSum\":230.12,\"otherCharges\":0,\"packCharges\":0,\"premium\":0,\"price\":0,\"quantity\":\"1\",\"remark\":\"\",\"receiver\":{\"address\":\"外街道00号\",\"city\":\"苏州市\",\"company\":\"中通快递\",\"county\":\"朝阳区\",\"id\":\"\",\"mobile\":\"13262709999\",\"name\":\"黄某\",\"phone\":\"\",\"prov\":\"江苏省\",\"zipCode\":\"\"},\"sender\":{\"address\":\"华志路1685号\",\"city\":\"蚌埠市\",\"company\":\"中通快递股份有限公司\",\"county\":\"怀远县\",\"id\":\"15097756\",\"mobile\":\"15216800000\",\"name\":\"测试\",\"phone\":\"\",\"prov\":\"安徽省\",\"zipCode\":\"\"}}";
            ztreq.addParam(strK, strV);//参数2

            ZopClient zc = new ZopClient(ZTps);

            string retstringinfo = zc.execute(ztreq).ToString();

            this.textBox5.Text = ConvertJsonString(retstringinfo.ToString()).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //创建订单
            //定义：x-companyId -》合作商编码 （在个人中心查看） 和  x-dataDigest -》数据签名
            string str_companyid = "kfpttestCode";
            string str_key = "kfpttestkey==";   //"kfpttestkey==";   //
            ZopProperties ZTps = new ZopProperties(str_companyid, str_key);


            ZopRequest ztreq = new ZopRequest();

            //总队总-下单返回寄件码，测试地址： http://58.40.16.122:8080/plateOrder
            //总队总-下单返回寄件码，正式地址： http://japi.zto.cn/plateOrder

            ztreq.url = "http://58.40.16.122:8080/plateOrder";

            //参数1
            string strK = "systemParameter";
            string strV = textBox3.Text.ToString();  // "{\"serviceCode\":\"StoreDeliverGoods\"}";
            //@"d:\root\subdir"; 转义
            ztreq.addParam(strK, strV);//参数1
            //参数2
            strK = "orderInfo";
            strV = textBox4.Text.ToString(); //"{\"bagSize\":\"20,10,30\",\"partnerCode\":\"3608036589234\",\"companyCode\":\"GP1551922487\",\"billCode\":null,\"hallCode\":\"S2044\",\"startTime\":null,\"endTime\":null,\"siteCode\":\"\",\"weight\":1.23,\"freight\":0,\"orderSum\":230.12,\"otherCharges\":0,\"packCharges\":0,\"premium\":0,\"price\":0,\"quantity\":\"1\",\"remark\":\"\",\"receiver\":{\"address\":\"外街道00号\",\"city\":\"苏州市\",\"company\":\"中通快递\",\"county\":\"朝阳区\",\"id\":\"\",\"mobile\":\"13262709999\",\"name\":\"黄某\",\"phone\":\"\",\"prov\":\"江苏省\",\"zipCode\":\"\"},\"sender\":{\"address\":\"华志路1685号\",\"city\":\"蚌埠市\",\"company\":\"中通快递股份有限公司\",\"county\":\"怀远县\",\"id\":\"15097756\",\"mobile\":\"15216800000\",\"name\":\"测试\",\"phone\":\"\",\"prov\":\"安徽省\",\"zipCode\":\"\"}}";
            ztreq.addParam(strK, strV);//参数2

            ZopClient zc = new ZopClient(ZTps);

            string retstringinfo = zc.execute(ztreq).ToString();

            this.textBox5.Text = ConvertJsonString(retstringinfo.ToString()).ToString();
        }
    }
}
