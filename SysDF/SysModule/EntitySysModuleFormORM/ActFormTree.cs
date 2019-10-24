﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Hhz.SysDF.SysModule
{
    /// <summary>ActFormTree</summary>
    /// <remarks></remarks>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindTable("ActFormTree", Description = "", ConnName = "hhzinfosys", DbType = DatabaseType.SqlServer)]
    public partial class ActFormTree : IActFormTree
    {
        #region 属性
        private Int32 _ID;
        /// <summary></summary>
        [DisplayName("ID")]
        [Description("菜单ID")]
        [DataObjectField(true, true, false, 10)]
        [BindColumn("ID", "", "int")]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private String _FormID;
        /// <summary></summary>
        [DisplayName("FormID")]
        [Description("菜单名称")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("FormID", "", "varchar(50)")]
        public virtual String FormID
        {
            get { return _FormID; }
            set { if (OnPropertyChanging(__.FormID, value)) { _FormID = value; OnPropertyChanged(__.FormID); } }
        }

        private String _FormName;
        /// <summary></summary>
        [DisplayName("FormName")]
        [Description("菜单别名")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("FormName", "", "varchar(50)")]
        public virtual String FormName
        {
            get { return _FormName; }
            set { if (OnPropertyChanging(__.FormName, value)) { _FormName = value; OnPropertyChanged(__.FormName); } }
        }

        private String _Sumarry;
        /// <summary></summary>
        [DisplayName("Sumarry")]
        [Description("菜单说明")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Sumarry", "", "varchar(100)")]
        public virtual String Sumarry
        {
            get { return _Sumarry; }
            set { if (OnPropertyChanging(__.Sumarry, value)) { _Sumarry = value; OnPropertyChanged(__.Sumarry); } }
        }

        private String _FormType;
        /// <summary></summary>
        [DisplayName("FormType")]
        [Description("菜单上级名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("FormType", "", "varchar(50)")]
        public virtual String FormType
        {
            get { return _FormType; }
            set { if (OnPropertyChanging(__.FormType, value)) { _FormType = value; OnPropertyChanged(__.FormType); } }
        }

        private Int32 _parenID;
        /// <summary></summary>
        [DisplayName("parenID")]
        [Description("菜单上级ID")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("parenID", "", "int")]
        public virtual Int32 parenID
        {
            get { return _parenID; }
            set { if (OnPropertyChanging(__.parenID, value)) { _parenID = value; OnPropertyChanged(__.parenID); } }
        }

        private String _Pxnum;
        /// <summary></summary>
        [DisplayName("Pxnum")]
        [Description("菜单排序编号")]
        [DataObjectField(false, false, true, 5)]
        [BindColumn("pxnum", "", "char(5)")]
        public virtual String Pxnum
        {
            get { return _Pxnum; }
            set { if (OnPropertyChanging(__.Pxnum, value)) { _Pxnum = value; OnPropertyChanged(__.Pxnum); } }
        }

        private String _UrlModle;
        /// <summary></summary>
        [DisplayName("UrlModle")]
        [Description("菜单类名")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("UrlModle", "", "nvarchar(500)")]
        public virtual String UrlModle
        {
            get { return _UrlModle; }
            set { if (OnPropertyChanging(__.UrlModle, value)) { _UrlModle = value; OnPropertyChanged(__.UrlModle); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.FormID : return _FormID;
                    case __.FormName : return _FormName;
                    case __.Sumarry : return _Sumarry;
                    case __.FormType : return _FormType;
                    case __.parenID : return _parenID;
                    case __.Pxnum : return _Pxnum;
                    case __.UrlModle : return _UrlModle;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.FormID : _FormID = Convert.ToString(value); break;
                    case __.FormName : _FormName = Convert.ToString(value); break;
                    case __.Sumarry : _Sumarry = Convert.ToString(value); break;
                    case __.FormType : _FormType = Convert.ToString(value); break;
                    case __.parenID : _parenID = Convert.ToInt32(value); break;
                    case __.Pxnum : _Pxnum = Convert.ToString(value); break;
                    case __.UrlModle : _UrlModle = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ActFormTree字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary></summary>
            public static readonly Field FormID = FindByName(__.FormID);

            ///<summary></summary>
            public static readonly Field FormName = FindByName(__.FormName);

            ///<summary></summary>
            public static readonly Field Sumarry = FindByName(__.Sumarry);

            ///<summary></summary>
            public static readonly Field FormType = FindByName(__.FormType);

            ///<summary></summary>
            public static readonly Field parenID = FindByName(__.parenID);

            ///<summary></summary>
            public static readonly Field Pxnum = FindByName(__.Pxnum);

            ///<summary></summary>
            public static readonly Field UrlModle = FindByName(__.UrlModle);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ActFormTree字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String ID = "ID";

            ///<summary></summary>
            public const String FormID = "FormID";

            ///<summary></summary>
            public const String FormName = "FormName";

            ///<summary></summary>
            public const String Sumarry = "Sumarry";

            ///<summary></summary>
            public const String FormType = "FormType";

            ///<summary></summary>
            public const String parenID = "parenID";

            ///<summary></summary>
            public const String Pxnum = "Pxnum";

            ///<summary></summary>
            public const String UrlModle = "UrlModle";

        }
        #endregion
    }

    /// <summary>ActFormTree接口</summary>
    /// <remarks></remarks>
    public partial interface IActFormTree
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        String FormID { get; set; }

        /// <summary></summary>
        String FormName { get; set; }

        /// <summary></summary>
        String Sumarry { get; set; }

        /// <summary></summary>
        String FormType { get; set; }

        /// <summary></summary>
        Int32 parenID { get; set; }

        /// <summary></summary>
        String Pxnum { get; set; }

        /// <summary></summary>
        String UrlModle { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}