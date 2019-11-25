using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace XCode.Membership
{
    /// <summary>销售订单表体</summary>
    [Serializable]
    [DataObject]
    [Description("销售订单表体")]
    [BindIndex("lsbh", false, "LSBH")]
    [BindIndex("PK_Evi_Detail", true, "LSBH,EviNO,InvID")]
    [BindTable("Inv_Evi_Detail", Description = "销售订单表体", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Inv_Evi_Detail : IInv_Evi_Detail
    {
        #region 属性
        private Int32 _Lsbh;
        /// <summary>销售订单表头流水编号</summary>
        [DisplayName("销售订单表头流水编号")]
        [Description("销售订单表头流水编号")]
        [DataObjectField(true, false, false, 0)]
        [BindColumn("Lsbh", "销售订单表头流水编号", "")]
        public Int32 Lsbh { get { return _Lsbh; } set { if (OnPropertyChanging(__.Lsbh, value)) { _Lsbh = value; OnPropertyChanged(__.Lsbh); } } }

        private String _EviNO;
        /// <summary>销售订单号</summary>
        [DisplayName("销售订单号")]
        [Description("销售订单号")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("EviNO", "销售订单号", "varchar(50)")]
        public String EviNO { get { return _EviNO; } set { if (OnPropertyChanging(__.EviNO, value)) { _EviNO = value; OnPropertyChanged(__.EviNO); } } }

        private String _InvID;
        /// <summary>产品编号</summary>
        [DisplayName("产品编号")]
        [Description("产品编号")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("InvID", "产品编号", "varchar(50)")]
        public String InvID { get { return _InvID; } set { if (OnPropertyChanging(__.InvID, value)) { _InvID = value; OnPropertyChanged(__.InvID); } } }

        private Double _Qty;
        /// <summary>数量</summary>
        [DisplayName("数量")]
        [Description("数量")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Qty", "数量", "float")]
        public Double Qty { get { return _Qty; } set { if (OnPropertyChanging(__.Qty, value)) { _Qty = value; OnPropertyChanged(__.Qty); } } }

        private Double _NQty;
        /// <summary>件数</summary>
        [DisplayName("件数")]
        [Description("件数")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("NQty", "件数", "float")]
        public Double NQty { get { return _NQty; } set { if (OnPropertyChanging(__.NQty, value)) { _NQty = value; OnPropertyChanged(__.NQty); } } }

        private Double _Price;
        /// <summary>单价</summary>
        [DisplayName("单价")]
        [Description("单价")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Price", "单价", "float")]
        public Double Price { get { return _Price; } set { if (OnPropertyChanging(__.Price, value)) { _Price = value; OnPropertyChanged(__.Price); } } }

        private Double _Weight;
        /// <summary>重量</summary>
        [DisplayName("重量")]
        [Description("重量")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Weight", "重量", "float")]
        public Double Weight { get { return _Weight; } set { if (OnPropertyChanging(__.Weight, value)) { _Weight = value; OnPropertyChanged(__.Weight); } } }

        private Double _Amount;
        /// <summary>金额</summary>
        [DisplayName("金额")]
        [Description("金额")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Amount", "金额", "float")]
        public Double Amount { get { return _Amount; } set { if (OnPropertyChanging(__.Amount, value)) { _Amount = value; OnPropertyChanged(__.Amount); } } }

        private String _Summary;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Summary", "备注", "varchar(100)")]
        public String Summary { get { return _Summary; } set { if (OnPropertyChanging(__.Summary, value)) { _Summary = value; OnPropertyChanged(__.Summary); } } }
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
                    case __.Lsbh : return _Lsbh;
                    case __.EviNO : return _EviNO;
                    case __.InvID : return _InvID;
                    case __.Qty : return _Qty;
                    case __.NQty : return _NQty;
                    case __.Price : return _Price;
                    case __.Weight : return _Weight;
                    case __.Amount : return _Amount;
                    case __.Summary : return _Summary;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Lsbh : _Lsbh = value.ToInt(); break;
                    case __.EviNO : _EviNO = Convert.ToString(value); break;
                    case __.InvID : _InvID = Convert.ToString(value); break;
                    case __.Qty : _Qty = value.ToDouble(); break;
                    case __.NQty : _NQty = value.ToDouble(); break;
                    case __.Price : _Price = value.ToDouble(); break;
                    case __.Weight : _Weight = value.ToDouble(); break;
                    case __.Amount : _Amount = value.ToDouble(); break;
                    case __.Summary : _Summary = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得销售订单表体字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>销售订单表头流水编号</summary>
            public static readonly Field Lsbh = FindByName(__.Lsbh);

            /// <summary>销售订单号</summary>
            public static readonly Field EviNO = FindByName(__.EviNO);

            /// <summary>产品编号</summary>
            public static readonly Field InvID = FindByName(__.InvID);

            /// <summary>数量</summary>
            public static readonly Field Qty = FindByName(__.Qty);

            /// <summary>件数</summary>
            public static readonly Field NQty = FindByName(__.NQty);

            /// <summary>单价</summary>
            public static readonly Field Price = FindByName(__.Price);

            /// <summary>重量</summary>
            public static readonly Field Weight = FindByName(__.Weight);

            /// <summary>金额</summary>
            public static readonly Field Amount = FindByName(__.Amount);

            /// <summary>备注</summary>
            public static readonly Field Summary = FindByName(__.Summary);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得销售订单表体字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>销售订单表头流水编号</summary>
            public const String Lsbh = "Lsbh";

            /// <summary>销售订单号</summary>
            public const String EviNO = "EviNO";

            /// <summary>产品编号</summary>
            public const String InvID = "InvID";

            /// <summary>数量</summary>
            public const String Qty = "Qty";

            /// <summary>件数</summary>
            public const String NQty = "NQty";

            /// <summary>单价</summary>
            public const String Price = "Price";

            /// <summary>重量</summary>
            public const String Weight = "Weight";

            /// <summary>金额</summary>
            public const String Amount = "Amount";

            /// <summary>备注</summary>
            public const String Summary = "Summary";
        }
        #endregion
    }

    /// <summary>销售订单表体接口</summary>
    public partial interface IInv_Evi_Detail
    {
        #region 属性
        /// <summary>销售订单表头流水编号</summary>
        Int32 Lsbh { get; set; }

        /// <summary>销售订单号</summary>
        String EviNO { get; set; }

        /// <summary>产品编号</summary>
        String InvID { get; set; }

        /// <summary>数量</summary>
        Double Qty { get; set; }

        /// <summary>件数</summary>
        Double NQty { get; set; }

        /// <summary>单价</summary>
        Double Price { get; set; }

        /// <summary>重量</summary>
        Double Weight { get; set; }

        /// <summary>金额</summary>
        Double Amount { get; set; }

        /// <summary>备注</summary>
        String Summary { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}