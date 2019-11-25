using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Hhz.SysDF.SysModule
{
    /// <summary>部门档案</summary>
    [Serializable]
    [DataObject]
    [Description("部门档案")]
    [BindIndex("PK_Dept", true, "DeptID,ID")]
    [BindTable("Dept", Description = "部门档案", ConnName = "hhzinfosys", DbType = DatabaseType.SqlServer)]
    public partial class Dept : IDept
    {
        #region 属性
        private Int32 _id;
        /// <summary>No</summary>
        [DisplayName("No")]
        [Description("No")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("id", "No", "")]
        public Int32 id { get { return _id; } set { if (OnPropertyChanging(__.id, value)) { _id = value; OnPropertyChanged(__.id); } } }

        private String _DeptID;
        /// <summary>部门编号</summary>
        [DisplayName("部门编号")]
        [Description("部门编号")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("DeptID", "部门编号", "varchar(50)")]
        public String DeptID { get { return _DeptID; } set { if (OnPropertyChanging(__.DeptID, value)) { _DeptID = value; OnPropertyChanged(__.DeptID); } } }

        private String _DeptName;
        /// <summary>部门名称</summary>
        [DisplayName("部门名称")]
        [Description("部门名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DeptName", "部门名称", "varchar(50)")]
        public String DeptName { get { return _DeptName; } set { if (OnPropertyChanging(__.DeptName, value)) { _DeptName = value; OnPropertyChanged(__.DeptName); } } }

        private String _Depter;
        /// <summary>部门负责人</summary>
        [DisplayName("部门负责人")]
        [Description("部门负责人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Depter", "部门负责人", "varchar(50)")]
        public String Depter { get { return _Depter; } set { if (OnPropertyChanging(__.Depter, value)) { _Depter = value; OnPropertyChanged(__.Depter); } } }

        private String _PrevID;
        /// <summary>上级部门</summary>
        [DisplayName("上级部门")]
        [Description("上级部门")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PrevID", "上级部门", "varchar(50)")]
        public String PrevID { get { return _PrevID; } set { if (OnPropertyChanging(__.PrevID, value)) { _PrevID = value; OnPropertyChanged(__.PrevID); } } }

        private String _BZ;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("BZ", "备注", "varchar(50)")]
        public String BZ { get { return _BZ; } set { if (OnPropertyChanging(__.BZ, value)) { _BZ = value; OnPropertyChanged(__.BZ); } } }

        private String _CreateUserID;
        /// <summary>创建用户</summary>
        [DisplayName("创建用户")]
        [Description("创建用户")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUserID", "创建用户", "")]
        public String CreateUserID { get { return _CreateUserID; } set { if (OnPropertyChanging(__.CreateUserID, value)) { _CreateUserID = value; OnPropertyChanged(__.CreateUserID); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get { return _CreateIP; } set { if (OnPropertyChanging(__.CreateIP, value)) { _CreateIP = value; OnPropertyChanged(__.CreateIP); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get { return _CreateTime; } set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } } }

        private String _UpdateUserID;
        /// <summary>更新用户</summary>
        [DisplayName("更新用户")]
        [Description("更新用户")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateUserID", "更新用户", "")]
        public String UpdateUserID { get { return _UpdateUserID; } set { if (OnPropertyChanging(__.UpdateUserID, value)) { _UpdateUserID = value; OnPropertyChanged(__.UpdateUserID); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public String UpdateIP { get { return _UpdateIP; } set { if (OnPropertyChanging(__.UpdateIP, value)) { _UpdateIP = value; OnPropertyChanged(__.UpdateIP); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }
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
                    case __.id : return _id;
                    case __.DeptID : return _DeptID;
                    case __.DeptName : return _DeptName;
                    case __.Depter : return _Depter;
                    case __.PrevID : return _PrevID;
                    case __.BZ : return _BZ;
                    case __.CreateUserID : return _CreateUserID;
                    case __.CreateIP : return _CreateIP;
                    case __.CreateTime : return _CreateTime;
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
                    case __.id : _id = value.ToInt(); break;
                    case __.DeptID : _DeptID = Convert.ToString(value); break;
                    case __.DeptName : _DeptName = Convert.ToString(value); break;
                    case __.Depter : _Depter = Convert.ToString(value); break;
                    case __.PrevID : _PrevID = Convert.ToString(value); break;
                    case __.BZ : _BZ = Convert.ToString(value); break;
                    case __.CreateUserID : _CreateUserID = Convert.ToString(value); break;
                    case __.CreateIP : _CreateIP = Convert.ToString(value); break;
                    case __.CreateTime : _CreateTime = value.ToDateTime(); break;
                    case __.UpdateUserID : _UpdateUserID = Convert.ToString(value); break;
                    case __.UpdateIP : _UpdateIP = Convert.ToString(value); break;
                    case __.UpdateTime : _UpdateTime = value.ToDateTime(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得部门档案字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>No</summary>
            public static readonly Field id = FindByName(__.id);

            /// <summary>部门编号</summary>
            public static readonly Field DeptID = FindByName(__.DeptID);

            /// <summary>部门名称</summary>
            public static readonly Field DeptName = FindByName(__.DeptName);

            /// <summary>部门负责人</summary>
            public static readonly Field Depter = FindByName(__.Depter);

            /// <summary>上级部门</summary>
            public static readonly Field PrevID = FindByName(__.PrevID);

            /// <summary>备注</summary>
            public static readonly Field BZ = FindByName(__.BZ);

            /// <summary>创建用户</summary>
            public static readonly Field CreateUserID = FindByName(__.CreateUserID);

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName(__.CreateIP);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>更新用户</summary>
            public static readonly Field UpdateUserID = FindByName(__.UpdateUserID);

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName(__.UpdateIP);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得部门档案字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>No</summary>
            public const String id = "id";

            /// <summary>部门编号</summary>
            public const String DeptID = "DeptID";

            /// <summary>部门名称</summary>
            public const String DeptName = "DeptName";

            /// <summary>部门负责人</summary>
            public const String Depter = "Depter";

            /// <summary>上级部门</summary>
            public const String PrevID = "PrevID";

            /// <summary>备注</summary>
            public const String BZ = "BZ";

            /// <summary>创建用户</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>更新用户</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";
        }
        #endregion
    }

    /// <summary>部门档案接口</summary>
    public partial interface IDept
    {
        #region 属性
        /// <summary>No</summary>
        Int32 id { get; set; }

        /// <summary>部门编号</summary>
        String DeptID { get; set; }

        /// <summary>部门名称</summary>
        String DeptName { get; set; }

        /// <summary>部门负责人</summary>
        String Depter { get; set; }

        /// <summary>上级部门</summary>
        String PrevID { get; set; }

        /// <summary>备注</summary>
        String BZ { get; set; }

        /// <summary>创建用户</summary>
        String CreateUserID { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>更新用户</summary>
        String UpdateUserID { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}