using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace XCode.Membership
{
    /// <summary>销售订单表头</summary>
    [Serializable]
    [DataObject]
    [Description("销售订单表头")]
    [BindIndex("custid", false, "CustID")]
    [BindIndex("lsbh", false, "LSBH")]
    [BindIndex("rq", false, "EviDate")]
    [BindIndex("rq2", false, "Verifierdate")]
    [BindTable("Inv_Evi", Description = "销售订单表头", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Inv_Evi : IInv_Evi
    {
        #region 属性
        private Int32 _ID;
        /// <summary>自增ID</summary>
        [DisplayName("自增ID")]
        [Description("自增ID")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "自增ID", "")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private Int32 _Lsbh;
        /// <summary>可编辑流失编号</summary>
        [DisplayName("可编辑流失编号")]
        [Description("可编辑流失编号")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Lsbh", "可编辑流失编号", "")]
        public Int32 Lsbh { get { return _Lsbh; } set { if (OnPropertyChanging(__.Lsbh, value)) { _Lsbh = value; OnPropertyChanged(__.Lsbh); } } }

        private String _EviNO;
        /// <summary>单据编号</summary>
        [DisplayName("单据编号")]
        [Description("单据编号")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("EviNO", "单据编号", "varchar(50)")]
        public String EviNO { get { return _EviNO; } set { if (OnPropertyChanging(__.EviNO, value)) { _EviNO = value; OnPropertyChanged(__.EviNO); } } }

        private DateTime _EviDate;
        /// <summary>单据日期</summary>
        [DisplayName("单据日期")]
        [Description("单据日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("EviDate", "单据日期", "")]
        public DateTime EviDate { get { return _EviDate; } set { if (OnPropertyChanging(__.EviDate, value)) { _EviDate = value; OnPropertyChanged(__.EviDate); } } }

        private DateTime _PlanPayDate;
        /// <summary>计划收款日期</summary>
        [DisplayName("计划收款日期")]
        [Description("计划收款日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("PlanPayDate", "计划收款日期", "")]
        public DateTime PlanPayDate { get { return _PlanPayDate; } set { if (OnPropertyChanging(__.PlanPayDate, value)) { _PlanPayDate = value; OnPropertyChanged(__.PlanPayDate); } } }

        private Double _SumQty;
        /// <summary>单据合计数量</summary>
        [DisplayName("单据合计数量")]
        [Description("单据合计数量")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("SumQty", "单据合计数量", "float")]
        public Double SumQty { get { return _SumQty; } set { if (OnPropertyChanging(__.SumQty, value)) { _SumQty = value; OnPropertyChanged(__.SumQty); } } }

        private Double _SumNQty;
        /// <summary>单据合计件数</summary>
        [DisplayName("单据合计件数")]
        [Description("单据合计件数")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("SumNQty", "单据合计件数", "float")]
        public Double SumNQty { get { return _SumNQty; } set { if (OnPropertyChanging(__.SumNQty, value)) { _SumNQty = value; OnPropertyChanged(__.SumNQty); } } }

        private Double _SumWeight;
        /// <summary>单据合计重量</summary>
        [DisplayName("单据合计重量")]
        [Description("单据合计重量")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("SumWeight", "单据合计重量", "float")]
        public Double SumWeight { get { return _SumWeight; } set { if (OnPropertyChanging(__.SumWeight, value)) { _SumWeight = value; OnPropertyChanged(__.SumWeight); } } }

        private Double _SumAmount;
        /// <summary>单据合计金额</summary>
        [DisplayName("单据合计金额")]
        [Description("单据合计金额")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("SumAmount", "单据合计金额", "float")]
        public Double SumAmount { get { return _SumAmount; } set { if (OnPropertyChanging(__.SumAmount, value)) { _SumAmount = value; OnPropertyChanged(__.SumAmount); } } }

        private String _Verifier;
        /// <summary>审核人</summary>
        [DisplayName("审核人")]
        [Description("审核人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Verifier", "审核人", "varchar(50)")]
        public String Verifier { get { return _Verifier; } set { if (OnPropertyChanging(__.Verifier, value)) { _Verifier = value; OnPropertyChanged(__.Verifier); } } }

        private Byte _Verified;
        /// <summary>审核标志</summary>
        [DisplayName("审核标志")]
        [Description("审核标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Verified", "审核标志", "")]
        public Byte Verified { get { return _Verified; } set { if (OnPropertyChanging(__.Verified, value)) { _Verified = value; OnPropertyChanged(__.Verified); } } }

        private DateTime _Verifierdate;
        /// <summary>审核日期</summary>
        [DisplayName("审核日期")]
        [Description("审核日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Verifierdate", "审核日期", "")]
        public DateTime Verifierdate { get { return _Verifierdate; } set { if (OnPropertyChanging(__.Verifierdate, value)) { _Verifierdate = value; OnPropertyChanged(__.Verifierdate); } } }

        private String _CustID;
        /// <summary>客户编号</summary>
        [DisplayName("客户编号")]
        [Description("客户编号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CustID", "客户编号", "varchar(50)")]
        public String CustID { get { return _CustID; } set { if (OnPropertyChanging(__.CustID, value)) { _CustID = value; OnPropertyChanged(__.CustID); } } }

        private String _Person;
        /// <summary>责任业务</summary>
        [DisplayName("责任业务")]
        [Description("责任业务")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Person", "责任业务", "varchar(50)")]
        public String Person { get { return _Person; } set { if (OnPropertyChanging(__.Person, value)) { _Person = value; OnPropertyChanged(__.Person); } } }

        private String _Driver;
        /// <summary>配送司机</summary>
        [DisplayName("配送司机")]
        [Description("配送司机")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Driver", "配送司机", "varchar(50)")]
        public String Driver { get { return _Driver; } set { if (OnPropertyChanging(__.Driver, value)) { _Driver = value; OnPropertyChanged(__.Driver); } } }

        private String _Poster;
        /// <summary></summary>
        [DisplayName("Poster")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Poster", "", "varchar(50)")]
        public String Poster { get { return _Poster; } set { if (OnPropertyChanging(__.Poster, value)) { _Poster = value; OnPropertyChanged(__.Poster); } } }

        private Byte _Payed;
        /// <summary>收款标志</summary>
        [DisplayName("收款标志")]
        [Description("收款标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Payed", "收款标志", "")]
        public Byte Payed { get { return _Payed; } set { if (OnPropertyChanging(__.Payed, value)) { _Payed = value; OnPropertyChanged(__.Payed); } } }

        private String _PayNO;
        /// <summary>收款单号</summary>
        [DisplayName("收款单号")]
        [Description("收款单号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PayNO", "收款单号", "varchar(50)")]
        public String PayNO { get { return _PayNO; } set { if (OnPropertyChanging(__.PayNO, value)) { _PayNO = value; OnPropertyChanged(__.PayNO); } } }

        private DateTime _CreatDate;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreatDate", "创建时间", "")]
        public DateTime CreatDate { get { return _CreatDate; } set { if (OnPropertyChanging(__.CreatDate, value)) { _CreatDate = value; OnPropertyChanged(__.CreatDate); } } }

        private String _Creater;
        /// <summary>创建人</summary>
        [DisplayName("创建人")]
        [Description("创建人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Creater", "创建人", "varchar(50)")]
        public String Creater { get { return _Creater; } set { if (OnPropertyChanging(__.Creater, value)) { _Creater = value; OnPropertyChanged(__.Creater); } } }

        private DateTime _LastDate;
        /// <summary>最后修改时间</summary>
        [DisplayName("最后修改时间")]
        [Description("最后修改时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("LastDate", "最后修改时间", "")]
        public DateTime LastDate { get { return _LastDate; } set { if (OnPropertyChanging(__.LastDate, value)) { _LastDate = value; OnPropertyChanged(__.LastDate); } } }

        private String _Laster;
        /// <summary>最后修改人</summary>
        [DisplayName("最后修改人")]
        [Description("最后修改人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Laster", "最后修改人", "varchar(50)")]
        public String Laster { get { return _Laster; } set { if (OnPropertyChanging(__.Laster, value)) { _Laster = value; OnPropertyChanged(__.Laster); } } }

        private Boolean _PayType;
        /// <summary>付款类型</summary>
        [DisplayName("付款类型")]
        [Description("付款类型")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("PayType", "付款类型", "")]
        public Boolean PayType { get { return _PayType; } set { if (OnPropertyChanging(__.PayType, value)) { _PayType = value; OnPropertyChanged(__.PayType); } } }

        private String _Summary;
        /// <summary>单据备注</summary>
        [DisplayName("单据备注")]
        [Description("单据备注")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Summary", "单据备注", "varchar(100)")]
        public String Summary { get { return _Summary; } set { if (OnPropertyChanging(__.Summary, value)) { _Summary = value; OnPropertyChanged(__.Summary); } } }

        private String _Payer;
        /// <summary>收款人</summary>
        [DisplayName("收款人")]
        [Description("收款人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Payer", "收款人", "varchar(50)")]
        public String Payer { get { return _Payer; } set { if (OnPropertyChanging(__.Payer, value)) { _Payer = value; OnPropertyChanged(__.Payer); } } }

        private Byte _Invoiced;
        /// <summary>开票标志</summary>
        [DisplayName("开票标志")]
        [Description("开票标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Invoiced", "开票标志", "")]
        public Byte Invoiced { get { return _Invoiced; } set { if (OnPropertyChanging(__.Invoiced, value)) { _Invoiced = value; OnPropertyChanged(__.Invoiced); } } }

        private String _Invoicer;
        /// <summary>开票人</summary>
        [DisplayName("开票人")]
        [Description("开票人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Invoicer", "开票人", "varchar(50)")]
        public String Invoicer { get { return _Invoicer; } set { if (OnPropertyChanging(__.Invoicer, value)) { _Invoicer = value; OnPropertyChanged(__.Invoicer); } } }

        private String _InvoiceNo;
        /// <summary>开票单号</summary>
        [DisplayName("开票单号")]
        [Description("开票单号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("InvoiceNo", "开票单号", "varchar(50)")]
        public String InvoiceNo { get { return _InvoiceNo; } set { if (OnPropertyChanging(__.InvoiceNo, value)) { _InvoiceNo = value; OnPropertyChanged(__.InvoiceNo); } } }

        private String _AreaID;
        /// <summary>管理区域编号</summary>
        [DisplayName("管理区域编号")]
        [Description("管理区域编号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("AreaID", "管理区域编号", "varchar(50)")]
        public String AreaID { get { return _AreaID; } set { if (OnPropertyChanging(__.AreaID, value)) { _AreaID = value; OnPropertyChanged(__.AreaID); } } }

        private String _PrevArea;
        /// <summary>上级管理区域编号</summary>
        [DisplayName("上级管理区域编号")]
        [Description("上级管理区域编号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PrevArea", "上级管理区域编号", "varchar(50)")]
        public String PrevArea { get { return _PrevArea; } set { if (OnPropertyChanging(__.PrevArea, value)) { _PrevArea = value; OnPropertyChanged(__.PrevArea); } } }

        private Boolean _EviType;
        /// <summary>单据类型</summary>
        [DisplayName("单据类型")]
        [Description("单据类型")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("EviType", "单据类型", "")]
        public Boolean EviType { get { return _EviType; } set { if (OnPropertyChanging(__.EviType, value)) { _EviType = value; OnPropertyChanged(__.EviType); } } }

        private Int16 _FreightWay;
        /// <summary>送货方式</summary>
        [DisplayName("送货方式")]
        [Description("送货方式")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("FreightWay", "送货方式", "")]
        public Int16 FreightWay { get { return _FreightWay; } set { if (OnPropertyChanging(__.FreightWay, value)) { _FreightWay = value; OnPropertyChanged(__.FreightWay); } } }

        private String _Helper;
        /// <summary>协运人</summary>
        [DisplayName("协运人")]
        [Description("协运人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Helper", "协运人", "varchar(50)")]
        public String Helper { get { return _Helper; } set { if (OnPropertyChanging(__.Helper, value)) { _Helper = value; OnPropertyChanged(__.Helper); } } }

        private DateTime _Verifiertime;
        /// <summary>审核时间</summary>
        [DisplayName("审核时间")]
        [Description("审核时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Verifiertime", "审核时间", "")]
        public DateTime Verifiertime { get { return _Verifiertime; } set { if (OnPropertyChanging(__.Verifiertime, value)) { _Verifiertime = value; OnPropertyChanged(__.Verifiertime); } } }

        private Int16 _blnOutStock;
        /// <summary>出库标志</summary>
        [DisplayName("出库标志")]
        [Description("出库标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("blnOutStock", "出库标志", "")]
        public Int16 blnOutStock { get { return _blnOutStock; } set { if (OnPropertyChanging(__.blnOutStock, value)) { _blnOutStock = value; OnPropertyChanged(__.blnOutStock); } } }

        private String _StockNo;
        /// <summary>出库单号</summary>
        [DisplayName("出库单号")]
        [Description("出库单号")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("StockNo", "出库单号", "char(20)")]
        public String StockNo { get { return _StockNo; } set { if (OnPropertyChanging(__.StockNo, value)) { _StockNo = value; OnPropertyChanged(__.StockNo); } } }

        private String _Stocker;
        /// <summary></summary>
        [DisplayName("Stocker")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Stocker", "", "char(20)")]
        public String Stocker { get { return _Stocker; } set { if (OnPropertyChanging(__.Stocker, value)) { _Stocker = value; OnPropertyChanged(__.Stocker); } } }

        private String _EviBSC;
        /// <summary>办事处区域</summary>
        [DisplayName("办事处区域")]
        [Description("办事处区域")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("EviBSC", "办事处区域", "nchar(10)")]
        public String EviBSC { get { return _EviBSC; } set { if (OnPropertyChanging(__.EviBSC, value)) { _EviBSC = value; OnPropertyChanged(__.EviBSC); } } }

        private DateTime _Shrq;
        /// <summary>送货日期</summary>
        [DisplayName("送货日期")]
        [Description("送货日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Shrq", "送货日期", "smalldatetime")]
        public DateTime Shrq { get { return _Shrq; } set { if (OnPropertyChanging(__.Shrq, value)) { _Shrq = value; OnPropertyChanged(__.Shrq); } } }

        private Int16 _Shbz;
        /// <summary>送货标志</summary>
        [DisplayName("送货标志")]
        [Description("送货标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Shbz", "送货标志", "")]
        public Int16 Shbz { get { return _Shbz; } set { if (OnPropertyChanging(__.Shbz, value)) { _Shbz = value; OnPropertyChanged(__.Shbz); } } }

        private String _Shsm;
        /// <summary>销售单送货说明</summary>
        [DisplayName("销售单送货说明")]
        [Description("销售单送货说明")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Shsm", "销售单送货说明", "varchar(100)")]
        public String Shsm { get { return _Shsm; } set { if (OnPropertyChanging(__.Shsm, value)) { _Shsm = value; OnPropertyChanged(__.Shsm); } } }

        private DateTime _Shqrsj;
        /// <summary>送货确认时间</summary>
        [DisplayName("送货确认时间")]
        [Description("送货确认时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Shqrsj", "送货确认时间", "")]
        public DateTime Shqrsj { get { return _Shqrsj; } set { if (OnPropertyChanging(__.Shqrsj, value)) { _Shqrsj = value; OnPropertyChanged(__.Shqrsj); } } }

        private DateTime _Shqrrq;
        /// <summary>送货确认日期</summary>
        [DisplayName("送货确认日期")]
        [Description("送货确认日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Shqrrq", "送货确认日期", "smalldatetime")]
        public DateTime Shqrrq { get { return _Shqrrq; } set { if (OnPropertyChanging(__.Shqrrq, value)) { _Shqrrq = value; OnPropertyChanged(__.Shqrrq); } } }

        private String _Shqrer;
        /// <summary>送货确认人</summary>
        [DisplayName("送货确认人")]
        [Description("送货确认人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Shqrer", "送货确认人", "varchar(50)")]
        public String Shqrer { get { return _Shqrer; } set { if (OnPropertyChanging(__.Shqrer, value)) { _Shqrer = value; OnPropertyChanged(__.Shqrer); } } }

        private Int32 _iMonth;
        /// <summary>单据所属月份</summary>
        [DisplayName("单据所属月份")]
        [Description("单据所属月份")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("iMonth", "单据所属月份", "")]
        public Int32 iMonth { get { return _iMonth; } set { if (OnPropertyChanging(__.iMonth, value)) { _iMonth = value; OnPropertyChanged(__.iMonth); } } }

        private String _DrvName;
        /// <summary>跟单人员</summary>
        [DisplayName("跟单人员")]
        [Description("跟单人员")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DrvName", "跟单人员", "varchar(50)")]
        public String DrvName { get { return _DrvName; } set { if (OnPropertyChanging(__.DrvName, value)) { _DrvName = value; OnPropertyChanged(__.DrvName); } } }

        private Int32 _YFKid;
        /// <summary>预付款ID</summary>
        [DisplayName("预付款ID")]
        [Description("预付款ID")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("YFKid", "预付款ID", "")]
        public Int32 YFKid { get { return _YFKid; } set { if (OnPropertyChanging(__.YFKid, value)) { _YFKid = value; OnPropertyChanged(__.YFKid); } } }

        private String _Xdr;
        /// <summary>下单人</summary>
        [DisplayName("下单人")]
        [Description("下单人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Xdr", "下单人", "varchar(50)")]
        public String Xdr { get { return _Xdr; } set { if (OnPropertyChanging(__.Xdr, value)) { _Xdr = value; OnPropertyChanged(__.Xdr); } } }

        private String _Ddsx;
        /// <summary></summary>
        [DisplayName("Ddsx")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Ddsx", "", "nchar(10)")]
        public String Ddsx { get { return _Ddsx; } set { if (OnPropertyChanging(__.Ddsx, value)) { _Ddsx = value; OnPropertyChanged(__.Ddsx); } } }

        private Int16 _Fhqrbz;
        /// <summary>发货货确认标志</summary>
        [DisplayName("发货货确认标志")]
        [Description("发货货确认标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Fhqrbz", "发货货确认标志", "")]
        public Int16 Fhqrbz { get { return _Fhqrbz; } set { if (OnPropertyChanging(__.Fhqrbz, value)) { _Fhqrbz = value; OnPropertyChanged(__.Fhqrbz); } } }

        private String _Fhqrer;
        /// <summary>发货货确认人</summary>
        [DisplayName("发货货确认人")]
        [Description("发货货确认人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Fhqrer", "发货货确认人", "varchar(50)")]
        public String Fhqrer { get { return _Fhqrer; } set { if (OnPropertyChanging(__.Fhqrer, value)) { _Fhqrer = value; OnPropertyChanged(__.Fhqrer); } } }

        private DateTime _Fhqrdate;
        /// <summary>发货货确认日期</summary>
        [DisplayName("发货货确认日期")]
        [Description("发货货确认日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Fhqrdate", "发货货确认日期", "smalldatetime")]
        public DateTime Fhqrdate { get { return _Fhqrdate; } set { if (OnPropertyChanging(__.Fhqrdate, value)) { _Fhqrdate = value; OnPropertyChanged(__.Fhqrdate); } } }

        private Int16 _Skqrbz;
        /// <summary></summary>
        [DisplayName("Skqrbz")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Skqrbz", "", "")]
        public Int16 Skqrbz { get { return _Skqrbz; } set { if (OnPropertyChanging(__.Skqrbz, value)) { _Skqrbz = value; OnPropertyChanged(__.Skqrbz); } } }

        private String _Skqrer;
        /// <summary></summary>
        [DisplayName("Skqrer")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Skqrer", "", "varchar(50)")]
        public String Skqrer { get { return _Skqrer; } set { if (OnPropertyChanging(__.Skqrer, value)) { _Skqrer = value; OnPropertyChanged(__.Skqrer); } } }

        private DateTime _Skqrdate;
        /// <summary></summary>
        [DisplayName("Skqrdate")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Skqrdate", "", "smalldatetime")]
        public DateTime Skqrdate { get { return _Skqrdate; } set { if (OnPropertyChanging(__.Skqrdate, value)) { _Skqrdate = value; OnPropertyChanged(__.Skqrdate); } } }

        private String _Sjskr;
        /// <summary></summary>
        [DisplayName("Sjskr")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Sjskr", "", "varchar(50)")]
        public String Sjskr { get { return _Sjskr; } set { if (OnPropertyChanging(__.Sjskr, value)) { _Sjskr = value; OnPropertyChanged(__.Sjskr); } } }

        private Int16 _Ygbz;
        /// <summary>预估标志</summary>
        [DisplayName("预估标志")]
        [Description("预估标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Ygbz", "预估标志", "")]
        public Int16 Ygbz { get { return _Ygbz; } set { if (OnPropertyChanging(__.Ygbz, value)) { _Ygbz = value; OnPropertyChanged(__.Ygbz); } } }

        private DateTime _Ygrq;
        /// <summary>预估日期</summary>
        [DisplayName("预估日期")]
        [Description("预估日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Ygrq", "预估日期", "smalldatetime")]
        public DateTime Ygrq { get { return _Ygrq; } set { if (OnPropertyChanging(__.Ygrq, value)) { _Ygrq = value; OnPropertyChanged(__.Ygrq); } } }

        private String _Ygr;
        /// <summary>预估人</summary>
        [DisplayName("预估人")]
        [Description("预估人")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Ygr", "预估人", "varchar(20)")]
        public String Ygr { get { return _Ygr; } set { if (OnPropertyChanging(__.Ygr, value)) { _Ygr = value; OnPropertyChanged(__.Ygr); } } }

        private Int16 _Pcbz;
        /// <summary>排产标志</summary>
        [DisplayName("排产标志")]
        [Description("排产标志")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Pcbz", "排产标志", "")]
        public Int16 Pcbz { get { return _Pcbz; } set { if (OnPropertyChanging(__.Pcbz, value)) { _Pcbz = value; OnPropertyChanged(__.Pcbz); } } }

        private DateTime _Pcrq;
        /// <summary>排产日期</summary>
        [DisplayName("排产日期")]
        [Description("排产日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Pcrq", "排产日期", "smalldatetime")]
        public DateTime Pcrq { get { return _Pcrq; } set { if (OnPropertyChanging(__.Pcrq, value)) { _Pcrq = value; OnPropertyChanged(__.Pcrq); } } }

        private String _Pcr;
        /// <summary>排产人</summary>
        [DisplayName("排产人")]
        [Description("排产人")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Pcr", "排产人", "varchar(20)")]
        public String Pcr { get { return _Pcr; } set { if (OnPropertyChanging(__.Pcr, value)) { _Pcr = value; OnPropertyChanged(__.Pcr); } } }

        private Int16 _Jhxsbz;
        /// <summary></summary>
        [DisplayName("Jhxsbz")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Jhxsbz", "", "")]
        public Int16 Jhxsbz { get { return _Jhxsbz; } set { if (OnPropertyChanging(__.Jhxsbz, value)) { _Jhxsbz = value; OnPropertyChanged(__.Jhxsbz); } } }

        private Int16 _Sjshqrbz;
        /// <summary></summary>
        [DisplayName("Sjshqrbz")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Sjshqrbz", "", "")]
        public Int16 Sjshqrbz { get { return _Sjshqrbz; } set { if (OnPropertyChanging(__.Sjshqrbz, value)) { _Sjshqrbz = value; OnPropertyChanged(__.Sjshqrbz); } } }

        private DateTime _Sjshqrrq;
        /// <summary></summary>
        [DisplayName("Sjshqrrq")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Sjshqrrq", "", "smalldatetime")]
        public DateTime Sjshqrrq { get { return _Sjshqrrq; } set { if (OnPropertyChanging(__.Sjshqrrq, value)) { _Sjshqrrq = value; OnPropertyChanged(__.Sjshqrrq); } } }

        private String _Sjshqrer;
        /// <summary></summary>
        [DisplayName("Sjshqrer")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Sjshqrer", "", "varchar(20)")]
        public String Sjshqrer { get { return _Sjshqrer; } set { if (OnPropertyChanging(__.Sjshqrer, value)) { _Sjshqrer = value; OnPropertyChanged(__.Sjshqrer); } } }

        private Int16 _Kpqrbz;
        /// <summary></summary>
        [DisplayName("Kpqrbz")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Kpqrbz", "", "")]
        public Int16 Kpqrbz { get { return _Kpqrbz; } set { if (OnPropertyChanging(__.Kpqrbz, value)) { _Kpqrbz = value; OnPropertyChanged(__.Kpqrbz); } } }

        private String _CarNo;
        /// <summary>车牌号</summary>
        [DisplayName("车牌号")]
        [Description("车牌号")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("CarNo", "车牌号", "varchar(20)")]
        public String CarNo { get { return _CarNo; } set { if (OnPropertyChanging(__.CarNo, value)) { _CarNo = value; OnPropertyChanged(__.CarNo); } } }

        private DateTime _Fhqrdateys;
        /// <summary></summary>
        [DisplayName("Fhqrdateys")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Fhqrdateys", "", "smalldatetime")]
        public DateTime Fhqrdateys { get { return _Fhqrdateys; } set { if (OnPropertyChanging(__.Fhqrdateys, value)) { _Fhqrdateys = value; OnPropertyChanged(__.Fhqrdateys); } } }

        private Int16 _KCblnOutStock;
        /// <summary></summary>
        [DisplayName("KCblnOutStock")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("KCblnOutStock", "", "")]
        public Int16 KCblnOutStock { get { return _KCblnOutStock; } set { if (OnPropertyChanging(__.KCblnOutStock, value)) { _KCblnOutStock = value; OnPropertyChanged(__.KCblnOutStock); } } }

        private Int16 _KcBlnoutstock;
        /// <summary></summary>
        [DisplayName("KcBlnoutstock")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("KC_blnOutStock", "", "")]
        public Int16 KcBlnoutstock { get { return _KcBlnoutstock; } set { if (OnPropertyChanging(__.KcBlnoutstock, value)) { _KcBlnoutstock = value; OnPropertyChanged(__.KcBlnoutstock); } } }

        private String _KcStocker;
        /// <summary></summary>
        [DisplayName("KcStocker")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("KC_Stocker", "", "varchar(20)")]
        public String KcStocker { get { return _KcStocker; } set { if (OnPropertyChanging(__.KcStocker, value)) { _KcStocker = value; OnPropertyChanged(__.KcStocker); } } }

        private String _KcStockno;
        /// <summary></summary>
        [DisplayName("KcStockno")]
        [DataObjectField(false, false, true, 120)]
        [BindColumn("KC_StockNo", "", "varchar(120)")]
        public String KcStockno { get { return _KcStockno; } set { if (OnPropertyChanging(__.KcStockno, value)) { _KcStockno = value; OnPropertyChanged(__.KcStockno); } } }

        private String _Custname;
        /// <summary>客户名称</summary>
        [DisplayName("客户名称")]
        [Description("客户名称")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Custname", "客户名称", "")]
        public String Custname { get { return _Custname; } set { if (OnPropertyChanging(__.Custname, value)) { _Custname = value; OnPropertyChanged(__.Custname); } } }

        private String _Tel;
        /// <summary>客户电话</summary>
        [DisplayName("客户电话")]
        [Description("客户电话")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Tel", "客户电话", "")]
        public String Tel { get { return _Tel; } set { if (OnPropertyChanging(__.Tel, value)) { _Tel = value; OnPropertyChanged(__.Tel); } } }

        private String _Caddress;
        /// <summary>客户地址</summary>
        [DisplayName("客户地址")]
        [Description("客户地址")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Caddress", "客户地址", "")]
        public String Caddress { get { return _Caddress; } set { if (OnPropertyChanging(__.Caddress, value)) { _Caddress = value; OnPropertyChanged(__.Caddress); } } }

        private Int64 _Apid;
        /// <summary>线路安排ID</summary>
        [DisplayName("线路安排ID")]
        [Description("线路安排ID")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Apid", "线路安排ID", "")]
        public Int64 Apid { get { return _Apid; } set { if (OnPropertyChanging(__.Apid, value)) { _Apid = value; OnPropertyChanged(__.Apid); } } }

        private Int64 _Pcid;
        /// <summary>排产ID</summary>
        [DisplayName("排产ID")]
        [Description("排产ID")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Pcid", "排产ID", "")]
        public Int64 Pcid { get { return _Pcid; } set { if (OnPropertyChanging(__.Pcid, value)) { _Pcid = value; OnPropertyChanged(__.Pcid); } } }

        private Int64 _Rlid;
        /// <summary>线路ID</summary>
        [DisplayName("线路ID")]
        [Description("线路ID")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Rlid", "线路ID", "")]
        public Int64 Rlid { get { return _Rlid; } set { if (OnPropertyChanging(__.Rlid, value)) { _Rlid = value; OnPropertyChanged(__.Rlid); } } }

        private Int16 _SHType;
        /// <summary></summary>
        [DisplayName("SHType")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("SHType", "", "")]
        public Int16 SHType { get { return _SHType; } set { if (OnPropertyChanging(__.SHType, value)) { _SHType = value; OnPropertyChanged(__.SHType); } } }

        private String _PcdScno;
        /// <summary></summary>
        [DisplayName("PcdScno")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PCD_scno", "", "")]
        public String PcdScno { get { return _PcdScno; } set { if (OnPropertyChanging(__.PcdScno, value)) { _PcdScno = value; OnPropertyChanged(__.PcdScno); } } }

        private String _Pdsdr;
        /// <summary></summary>
        [DisplayName("Pdsdr")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Pdsdr", "", "")]
        public String Pdsdr { get { return _Pdsdr; } set { if (OnPropertyChanging(__.Pdsdr, value)) { _Pdsdr = value; OnPropertyChanged(__.Pdsdr); } } }

        private DateTime _Pdsdrq;
        /// <summary></summary>
        [DisplayName("Pdsdrq")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Pdsdrq", "", "")]
        public DateTime Pdsdrq { get { return _Pdsdrq; } set { if (OnPropertyChanging(__.Pdsdrq, value)) { _Pdsdrq = value; OnPropertyChanged(__.Pdsdrq); } } }

        private String _Pdsdzdr;
        /// <summary></summary>
        [DisplayName("Pdsdzdr")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Pdsdzdr", "", "")]
        public String Pdsdzdr { get { return _Pdsdzdr; } set { if (OnPropertyChanging(__.Pdsdzdr, value)) { _Pdsdzdr = value; OnPropertyChanged(__.Pdsdzdr); } } }

        private DateTime _Pdsdrqtime;
        /// <summary></summary>
        [DisplayName("Pdsdrqtime")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Pdsdrqtime", "", "")]
        public DateTime Pdsdrqtime { get { return _Pdsdrqtime; } set { if (OnPropertyChanging(__.Pdsdrqtime, value)) { _Pdsdrqtime = value; OnPropertyChanged(__.Pdsdrqtime); } } }

        private Int32 _iYear;
        /// <summary>单据所属年份</summary>
        [DisplayName("单据所属年份")]
        [Description("单据所属年份")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("iYear", "单据所属年份", "")]
        public Int32 iYear { get { return _iYear; } set { if (OnPropertyChanging(__.iYear, value)) { _iYear = value; OnPropertyChanged(__.iYear); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Lsbh : return _Lsbh;
                    case __.EviNO : return _EviNO;
                    case __.EviDate : return _EviDate;
                    case __.PlanPayDate : return _PlanPayDate;
                    case __.SumQty : return _SumQty;
                    case __.SumNQty : return _SumNQty;
                    case __.SumWeight : return _SumWeight;
                    case __.SumAmount : return _SumAmount;
                    case __.Verifier : return _Verifier;
                    case __.Verified : return _Verified;
                    case __.Verifierdate : return _Verifierdate;
                    case __.CustID : return _CustID;
                    case __.Person : return _Person;
                    case __.Driver : return _Driver;
                    case __.Poster : return _Poster;
                    case __.Payed : return _Payed;
                    case __.PayNO : return _PayNO;
                    case __.CreatDate : return _CreatDate;
                    case __.Creater : return _Creater;
                    case __.LastDate : return _LastDate;
                    case __.Laster : return _Laster;
                    case __.PayType : return _PayType;
                    case __.Summary : return _Summary;
                    case __.Payer : return _Payer;
                    case __.Invoiced : return _Invoiced;
                    case __.Invoicer : return _Invoicer;
                    case __.InvoiceNo : return _InvoiceNo;
                    case __.AreaID : return _AreaID;
                    case __.PrevArea : return _PrevArea;
                    case __.EviType : return _EviType;
                    case __.FreightWay : return _FreightWay;
                    case __.Helper : return _Helper;
                    case __.Verifiertime : return _Verifiertime;
                    case __.blnOutStock : return _blnOutStock;
                    case __.StockNo : return _StockNo;
                    case __.Stocker : return _Stocker;
                    case __.EviBSC : return _EviBSC;
                    case __.Shrq : return _Shrq;
                    case __.Shbz : return _Shbz;
                    case __.Shsm : return _Shsm;
                    case __.Shqrsj : return _Shqrsj;
                    case __.Shqrrq : return _Shqrrq;
                    case __.Shqrer : return _Shqrer;
                    case __.iMonth : return _iMonth;
                    case __.DrvName : return _DrvName;
                    case __.YFKid : return _YFKid;
                    case __.Xdr : return _Xdr;
                    case __.Ddsx : return _Ddsx;
                    case __.Fhqrbz : return _Fhqrbz;
                    case __.Fhqrer : return _Fhqrer;
                    case __.Fhqrdate : return _Fhqrdate;
                    case __.Skqrbz : return _Skqrbz;
                    case __.Skqrer : return _Skqrer;
                    case __.Skqrdate : return _Skqrdate;
                    case __.Sjskr : return _Sjskr;
                    case __.Ygbz : return _Ygbz;
                    case __.Ygrq : return _Ygrq;
                    case __.Ygr : return _Ygr;
                    case __.Pcbz : return _Pcbz;
                    case __.Pcrq : return _Pcrq;
                    case __.Pcr : return _Pcr;
                    case __.Jhxsbz : return _Jhxsbz;
                    case __.Sjshqrbz : return _Sjshqrbz;
                    case __.Sjshqrrq : return _Sjshqrrq;
                    case __.Sjshqrer : return _Sjshqrer;
                    case __.Kpqrbz : return _Kpqrbz;
                    case __.CarNo : return _CarNo;
                    case __.Fhqrdateys : return _Fhqrdateys;
                    case __.KCblnOutStock : return _KCblnOutStock;
                    case __.KcBlnoutstock : return _KcBlnoutstock;
                    case __.KcStocker : return _KcStocker;
                    case __.KcStockno : return _KcStockno;
                    case __.Custname : return _Custname;
                    case __.Tel : return _Tel;
                    case __.Caddress : return _Caddress;
                    case __.Apid : return _Apid;
                    case __.Pcid : return _Pcid;
                    case __.Rlid : return _Rlid;
                    case __.SHType : return _SHType;
                    case __.PcdScno : return _PcdScno;
                    case __.Pdsdr : return _Pdsdr;
                    case __.Pdsdrq : return _Pdsdrq;
                    case __.Pdsdzdr : return _Pdsdzdr;
                    case __.Pdsdrqtime : return _Pdsdrqtime;
                    case __.iYear : return _iYear;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = value.ToInt(); break;
                    case __.Lsbh : _Lsbh = value.ToInt(); break;
                    case __.EviNO : _EviNO = Convert.ToString(value); break;
                    case __.EviDate : _EviDate = value.ToDateTime(); break;
                    case __.PlanPayDate : _PlanPayDate = value.ToDateTime(); break;
                    case __.SumQty : _SumQty = value.ToDouble(); break;
                    case __.SumNQty : _SumNQty = value.ToDouble(); break;
                    case __.SumWeight : _SumWeight = value.ToDouble(); break;
                    case __.SumAmount : _SumAmount = value.ToDouble(); break;
                    case __.Verifier : _Verifier = Convert.ToString(value); break;
                    case __.Verified : _Verified = Convert.ToByte(value); break;
                    case __.Verifierdate : _Verifierdate = value.ToDateTime(); break;
                    case __.CustID : _CustID = Convert.ToString(value); break;
                    case __.Person : _Person = Convert.ToString(value); break;
                    case __.Driver : _Driver = Convert.ToString(value); break;
                    case __.Poster : _Poster = Convert.ToString(value); break;
                    case __.Payed : _Payed = Convert.ToByte(value); break;
                    case __.PayNO : _PayNO = Convert.ToString(value); break;
                    case __.CreatDate : _CreatDate = value.ToDateTime(); break;
                    case __.Creater : _Creater = Convert.ToString(value); break;
                    case __.LastDate : _LastDate = value.ToDateTime(); break;
                    case __.Laster : _Laster = Convert.ToString(value); break;
                    case __.PayType : _PayType = value.ToBoolean(); break;
                    case __.Summary : _Summary = Convert.ToString(value); break;
                    case __.Payer : _Payer = Convert.ToString(value); break;
                    case __.Invoiced : _Invoiced = Convert.ToByte(value); break;
                    case __.Invoicer : _Invoicer = Convert.ToString(value); break;
                    case __.InvoiceNo : _InvoiceNo = Convert.ToString(value); break;
                    case __.AreaID : _AreaID = Convert.ToString(value); break;
                    case __.PrevArea : _PrevArea = Convert.ToString(value); break;
                    case __.EviType : _EviType = value.ToBoolean(); break;
                    case __.FreightWay : _FreightWay = Convert.ToInt16(value); break;
                    case __.Helper : _Helper = Convert.ToString(value); break;
                    case __.Verifiertime : _Verifiertime = value.ToDateTime(); break;
                    case __.blnOutStock : _blnOutStock = Convert.ToInt16(value); break;
                    case __.StockNo : _StockNo = Convert.ToString(value); break;
                    case __.Stocker : _Stocker = Convert.ToString(value); break;
                    case __.EviBSC : _EviBSC = Convert.ToString(value); break;
                    case __.Shrq : _Shrq = value.ToDateTime(); break;
                    case __.Shbz : _Shbz = Convert.ToInt16(value); break;
                    case __.Shsm : _Shsm = Convert.ToString(value); break;
                    case __.Shqrsj : _Shqrsj = value.ToDateTime(); break;
                    case __.Shqrrq : _Shqrrq = value.ToDateTime(); break;
                    case __.Shqrer : _Shqrer = Convert.ToString(value); break;
                    case __.iMonth : _iMonth = value.ToInt(); break;
                    case __.DrvName : _DrvName = Convert.ToString(value); break;
                    case __.YFKid : _YFKid = value.ToInt(); break;
                    case __.Xdr : _Xdr = Convert.ToString(value); break;
                    case __.Ddsx : _Ddsx = Convert.ToString(value); break;
                    case __.Fhqrbz : _Fhqrbz = Convert.ToInt16(value); break;
                    case __.Fhqrer : _Fhqrer = Convert.ToString(value); break;
                    case __.Fhqrdate : _Fhqrdate = value.ToDateTime(); break;
                    case __.Skqrbz : _Skqrbz = Convert.ToInt16(value); break;
                    case __.Skqrer : _Skqrer = Convert.ToString(value); break;
                    case __.Skqrdate : _Skqrdate = value.ToDateTime(); break;
                    case __.Sjskr : _Sjskr = Convert.ToString(value); break;
                    case __.Ygbz : _Ygbz = Convert.ToInt16(value); break;
                    case __.Ygrq : _Ygrq = value.ToDateTime(); break;
                    case __.Ygr : _Ygr = Convert.ToString(value); break;
                    case __.Pcbz : _Pcbz = Convert.ToInt16(value); break;
                    case __.Pcrq : _Pcrq = value.ToDateTime(); break;
                    case __.Pcr : _Pcr = Convert.ToString(value); break;
                    case __.Jhxsbz : _Jhxsbz = Convert.ToInt16(value); break;
                    case __.Sjshqrbz : _Sjshqrbz = Convert.ToInt16(value); break;
                    case __.Sjshqrrq : _Sjshqrrq = value.ToDateTime(); break;
                    case __.Sjshqrer : _Sjshqrer = Convert.ToString(value); break;
                    case __.Kpqrbz : _Kpqrbz = Convert.ToInt16(value); break;
                    case __.CarNo : _CarNo = Convert.ToString(value); break;
                    case __.Fhqrdateys : _Fhqrdateys = value.ToDateTime(); break;
                    case __.KCblnOutStock : _KCblnOutStock = Convert.ToInt16(value); break;
                    case __.KcBlnoutstock : _KcBlnoutstock = Convert.ToInt16(value); break;
                    case __.KcStocker : _KcStocker = Convert.ToString(value); break;
                    case __.KcStockno : _KcStockno = Convert.ToString(value); break;
                    case __.Custname : _Custname = Convert.ToString(value); break;
                    case __.Tel : _Tel = Convert.ToString(value); break;
                    case __.Caddress : _Caddress = Convert.ToString(value); break;
                    case __.Apid : _Apid = value.ToLong(); break;
                    case __.Pcid : _Pcid = value.ToLong(); break;
                    case __.Rlid : _Rlid = value.ToLong(); break;
                    case __.SHType : _SHType = Convert.ToInt16(value); break;
                    case __.PcdScno : _PcdScno = Convert.ToString(value); break;
                    case __.Pdsdr : _Pdsdr = Convert.ToString(value); break;
                    case __.Pdsdrq : _Pdsdrq = value.ToDateTime(); break;
                    case __.Pdsdzdr : _Pdsdzdr = Convert.ToString(value); break;
                    case __.Pdsdrqtime : _Pdsdrqtime = value.ToDateTime(); break;
                    case __.iYear : _iYear = value.ToInt(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得销售订单表头字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>自增ID</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>可编辑流失编号</summary>
            public static readonly Field Lsbh = FindByName(__.Lsbh);

            /// <summary>单据编号</summary>
            public static readonly Field EviNO = FindByName(__.EviNO);

            /// <summary>单据日期</summary>
            public static readonly Field EviDate = FindByName(__.EviDate);

            /// <summary>计划收款日期</summary>
            public static readonly Field PlanPayDate = FindByName(__.PlanPayDate);

            /// <summary>单据合计数量</summary>
            public static readonly Field SumQty = FindByName(__.SumQty);

            /// <summary>单据合计件数</summary>
            public static readonly Field SumNQty = FindByName(__.SumNQty);

            /// <summary>单据合计重量</summary>
            public static readonly Field SumWeight = FindByName(__.SumWeight);

            /// <summary>单据合计金额</summary>
            public static readonly Field SumAmount = FindByName(__.SumAmount);

            /// <summary>审核人</summary>
            public static readonly Field Verifier = FindByName(__.Verifier);

            /// <summary>审核标志</summary>
            public static readonly Field Verified = FindByName(__.Verified);

            /// <summary>审核日期</summary>
            public static readonly Field Verifierdate = FindByName(__.Verifierdate);

            /// <summary>客户编号</summary>
            public static readonly Field CustID = FindByName(__.CustID);

            /// <summary>责任业务</summary>
            public static readonly Field Person = FindByName(__.Person);

            /// <summary>配送司机</summary>
            public static readonly Field Driver = FindByName(__.Driver);

            /// <summary></summary>
            public static readonly Field Poster = FindByName(__.Poster);

            /// <summary>收款标志</summary>
            public static readonly Field Payed = FindByName(__.Payed);

            /// <summary>收款单号</summary>
            public static readonly Field PayNO = FindByName(__.PayNO);

            /// <summary>创建时间</summary>
            public static readonly Field CreatDate = FindByName(__.CreatDate);

            /// <summary>创建人</summary>
            public static readonly Field Creater = FindByName(__.Creater);

            /// <summary>最后修改时间</summary>
            public static readonly Field LastDate = FindByName(__.LastDate);

            /// <summary>最后修改人</summary>
            public static readonly Field Laster = FindByName(__.Laster);

            /// <summary>付款类型</summary>
            public static readonly Field PayType = FindByName(__.PayType);

            /// <summary>单据备注</summary>
            public static readonly Field Summary = FindByName(__.Summary);

            /// <summary>收款人</summary>
            public static readonly Field Payer = FindByName(__.Payer);

            /// <summary>开票标志</summary>
            public static readonly Field Invoiced = FindByName(__.Invoiced);

            /// <summary>开票人</summary>
            public static readonly Field Invoicer = FindByName(__.Invoicer);

            /// <summary>开票单号</summary>
            public static readonly Field InvoiceNo = FindByName(__.InvoiceNo);

            /// <summary>管理区域编号</summary>
            public static readonly Field AreaID = FindByName(__.AreaID);

            /// <summary>上级管理区域编号</summary>
            public static readonly Field PrevArea = FindByName(__.PrevArea);

            /// <summary>单据类型</summary>
            public static readonly Field EviType = FindByName(__.EviType);

            /// <summary>送货方式</summary>
            public static readonly Field FreightWay = FindByName(__.FreightWay);

            /// <summary>协运人</summary>
            public static readonly Field Helper = FindByName(__.Helper);

            /// <summary>审核时间</summary>
            public static readonly Field Verifiertime = FindByName(__.Verifiertime);

            /// <summary>出库标志</summary>
            public static readonly Field blnOutStock = FindByName(__.blnOutStock);

            /// <summary>出库单号</summary>
            public static readonly Field StockNo = FindByName(__.StockNo);

            /// <summary></summary>
            public static readonly Field Stocker = FindByName(__.Stocker);

            /// <summary>办事处区域</summary>
            public static readonly Field EviBSC = FindByName(__.EviBSC);

            /// <summary>送货日期</summary>
            public static readonly Field Shrq = FindByName(__.Shrq);

            /// <summary>送货标志</summary>
            public static readonly Field Shbz = FindByName(__.Shbz);

            /// <summary>销售单送货说明</summary>
            public static readonly Field Shsm = FindByName(__.Shsm);

            /// <summary>送货确认时间</summary>
            public static readonly Field Shqrsj = FindByName(__.Shqrsj);

            /// <summary>送货确认日期</summary>
            public static readonly Field Shqrrq = FindByName(__.Shqrrq);

            /// <summary>送货确认人</summary>
            public static readonly Field Shqrer = FindByName(__.Shqrer);

            /// <summary>单据所属月份</summary>
            public static readonly Field iMonth = FindByName(__.iMonth);

            /// <summary>跟单人员</summary>
            public static readonly Field DrvName = FindByName(__.DrvName);

            /// <summary>预付款ID</summary>
            public static readonly Field YFKid = FindByName(__.YFKid);

            /// <summary>下单人</summary>
            public static readonly Field Xdr = FindByName(__.Xdr);

            /// <summary></summary>
            public static readonly Field Ddsx = FindByName(__.Ddsx);

            /// <summary>发货货确认标志</summary>
            public static readonly Field Fhqrbz = FindByName(__.Fhqrbz);

            /// <summary>发货货确认人</summary>
            public static readonly Field Fhqrer = FindByName(__.Fhqrer);

            /// <summary>发货货确认日期</summary>
            public static readonly Field Fhqrdate = FindByName(__.Fhqrdate);

            /// <summary></summary>
            public static readonly Field Skqrbz = FindByName(__.Skqrbz);

            /// <summary></summary>
            public static readonly Field Skqrer = FindByName(__.Skqrer);

            /// <summary></summary>
            public static readonly Field Skqrdate = FindByName(__.Skqrdate);

            /// <summary></summary>
            public static readonly Field Sjskr = FindByName(__.Sjskr);

            /// <summary>预估标志</summary>
            public static readonly Field Ygbz = FindByName(__.Ygbz);

            /// <summary>预估日期</summary>
            public static readonly Field Ygrq = FindByName(__.Ygrq);

            /// <summary>预估人</summary>
            public static readonly Field Ygr = FindByName(__.Ygr);

            /// <summary>排产标志</summary>
            public static readonly Field Pcbz = FindByName(__.Pcbz);

            /// <summary>排产日期</summary>
            public static readonly Field Pcrq = FindByName(__.Pcrq);

            /// <summary>排产人</summary>
            public static readonly Field Pcr = FindByName(__.Pcr);

            /// <summary></summary>
            public static readonly Field Jhxsbz = FindByName(__.Jhxsbz);

            /// <summary></summary>
            public static readonly Field Sjshqrbz = FindByName(__.Sjshqrbz);

            /// <summary></summary>
            public static readonly Field Sjshqrrq = FindByName(__.Sjshqrrq);

            /// <summary></summary>
            public static readonly Field Sjshqrer = FindByName(__.Sjshqrer);

            /// <summary></summary>
            public static readonly Field Kpqrbz = FindByName(__.Kpqrbz);

            /// <summary>车牌号</summary>
            public static readonly Field CarNo = FindByName(__.CarNo);

            /// <summary></summary>
            public static readonly Field Fhqrdateys = FindByName(__.Fhqrdateys);

            /// <summary></summary>
            public static readonly Field KCblnOutStock = FindByName(__.KCblnOutStock);

            /// <summary></summary>
            public static readonly Field KcBlnoutstock = FindByName(__.KcBlnoutstock);

            /// <summary></summary>
            public static readonly Field KcStocker = FindByName(__.KcStocker);

            /// <summary></summary>
            public static readonly Field KcStockno = FindByName(__.KcStockno);

            /// <summary>客户名称</summary>
            public static readonly Field Custname = FindByName(__.Custname);

            /// <summary>客户电话</summary>
            public static readonly Field Tel = FindByName(__.Tel);

            /// <summary>客户地址</summary>
            public static readonly Field Caddress = FindByName(__.Caddress);

            /// <summary>线路安排ID</summary>
            public static readonly Field Apid = FindByName(__.Apid);

            /// <summary>排产ID</summary>
            public static readonly Field Pcid = FindByName(__.Pcid);

            /// <summary>线路ID</summary>
            public static readonly Field Rlid = FindByName(__.Rlid);

            /// <summary></summary>
            public static readonly Field SHType = FindByName(__.SHType);

            /// <summary></summary>
            public static readonly Field PcdScno = FindByName(__.PcdScno);

            /// <summary></summary>
            public static readonly Field Pdsdr = FindByName(__.Pdsdr);

            /// <summary></summary>
            public static readonly Field Pdsdrq = FindByName(__.Pdsdrq);

            /// <summary></summary>
            public static readonly Field Pdsdzdr = FindByName(__.Pdsdzdr);

            /// <summary></summary>
            public static readonly Field Pdsdrqtime = FindByName(__.Pdsdrqtime);

            /// <summary>单据所属年份</summary>
            public static readonly Field iYear = FindByName(__.iYear);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得销售订单表头字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>自增ID</summary>
            public const String ID = "ID";

            /// <summary>可编辑流失编号</summary>
            public const String Lsbh = "Lsbh";

            /// <summary>单据编号</summary>
            public const String EviNO = "EviNO";

            /// <summary>单据日期</summary>
            public const String EviDate = "EviDate";

            /// <summary>计划收款日期</summary>
            public const String PlanPayDate = "PlanPayDate";

            /// <summary>单据合计数量</summary>
            public const String SumQty = "SumQty";

            /// <summary>单据合计件数</summary>
            public const String SumNQty = "SumNQty";

            /// <summary>单据合计重量</summary>
            public const String SumWeight = "SumWeight";

            /// <summary>单据合计金额</summary>
            public const String SumAmount = "SumAmount";

            /// <summary>审核人</summary>
            public const String Verifier = "Verifier";

            /// <summary>审核标志</summary>
            public const String Verified = "Verified";

            /// <summary>审核日期</summary>
            public const String Verifierdate = "Verifierdate";

            /// <summary>客户编号</summary>
            public const String CustID = "CustID";

            /// <summary>责任业务</summary>
            public const String Person = "Person";

            /// <summary>配送司机</summary>
            public const String Driver = "Driver";

            /// <summary></summary>
            public const String Poster = "Poster";

            /// <summary>收款标志</summary>
            public const String Payed = "Payed";

            /// <summary>收款单号</summary>
            public const String PayNO = "PayNO";

            /// <summary>创建时间</summary>
            public const String CreatDate = "CreatDate";

            /// <summary>创建人</summary>
            public const String Creater = "Creater";

            /// <summary>最后修改时间</summary>
            public const String LastDate = "LastDate";

            /// <summary>最后修改人</summary>
            public const String Laster = "Laster";

            /// <summary>付款类型</summary>
            public const String PayType = "PayType";

            /// <summary>单据备注</summary>
            public const String Summary = "Summary";

            /// <summary>收款人</summary>
            public const String Payer = "Payer";

            /// <summary>开票标志</summary>
            public const String Invoiced = "Invoiced";

            /// <summary>开票人</summary>
            public const String Invoicer = "Invoicer";

            /// <summary>开票单号</summary>
            public const String InvoiceNo = "InvoiceNo";

            /// <summary>管理区域编号</summary>
            public const String AreaID = "AreaID";

            /// <summary>上级管理区域编号</summary>
            public const String PrevArea = "PrevArea";

            /// <summary>单据类型</summary>
            public const String EviType = "EviType";

            /// <summary>送货方式</summary>
            public const String FreightWay = "FreightWay";

            /// <summary>协运人</summary>
            public const String Helper = "Helper";

            /// <summary>审核时间</summary>
            public const String Verifiertime = "Verifiertime";

            /// <summary>出库标志</summary>
            public const String blnOutStock = "blnOutStock";

            /// <summary>出库单号</summary>
            public const String StockNo = "StockNo";

            /// <summary></summary>
            public const String Stocker = "Stocker";

            /// <summary>办事处区域</summary>
            public const String EviBSC = "EviBSC";

            /// <summary>送货日期</summary>
            public const String Shrq = "Shrq";

            /// <summary>送货标志</summary>
            public const String Shbz = "Shbz";

            /// <summary>销售单送货说明</summary>
            public const String Shsm = "Shsm";

            /// <summary>送货确认时间</summary>
            public const String Shqrsj = "Shqrsj";

            /// <summary>送货确认日期</summary>
            public const String Shqrrq = "Shqrrq";

            /// <summary>送货确认人</summary>
            public const String Shqrer = "Shqrer";

            /// <summary>单据所属月份</summary>
            public const String iMonth = "iMonth";

            /// <summary>跟单人员</summary>
            public const String DrvName = "DrvName";

            /// <summary>预付款ID</summary>
            public const String YFKid = "YFKid";

            /// <summary>下单人</summary>
            public const String Xdr = "Xdr";

            /// <summary></summary>
            public const String Ddsx = "Ddsx";

            /// <summary>发货货确认标志</summary>
            public const String Fhqrbz = "Fhqrbz";

            /// <summary>发货货确认人</summary>
            public const String Fhqrer = "Fhqrer";

            /// <summary>发货货确认日期</summary>
            public const String Fhqrdate = "Fhqrdate";

            /// <summary></summary>
            public const String Skqrbz = "Skqrbz";

            /// <summary></summary>
            public const String Skqrer = "Skqrer";

            /// <summary></summary>
            public const String Skqrdate = "Skqrdate";

            /// <summary></summary>
            public const String Sjskr = "Sjskr";

            /// <summary>预估标志</summary>
            public const String Ygbz = "Ygbz";

            /// <summary>预估日期</summary>
            public const String Ygrq = "Ygrq";

            /// <summary>预估人</summary>
            public const String Ygr = "Ygr";

            /// <summary>排产标志</summary>
            public const String Pcbz = "Pcbz";

            /// <summary>排产日期</summary>
            public const String Pcrq = "Pcrq";

            /// <summary>排产人</summary>
            public const String Pcr = "Pcr";

            /// <summary></summary>
            public const String Jhxsbz = "Jhxsbz";

            /// <summary></summary>
            public const String Sjshqrbz = "Sjshqrbz";

            /// <summary></summary>
            public const String Sjshqrrq = "Sjshqrrq";

            /// <summary></summary>
            public const String Sjshqrer = "Sjshqrer";

            /// <summary></summary>
            public const String Kpqrbz = "Kpqrbz";

            /// <summary>车牌号</summary>
            public const String CarNo = "CarNo";

            /// <summary></summary>
            public const String Fhqrdateys = "Fhqrdateys";

            /// <summary></summary>
            public const String KCblnOutStock = "KCblnOutStock";

            /// <summary></summary>
            public const String KcBlnoutstock = "KcBlnoutstock";

            /// <summary></summary>
            public const String KcStocker = "KcStocker";

            /// <summary></summary>
            public const String KcStockno = "KcStockno";

            /// <summary>客户名称</summary>
            public const String Custname = "Custname";

            /// <summary>客户电话</summary>
            public const String Tel = "Tel";

            /// <summary>客户地址</summary>
            public const String Caddress = "Caddress";

            /// <summary>线路安排ID</summary>
            public const String Apid = "Apid";

            /// <summary>排产ID</summary>
            public const String Pcid = "Pcid";

            /// <summary>线路ID</summary>
            public const String Rlid = "Rlid";

            /// <summary></summary>
            public const String SHType = "SHType";

            /// <summary></summary>
            public const String PcdScno = "PcdScno";

            /// <summary></summary>
            public const String Pdsdr = "Pdsdr";

            /// <summary></summary>
            public const String Pdsdrq = "Pdsdrq";

            /// <summary></summary>
            public const String Pdsdzdr = "Pdsdzdr";

            /// <summary></summary>
            public const String Pdsdrqtime = "Pdsdrqtime";

            /// <summary>单据所属年份</summary>
            public const String iYear = "iYear";
        }
        #endregion
    }

    /// <summary>销售订单表头接口</summary>
    public partial interface IInv_Evi
    {
        #region 属性
        /// <summary>自增ID</summary>
        Int32 ID { get; set; }

        /// <summary>可编辑流失编号</summary>
        Int32 Lsbh { get; set; }

        /// <summary>单据编号</summary>
        String EviNO { get; set; }

        /// <summary>单据日期</summary>
        DateTime EviDate { get; set; }

        /// <summary>计划收款日期</summary>
        DateTime PlanPayDate { get; set; }

        /// <summary>单据合计数量</summary>
        Double SumQty { get; set; }

        /// <summary>单据合计件数</summary>
        Double SumNQty { get; set; }

        /// <summary>单据合计重量</summary>
        Double SumWeight { get; set; }

        /// <summary>单据合计金额</summary>
        Double SumAmount { get; set; }

        /// <summary>审核人</summary>
        String Verifier { get; set; }

        /// <summary>审核标志</summary>
        Byte Verified { get; set; }

        /// <summary>审核日期</summary>
        DateTime Verifierdate { get; set; }

        /// <summary>客户编号</summary>
        String CustID { get; set; }

        /// <summary>责任业务</summary>
        String Person { get; set; }

        /// <summary>配送司机</summary>
        String Driver { get; set; }

        /// <summary></summary>
        String Poster { get; set; }

        /// <summary>收款标志</summary>
        Byte Payed { get; set; }

        /// <summary>收款单号</summary>
        String PayNO { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreatDate { get; set; }

        /// <summary>创建人</summary>
        String Creater { get; set; }

        /// <summary>最后修改时间</summary>
        DateTime LastDate { get; set; }

        /// <summary>最后修改人</summary>
        String Laster { get; set; }

        /// <summary>付款类型</summary>
        Boolean PayType { get; set; }

        /// <summary>单据备注</summary>
        String Summary { get; set; }

        /// <summary>收款人</summary>
        String Payer { get; set; }

        /// <summary>开票标志</summary>
        Byte Invoiced { get; set; }

        /// <summary>开票人</summary>
        String Invoicer { get; set; }

        /// <summary>开票单号</summary>
        String InvoiceNo { get; set; }

        /// <summary>管理区域编号</summary>
        String AreaID { get; set; }

        /// <summary>上级管理区域编号</summary>
        String PrevArea { get; set; }

        /// <summary>单据类型</summary>
        Boolean EviType { get; set; }

        /// <summary>送货方式</summary>
        Int16 FreightWay { get; set; }

        /// <summary>协运人</summary>
        String Helper { get; set; }

        /// <summary>审核时间</summary>
        DateTime Verifiertime { get; set; }

        /// <summary>出库标志</summary>
        Int16 blnOutStock { get; set; }

        /// <summary>出库单号</summary>
        String StockNo { get; set; }

        /// <summary></summary>
        String Stocker { get; set; }

        /// <summary>办事处区域</summary>
        String EviBSC { get; set; }

        /// <summary>送货日期</summary>
        DateTime Shrq { get; set; }

        /// <summary>送货标志</summary>
        Int16 Shbz { get; set; }

        /// <summary>销售单送货说明</summary>
        String Shsm { get; set; }

        /// <summary>送货确认时间</summary>
        DateTime Shqrsj { get; set; }

        /// <summary>送货确认日期</summary>
        DateTime Shqrrq { get; set; }

        /// <summary>送货确认人</summary>
        String Shqrer { get; set; }

        /// <summary>单据所属月份</summary>
        Int32 iMonth { get; set; }

        /// <summary>跟单人员</summary>
        String DrvName { get; set; }

        /// <summary>预付款ID</summary>
        Int32 YFKid { get; set; }

        /// <summary>下单人</summary>
        String Xdr { get; set; }

        /// <summary></summary>
        String Ddsx { get; set; }

        /// <summary>发货货确认标志</summary>
        Int16 Fhqrbz { get; set; }

        /// <summary>发货货确认人</summary>
        String Fhqrer { get; set; }

        /// <summary>发货货确认日期</summary>
        DateTime Fhqrdate { get; set; }

        /// <summary></summary>
        Int16 Skqrbz { get; set; }

        /// <summary></summary>
        String Skqrer { get; set; }

        /// <summary></summary>
        DateTime Skqrdate { get; set; }

        /// <summary></summary>
        String Sjskr { get; set; }

        /// <summary>预估标志</summary>
        Int16 Ygbz { get; set; }

        /// <summary>预估日期</summary>
        DateTime Ygrq { get; set; }

        /// <summary>预估人</summary>
        String Ygr { get; set; }

        /// <summary>排产标志</summary>
        Int16 Pcbz { get; set; }

        /// <summary>排产日期</summary>
        DateTime Pcrq { get; set; }

        /// <summary>排产人</summary>
        String Pcr { get; set; }

        /// <summary></summary>
        Int16 Jhxsbz { get; set; }

        /// <summary></summary>
        Int16 Sjshqrbz { get; set; }

        /// <summary></summary>
        DateTime Sjshqrrq { get; set; }

        /// <summary></summary>
        String Sjshqrer { get; set; }

        /// <summary></summary>
        Int16 Kpqrbz { get; set; }

        /// <summary>车牌号</summary>
        String CarNo { get; set; }

        /// <summary></summary>
        DateTime Fhqrdateys { get; set; }

        /// <summary></summary>
        Int16 KCblnOutStock { get; set; }

        /// <summary></summary>
        Int16 KcBlnoutstock { get; set; }

        /// <summary></summary>
        String KcStocker { get; set; }

        /// <summary></summary>
        String KcStockno { get; set; }

        /// <summary>客户名称</summary>
        String Custname { get; set; }

        /// <summary>客户电话</summary>
        String Tel { get; set; }

        /// <summary>客户地址</summary>
        String Caddress { get; set; }

        /// <summary>线路安排ID</summary>
        Int64 Apid { get; set; }

        /// <summary>排产ID</summary>
        Int64 Pcid { get; set; }

        /// <summary>线路ID</summary>
        Int64 Rlid { get; set; }

        /// <summary></summary>
        Int16 SHType { get; set; }

        /// <summary></summary>
        String PcdScno { get; set; }

        /// <summary></summary>
        String Pdsdr { get; set; }

        /// <summary></summary>
        DateTime Pdsdrq { get; set; }

        /// <summary></summary>
        String Pdsdzdr { get; set; }

        /// <summary></summary>
        DateTime Pdsdrqtime { get; set; }

        /// <summary>单据所属年份</summary>
        Int32 iYear { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}