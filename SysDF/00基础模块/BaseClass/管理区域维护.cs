﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Hhz.SysDF.SysModule
{
    /// <summary>AreaNew</summary>
    /// <remarks></remarks>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_Area_New", true, "AreaID")]
    [BindTable("Area_New", Description = "", ConnName = "hhzinfosys", DbType = DatabaseType.SqlServer)]
    public partial class AreaNew : IAreaNew
    {
        #region 属性
        private Int32 _ID;
        /// <summary></summary>
        [DisplayName("ID")]
        [Description("")]
        [DataObjectField(false, true, false, 10)]
        [BindColumn("ID", "", "int")]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private String _AreaID;
        /// <summary></summary>
        [DisplayName("AreaID")]
        [Description("")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("AreaID", "", "varchar(50)")]
        public virtual String AreaID
        {
            get { return _AreaID; }
            set { if (OnPropertyChanging(__.AreaID, value)) { _AreaID = value; OnPropertyChanged(__.AreaID); } }
        }

        private String _AreaName;
        /// <summary></summary>
        [DisplayName("AreaName")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("AreaName", "", "varchar(50)")]
        public virtual String AreaName
        {
            get { return _AreaName; }
            set { if (OnPropertyChanging(__.AreaName, value)) { _AreaName = value; OnPropertyChanged(__.AreaName); } }
        }

        private String _PrevID;
        /// <summary></summary>
        [DisplayName("PrevID")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PrevID", "", "varchar(50)")]
        public virtual String PrevID
        {
            get { return _PrevID; }
            set { if (OnPropertyChanging(__.PrevID, value)) { _PrevID = value; OnPropertyChanged(__.PrevID); } }
        }

        private String _CreateUserID;
        /// <summary></summary>
        [DisplayName("CreateUserID")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUserID", "", "varchar(50)")]
        public virtual String CreateUserID
        {
            get { return _CreateUserID; }
            set { if (OnPropertyChanging(__.CreateUserID, value)) { _CreateUserID = value; OnPropertyChanged(__.CreateUserID); } }
        }

        private DateTime _CreateTime;
        /// <summary></summary>
        [DisplayName("CreateTime")]
        [Description("")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("CreateTime", "", "datetime")]
        public virtual DateTime CreateTime
        {
            get { return _CreateTime; }
            set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } }
        }

        private String _CreateIP;
        /// <summary></summary>
        [DisplayName("CreateIP")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "", "varchar(50)")]
        public virtual String CreateIP
        {
            get { return _CreateIP; }
            set { if (OnPropertyChanging(__.CreateIP, value)) { _CreateIP = value; OnPropertyChanged(__.CreateIP); } }
        }

        private String _UpdateUserID;
        /// <summary></summary>
        [DisplayName("UpdateUserID")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateUserID", "", "varchar(50)")]
        public virtual String UpdateUserID
        {
            get { return _UpdateUserID; }
            set { if (OnPropertyChanging(__.UpdateUserID, value)) { _UpdateUserID = value; OnPropertyChanged(__.UpdateUserID); } }
        }

        private String _UpdateIP;
        /// <summary></summary>
        [DisplayName("UpdateIP")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "", "varchar(50)")]
        public virtual String UpdateIP
        {
            get { return _UpdateIP; }
            set { if (OnPropertyChanging(__.UpdateIP, value)) { _UpdateIP = value; OnPropertyChanged(__.UpdateIP); } }
        }

        private DateTime _UpdateTime;
        /// <summary></summary>
        [DisplayName("UpdateTime")]
        [Description("")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("UpdateTime", "", "datetime")]
        public virtual DateTime UpdateTime
        {
            get { return _UpdateTime; }
            set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } }
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
                    case __.AreaID : return _AreaID;
                    case __.AreaName : return _AreaName;
                    case __.PrevID : return _PrevID;
                    case __.CreateUserID : return _CreateUserID;
                    case __.CreateTime : return _CreateTime;
                    case __.CreateIP : return _CreateIP;
                    case __.UpdateUserID : return _UpdateUserID;
                    case __.UpdateIP : return _UpdateIP;
                    case __.UpdateTime : return _UpdateTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.AreaID : _AreaID = Convert.ToString(value); break;
                    case __.AreaName : _AreaName = Convert.ToString(value); break;
                    case __.PrevID : _PrevID = Convert.ToString(value); break;
                    case __.CreateUserID : _CreateUserID = Convert.ToString(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.CreateIP : _CreateIP = Convert.ToString(value); break;
                    case __.UpdateUserID : _UpdateUserID = Convert.ToString(value); break;
                    case __.UpdateIP : _UpdateIP = Convert.ToString(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得AreaNew字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary></summary>
            public static readonly Field AreaID = FindByName(__.AreaID);

            ///<summary></summary>
            public static readonly Field AreaName = FindByName(__.AreaName);

            ///<summary></summary>
            public static readonly Field PrevID = FindByName(__.PrevID);

            ///<summary></summary>
            public static readonly Field CreateUserID = FindByName(__.CreateUserID);

            ///<summary></summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            ///<summary></summary>
            public static readonly Field CreateIP = FindByName(__.CreateIP);

            ///<summary></summary>
            public static readonly Field UpdateUserID = FindByName(__.UpdateUserID);

            ///<summary></summary>
            public static readonly Field UpdateIP = FindByName(__.UpdateIP);

            ///<summary></summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得AreaNew字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String ID = "ID";

            ///<summary></summary>
            public const String AreaID = "AreaID";

            ///<summary></summary>
            public const String AreaName = "AreaName";

            ///<summary></summary>
            public const String PrevID = "PrevID";

            ///<summary></summary>
            public const String CreateUserID = "CreateUserID";

            ///<summary></summary>
            public const String CreateTime = "CreateTime";

            ///<summary></summary>
            public const String CreateIP = "CreateIP";

            ///<summary></summary>
            public const String UpdateUserID = "UpdateUserID";

            ///<summary></summary>
            public const String UpdateIP = "UpdateIP";

            ///<summary></summary>
            public const String UpdateTime = "UpdateTime";

        }
        #endregion
    }

    /// <summary>AreaNew接口</summary>
    /// <remarks></remarks>
    public partial interface IAreaNew
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        String AreaID { get; set; }

        /// <summary></summary>
        String AreaName { get; set; }

        /// <summary></summary>
        String PrevID { get; set; }

        /// <summary></summary>
        String CreateUserID { get; set; }

        /// <summary></summary>
        DateTime CreateTime { get; set; }

        /// <summary></summary>
        String CreateIP { get; set; }

        /// <summary></summary>
        String UpdateUserID { get; set; }

        /// <summary></summary>
        String UpdateIP { get; set; }

        /// <summary></summary>
        DateTime UpdateTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}