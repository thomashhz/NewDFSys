using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Hhz.SysDF.SysModule
{
    /// <summary>人员档案</summary>
    [Serializable]
    [DataObject]
    [Description("人员档案")]
    [BindIndex("PK_Person", true, "Pname,ID")]
    [BindTable("Person", Description = "人员档案", ConnName = "hhzinfosys", DbType = DatabaseType.SqlServer)]
    public partial class Person : IPerson
    {
        #region 属性
        private Int32 _ID;
        /// <summary></summary>
        [DisplayName("ID")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "", "")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Pname;
        /// <summary>人员姓名</summary>
        [DisplayName("人员姓名")]
        [Description("人员姓名")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("Pname", "人员姓名", "varchar(50)")]
        public String Pname { get { return _Pname; } set { if (OnPropertyChanging(__.Pname, value)) { _Pname = value; OnPropertyChanged(__.Pname); } } }

        private String _Sex;
        /// <summary>人员性别</summary>
        [DisplayName("人员性别")]
        [Description("人员性别")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Sex", "人员性别", "char(10)")]
        public String Sex { get { return _Sex; } set { if (OnPropertyChanging(__.Sex, value)) { _Sex = value; OnPropertyChanged(__.Sex); } } }

        private String _Job;
        /// <summary>岗位名称</summary>
        [DisplayName("岗位名称")]
        [Description("岗位名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Job", "岗位名称", "varchar(50)")]
        public String Job { get { return _Job; } set { if (OnPropertyChanging(__.Job, value)) { _Job = value; OnPropertyChanged(__.Job); } } }

        private String _Paper;
        /// <summary>证件类型</summary>
        [DisplayName("证件类型")]
        [Description("证件类型")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Paper", "证件类型", "varchar(50)")]
        public String Paper { get { return _Paper; } set { if (OnPropertyChanging(__.Paper, value)) { _Paper = value; OnPropertyChanged(__.Paper); } } }

        private String _PaperNum;
        /// <summary>证件号码</summary>
        [DisplayName("证件号码")]
        [Description("证件号码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PaperNum", "证件号码", "varchar(50)")]
        public String PaperNum { get { return _PaperNum; } set { if (OnPropertyChanging(__.PaperNum, value)) { _PaperNum = value; OnPropertyChanged(__.PaperNum); } } }

        private DateTime _InDate;
        /// <summary>入职时间</summary>
        [DisplayName("入职时间")]
        [Description("入职时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("InDate", "入职时间", "")]
        public DateTime InDate { get { return _InDate; } set { if (OnPropertyChanging(__.InDate, value)) { _InDate = value; OnPropertyChanged(__.InDate); } } }

        private DateTime _OutDate;
        /// <summary>离职时间</summary>
        [DisplayName("离职时间")]
        [Description("离职时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("OutDate", "离职时间", "")]
        public DateTime OutDate { get { return _OutDate; } set { if (OnPropertyChanging(__.OutDate, value)) { _OutDate = value; OnPropertyChanged(__.OutDate); } } }

        private String _AreaID;
        /// <summary>管理区域</summary>
        [DisplayName("管理区域")]
        [Description("管理区域")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("AreaID", "管理区域", "varchar(50)")]
        public String AreaID { get { return _AreaID; } set { if (OnPropertyChanging(__.AreaID, value)) { _AreaID = value; OnPropertyChanged(__.AreaID); } } }

        private String _Status;
        /// <summary>在职1离职0</summary>
        [DisplayName("在职1离职0")]
        [Description("在职1离职0")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Status", "在职1离职0", "char(10)")]
        public String Status { get { return _Status; } set { if (OnPropertyChanging(__.Status, value)) { _Status = value; OnPropertyChanged(__.Status); } } }

        private String _DeptID;
        /// <summary>部门ID</summary>
        [DisplayName("部门ID")]
        [Description("部门ID")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("DeptID", "部门ID", "char(10)")]
        public String DeptID { get { return _DeptID; } set { if (OnPropertyChanging(__.DeptID, value)) { _DeptID = value; OnPropertyChanged(__.DeptID); } } }

        private DateTime _Qsrq;
        /// <summary>起算日期</summary>
        [DisplayName("起算日期")]
        [Description("起算日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Qsrq", "起算日期", "smalldatetime")]
        public DateTime Qsrq { get { return _Qsrq; } set { if (OnPropertyChanging(__.Qsrq, value)) { _Qsrq = value; OnPropertyChanged(__.Qsrq); } } }

        private Int32 _Zzjs;
        /// <summary>开发客户增长基数</summary>
        [DisplayName("开发客户增长基数")]
        [Description("开发客户增长基数")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Zzjs", "开发客户增长基数", "")]
        public Int32 Zzjs { get { return _Zzjs; } set { if (OnPropertyChanging(__.Zzjs, value)) { _Zzjs = value; OnPropertyChanged(__.Zzjs); } } }

        private Decimal _Zzbl;
        /// <summary>优质客户增长比例</summary>
        [DisplayName("优质客户增长比例")]
        [Description("优质客户增长比例")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Zzbl", "优质客户增长比例", "decimal(18, 2)")]
        public Decimal Zzbl { get { return _Zzbl; } set { if (OnPropertyChanging(__.Zzbl, value)) { _Zzbl = value; OnPropertyChanged(__.Zzbl); } } }

        private Decimal _Psbz;
        /// <summary>配送件数标准</summary>
        [DisplayName("配送件数标准")]
        [Description("配送件数标准")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Psbz", "配送件数标准", "decimal(18, 2)")]
        public Decimal Psbz { get { return _Psbz; } set { if (OnPropertyChanging(__.Psbz, value)) { _Psbz = value; OnPropertyChanged(__.Psbz); } } }

        private Decimal _Psdzbz;
        /// <summary>配送单数标准</summary>
        [DisplayName("配送单数标准")]
        [Description("配送单数标准")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Psdzbz", "配送单数标准", "decimal(18, 2)")]
        public Decimal Psdzbz { get { return _Psdzbz; } set { if (OnPropertyChanging(__.Psdzbz, value)) { _Psdzbz = value; OnPropertyChanged(__.Psdzbz); } } }

        private String _Zwpdbh;
        /// <summary>评定编号</summary>
        [DisplayName("评定编号")]
        [Description("评定编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Zwpdbh", "评定编号", "varchar(10)")]
        public String Zwpdbh { get { return _Zwpdbh; } set { if (OnPropertyChanging(__.Zwpdbh, value)) { _Zwpdbh = value; OnPropertyChanged(__.Zwpdbh); } } }

        private String _Zwpdmc;
        /// <summary>评定名称</summary>
        [DisplayName("评定名称")]
        [Description("评定名称")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Zwpdmc", "评定名称", "varchar(20)")]
        public String Zwpdmc { get { return _Zwpdmc; } set { if (OnPropertyChanging(__.Zwpdmc, value)) { _Zwpdmc = value; OnPropertyChanged(__.Zwpdmc); } } }

        private String _Pdpxbh;
        /// <summary>评定排序号</summary>
        [DisplayName("评定排序号")]
        [Description("评定排序号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Pdpxbh", "评定排序号", "")]
        public String Pdpxbh { get { return _Pdpxbh; } set { if (OnPropertyChanging(__.Pdpxbh, value)) { _Pdpxbh = value; OnPropertyChanged(__.Pdpxbh); } } }

        private String _Driverfz;
        /// <summary>司机分组</summary>
        [DisplayName("司机分组")]
        [Description("司机分组")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Driverfz", "司机分组", "")]
        public String Driverfz { get { return _Driverfz; } set { if (OnPropertyChanging(__.Driverfz, value)) { _Driverfz = value; OnPropertyChanged(__.Driverfz); } } }

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
                    case __.ID : return _ID;
                    case __.Pname : return _Pname;
                    case __.Sex : return _Sex;
                    case __.Job : return _Job;
                    case __.Paper : return _Paper;
                    case __.PaperNum : return _PaperNum;
                    case __.InDate : return _InDate;
                    case __.OutDate : return _OutDate;
                    case __.AreaID : return _AreaID;
                    case __.Status : return _Status;
                    case __.DeptID : return _DeptID;
                    case __.Qsrq : return _Qsrq;
                    case __.Zzjs : return _Zzjs;
                    case __.Zzbl : return _Zzbl;
                    case __.Psbz : return _Psbz;
                    case __.Psdzbz : return _Psdzbz;
                    case __.Zwpdbh : return _Zwpdbh;
                    case __.Zwpdmc : return _Zwpdmc;
                    case __.Pdpxbh : return _Pdpxbh;
                    case __.Driverfz : return _Driverfz;
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
                    case __.ID : _ID = value.ToInt(); break;
                    case __.Pname : _Pname = Convert.ToString(value); break;
                    case __.Sex : _Sex = Convert.ToString(value); break;
                    case __.Job : _Job = Convert.ToString(value); break;
                    case __.Paper : _Paper = Convert.ToString(value); break;
                    case __.PaperNum : _PaperNum = Convert.ToString(value); break;
                    case __.InDate : _InDate = value.ToDateTime(); break;
                    case __.OutDate : _OutDate = value.ToDateTime(); break;
                    case __.AreaID : _AreaID = Convert.ToString(value); break;
                    case __.Status : _Status = Convert.ToString(value); break;
                    case __.DeptID : _DeptID = Convert.ToString(value); break;
                    case __.Qsrq : _Qsrq = value.ToDateTime(); break;
                    case __.Zzjs : _Zzjs = value.ToInt(); break;
                    case __.Zzbl : _Zzbl = Convert.ToDecimal(value); break;
                    case __.Psbz : _Psbz = Convert.ToDecimal(value); break;
                    case __.Psdzbz : _Psdzbz = Convert.ToDecimal(value); break;
                    case __.Zwpdbh : _Zwpdbh = Convert.ToString(value); break;
                    case __.Zwpdmc : _Zwpdmc = Convert.ToString(value); break;
                    case __.Pdpxbh : _Pdpxbh = Convert.ToString(value); break;
                    case __.Driverfz : _Driverfz = Convert.ToString(value); break;
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
        /// <summary>取得人员档案字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>人员姓名</summary>
            public static readonly Field Pname = FindByName(__.Pname);

            /// <summary>人员性别</summary>
            public static readonly Field Sex = FindByName(__.Sex);

            /// <summary>岗位名称</summary>
            public static readonly Field Job = FindByName(__.Job);

            /// <summary>证件类型</summary>
            public static readonly Field Paper = FindByName(__.Paper);

            /// <summary>证件号码</summary>
            public static readonly Field PaperNum = FindByName(__.PaperNum);

            /// <summary>入职时间</summary>
            public static readonly Field InDate = FindByName(__.InDate);

            /// <summary>离职时间</summary>
            public static readonly Field OutDate = FindByName(__.OutDate);

            /// <summary>管理区域</summary>
            public static readonly Field AreaID = FindByName(__.AreaID);

            /// <summary>在职1离职0</summary>
            public static readonly Field Status = FindByName(__.Status);

            /// <summary>部门ID</summary>
            public static readonly Field DeptID = FindByName(__.DeptID);

            /// <summary>起算日期</summary>
            public static readonly Field Qsrq = FindByName(__.Qsrq);

            /// <summary>开发客户增长基数</summary>
            public static readonly Field Zzjs = FindByName(__.Zzjs);

            /// <summary>优质客户增长比例</summary>
            public static readonly Field Zzbl = FindByName(__.Zzbl);

            /// <summary>配送件数标准</summary>
            public static readonly Field Psbz = FindByName(__.Psbz);

            /// <summary>配送单数标准</summary>
            public static readonly Field Psdzbz = FindByName(__.Psdzbz);

            /// <summary>评定编号</summary>
            public static readonly Field Zwpdbh = FindByName(__.Zwpdbh);

            /// <summary>评定名称</summary>
            public static readonly Field Zwpdmc = FindByName(__.Zwpdmc);

            /// <summary>评定排序号</summary>
            public static readonly Field Pdpxbh = FindByName(__.Pdpxbh);

            /// <summary>司机分组</summary>
            public static readonly Field Driverfz = FindByName(__.Driverfz);

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

        /// <summary>取得人员档案字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String ID = "ID";

            /// <summary>人员姓名</summary>
            public const String Pname = "Pname";

            /// <summary>人员性别</summary>
            public const String Sex = "Sex";

            /// <summary>岗位名称</summary>
            public const String Job = "Job";

            /// <summary>证件类型</summary>
            public const String Paper = "Paper";

            /// <summary>证件号码</summary>
            public const String PaperNum = "PaperNum";

            /// <summary>入职时间</summary>
            public const String InDate = "InDate";

            /// <summary>离职时间</summary>
            public const String OutDate = "OutDate";

            /// <summary>管理区域</summary>
            public const String AreaID = "AreaID";

            /// <summary>在职1离职0</summary>
            public const String Status = "Status";

            /// <summary>部门ID</summary>
            public const String DeptID = "DeptID";

            /// <summary>起算日期</summary>
            public const String Qsrq = "Qsrq";

            /// <summary>开发客户增长基数</summary>
            public const String Zzjs = "Zzjs";

            /// <summary>优质客户增长比例</summary>
            public const String Zzbl = "Zzbl";

            /// <summary>配送件数标准</summary>
            public const String Psbz = "Psbz";

            /// <summary>配送单数标准</summary>
            public const String Psdzbz = "Psdzbz";

            /// <summary>评定编号</summary>
            public const String Zwpdbh = "Zwpdbh";

            /// <summary>评定名称</summary>
            public const String Zwpdmc = "Zwpdmc";

            /// <summary>评定排序号</summary>
            public const String Pdpxbh = "Pdpxbh";

            /// <summary>司机分组</summary>
            public const String Driverfz = "Driverfz";

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

    /// <summary>人员档案接口</summary>
    public partial interface IPerson
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary>人员姓名</summary>
        String Pname { get; set; }

        /// <summary>人员性别</summary>
        String Sex { get; set; }

        /// <summary>岗位名称</summary>
        String Job { get; set; }

        /// <summary>证件类型</summary>
        String Paper { get; set; }

        /// <summary>证件号码</summary>
        String PaperNum { get; set; }

        /// <summary>入职时间</summary>
        DateTime InDate { get; set; }

        /// <summary>离职时间</summary>
        DateTime OutDate { get; set; }

        /// <summary>管理区域</summary>
        String AreaID { get; set; }

        /// <summary>在职1离职0</summary>
        String Status { get; set; }

        /// <summary>部门ID</summary>
        String DeptID { get; set; }

        /// <summary>起算日期</summary>
        DateTime Qsrq { get; set; }

        /// <summary>开发客户增长基数</summary>
        Int32 Zzjs { get; set; }

        /// <summary>优质客户增长比例</summary>
        Decimal Zzbl { get; set; }

        /// <summary>配送件数标准</summary>
        Decimal Psbz { get; set; }

        /// <summary>配送单数标准</summary>
        Decimal Psdzbz { get; set; }

        /// <summary>评定编号</summary>
        String Zwpdbh { get; set; }

        /// <summary>评定名称</summary>
        String Zwpdmc { get; set; }

        /// <summary>评定排序号</summary>
        String Pdpxbh { get; set; }

        /// <summary>司机分组</summary>
        String Driverfz { get; set; }

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