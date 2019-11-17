﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Hhz.SysDF.SysModule
{
    /// <summary>行政区域</summary>
    [Serializable]
    [DataObject]
    [Description("行政区域")]
    [BindTable("Area_District_New", Description = "行政区域", ConnName = "hhzinfosys", DbType = DatabaseType.SqlServer)]
    public partial class AreaDistrictNew : IAreaDistrictNew
    {
        #region 属性
        private Int32 _ID;
        /// <summary>自动编号</summary>
        [DisplayName("自动编号")]
        [Description("自动编号")]
        [DataObjectField(true, true, false, 10)]
        [BindColumn("ID", "自动编号", "int")]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private String _Did;
        /// <summary>行政区域编号</summary>
        [DisplayName("行政区域编号")]
        [Description("行政区域编号")]
        [DataObjectField(false, false, true, 12)]
        [BindColumn("Did", "行政区域编号", "nchar(12)")]
        public virtual String Did
        {
            get { return _Did; }
            set { if (OnPropertyChanging(__.Did, value)) { _Did = value; OnPropertyChanged(__.Did); } }
        }

        private String _Dname;
        /// <summary>行政区域全称</summary>
        [DisplayName("行政区域全称")]
        [Description("行政区域全称")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Dname", "行政区域全称", "nvarchar(100)")]
        public virtual String Dname
        {
            get { return _Dname; }
            set { if (OnPropertyChanging(__.Dname, value)) { _Dname = value; OnPropertyChanged(__.Dname); } }
        }

        private String _PrevID;
        /// <summary>行政区域上级</summary>
        [DisplayName("行政区域上级")]
        [Description("行政区域上级")]
        [DataObjectField(false, false, true, 12)]
        [BindColumn("PrevID", "行政区域上级", "nchar(12)")]
        public virtual String PrevID
        {
            get { return _PrevID; }
            set { if (OnPropertyChanging(__.PrevID, value)) { _PrevID = value; OnPropertyChanged(__.PrevID); } }
        }

        private Int32 _Layer;
        /// <summary>行政区域层级</summary>
        [DisplayName("行政区域层级")]
        [Description("行政区域层级")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Layer", "行政区域层级", "int")]
        public virtual Int32 Layer
        {
            get { return _Layer; }
            set { if (OnPropertyChanging(__.Layer, value)) { _Layer = value; OnPropertyChanged(__.Layer); } }
        }

        private String _Pxno;
        /// <summary></summary>
        [DisplayName("Pxno")]
        [Description("")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("pxno", "", "nchar(10)")]
        public virtual String Pxno
        {
            get { return _Pxno; }
            set { if (OnPropertyChanging(__.Pxno, value)) { _Pxno = value; OnPropertyChanged(__.Pxno); } }
        }

        private String _Dname2;
        /// <summary>行政区域简称</summary>
        [DisplayName("行政区域简称")]
        [Description("行政区域简称")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Dname2", "行政区域简称", "nvarchar(100)")]
        public virtual String Dname2
        {
            get { return _Dname2; }
            set { if (OnPropertyChanging(__.Dname2, value)) { _Dname2 = value; OnPropertyChanged(__.Dname2); } }
        }

        private String _CreateUserID;
        /// <summary>创建用户</summary>
        [DisplayName("创建用户")]
        [Description("创建用户")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUserID", "创建用户", "varchar(50)")]
        public virtual String CreateUserID
        {
            get { return _CreateUserID; }
            set { if (OnPropertyChanging(__.CreateUserID, value)) { _CreateUserID = value; OnPropertyChanged(__.CreateUserID); } }
        }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "varchar(50)")]
        public virtual String CreateIP
        {
            get { return _CreateIP; }
            set { if (OnPropertyChanging(__.CreateIP, value)) { _CreateIP = value; OnPropertyChanged(__.CreateIP); } }
        }

        private String _UpdateUserID;
        /// <summary>更新用户</summary>
        [DisplayName("更新用户")]
        [Description("更新用户")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateUserID", "更新用户", "varchar(50)")]
        public virtual String UpdateUserID
        {
            get { return _UpdateUserID; }
            set { if (OnPropertyChanging(__.UpdateUserID, value)) { _UpdateUserID = value; OnPropertyChanged(__.UpdateUserID); } }
        }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "varchar(50)")]
        public virtual String UpdateIP
        {
            get { return _UpdateIP; }
            set { if (OnPropertyChanging(__.UpdateIP, value)) { _UpdateIP = value; OnPropertyChanged(__.UpdateIP); } }
        }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("UpdateTime", "更新时间", "datetime")]
        public virtual DateTime UpdateTime
        {
            get { return _UpdateTime; }
            set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } }
        }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("CreateTime", "创建时间", "datetime")]
        public virtual DateTime CreateTime
        {
            get { return _CreateTime; }
            set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } }
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
                    case __.Did : return _Did;
                    case __.Dname : return _Dname;
                    case __.PrevID : return _PrevID;
                    case __.Layer : return _Layer;
                    case __.Pxno : return _Pxno;
                    case __.Dname2 : return _Dname2;
                    case __.CreateUserID : return _CreateUserID;
                    case __.CreateIP : return _CreateIP;
                    case __.UpdateUserID : return _UpdateUserID;
                    case __.UpdateIP : return _UpdateIP;
                    case __.UpdateTime : return _UpdateTime;
                    case __.CreateTime : return _CreateTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Did : _Did = Convert.ToString(value); break;
                    case __.Dname : _Dname = Convert.ToString(value); break;
                    case __.PrevID : _PrevID = Convert.ToString(value); break;
                    case __.Layer : _Layer = Convert.ToInt32(value); break;
                    case __.Pxno : _Pxno = Convert.ToString(value); break;
                    case __.Dname2 : _Dname2 = Convert.ToString(value); break;
                    case __.CreateUserID : _CreateUserID = Convert.ToString(value); break;
                    case __.CreateIP : _CreateIP = Convert.ToString(value); break;
                    case __.UpdateUserID : _UpdateUserID = Convert.ToString(value); break;
                    case __.UpdateIP : _UpdateIP = Convert.ToString(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得行政区域字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary>自动编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary>行政区域编号</summary>
            public static readonly Field Did = FindByName(__.Did);

            ///<summary>行政区域全称</summary>
            public static readonly Field Dname = FindByName(__.Dname);

            ///<summary>行政区域上级</summary>
            public static readonly Field PrevID = FindByName(__.PrevID);

            ///<summary>行政区域层级</summary>
            public static readonly Field Layer = FindByName(__.Layer);

            ///<summary></summary>
            public static readonly Field Pxno = FindByName(__.Pxno);

            ///<summary>行政区域简称</summary>
            public static readonly Field Dname2 = FindByName(__.Dname2);

            ///<summary>创建用户</summary>
            public static readonly Field CreateUserID = FindByName(__.CreateUserID);

            ///<summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName(__.CreateIP);

            ///<summary>更新用户</summary>
            public static readonly Field UpdateUserID = FindByName(__.UpdateUserID);

            ///<summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName(__.UpdateIP);

            ///<summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            ///<summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得行政区域字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary>自动编号</summary>
            public const String ID = "ID";

            ///<summary>行政区域编号</summary>
            public const String Did = "Did";

            ///<summary>行政区域全称</summary>
            public const String Dname = "Dname";

            ///<summary>行政区域上级</summary>
            public const String PrevID = "PrevID";

            ///<summary>行政区域层级</summary>
            public const String Layer = "Layer";

            ///<summary></summary>
            public const String Pxno = "Pxno";

            ///<summary>行政区域简称</summary>
            public const String Dname2 = "Dname2";

            ///<summary>创建用户</summary>
            public const String CreateUserID = "CreateUserID";

            ///<summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            ///<summary>更新用户</summary>
            public const String UpdateUserID = "UpdateUserID";

            ///<summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";

            ///<summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            ///<summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

        }
        #endregion
    }

    /// <summary>行政区域接口</summary>
    public partial interface IAreaDistrictNew
    {
        #region 属性
        /// <summary>自动编号</summary>
        Int32 ID { get; set; }

        /// <summary>行政区域编号</summary>
        String Did { get; set; }

        /// <summary>行政区域全称</summary>
        String Dname { get; set; }

        /// <summary>行政区域上级</summary>
        String PrevID { get; set; }

        /// <summary>行政区域层级</summary>
        Int32 Layer { get; set; }

        /// <summary></summary>
        String Pxno { get; set; }

        /// <summary>行政区域简称</summary>
        String Dname2 { get; set; }

        /// <summary>创建用户</summary>
        String CreateUserID { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>更新用户</summary>
        String UpdateUserID { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}