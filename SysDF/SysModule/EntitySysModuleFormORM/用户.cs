using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Hhz.SysDF.SysModule
{
    /// <summary>用户</summary>
    [Serializable]
    [DataObject]
    [Description("用户")]
    [BindIndex("IU_ActUser_UserName", true, "UserName")]
    [BindTable("ActUser", Description = "用户", ConnName = "hhzinfosys", DbType = DatabaseType.SqlServer)]
    public partial class ActUser : IActUser
    {
        #region 属性
        private Int32 _id;
        /// <summary></summary>
        [DisplayName("id")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("id", "", "")]
        public Int32 id { get { return _id; } set { if (OnPropertyChanging(__.id, value)) { _id = value; OnPropertyChanged(__.id); } } }

        private String _UserID;
        /// <summary>登录用户名编号</summary>
        [DisplayName("登录用户名编号")]
        [Description("登录用户名编号")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("UserID", "登录用户名编号", "")]
        public String UserID { get { return _UserID; } set { if (OnPropertyChanging(__.UserID, value)) { _UserID = value; OnPropertyChanged(__.UserID); } } }

        private String _UserName;
        /// <summary>名称。登录用户名</summary>
        [DisplayName("名称")]
        [Description("名称。登录用户名")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("UserName", "名称。登录用户名", "")]
        public String UserName { get { return _UserName; } set { if (OnPropertyChanging(__.UserName, value)) { _UserName = value; OnPropertyChanged(__.UserName); } } }

        private String _Detp;
        /// <summary>部门</summary>
        [DisplayName("部门")]
        [Description("部门")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Detp", "部门", "")]
        public String Detp { get { return _Detp; } set { if (OnPropertyChanging(__.Detp, value)) { _Detp = value; OnPropertyChanged(__.Detp); } } }

        private String _Summary;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Summary", "备注", "")]
        public String Summary { get { return _Summary; } set { if (OnPropertyChanging(__.Summary, value)) { _Summary = value; OnPropertyChanged(__.Summary); } } }

        private Boolean _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("State", "状态", "")]
        public Boolean State { get { return _State; } set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } } }

        private String _Email;
        /// <summary>邮件</summary>
        [DisplayName("邮件")]
        [Description("邮件")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Email", "邮件", "")]
        public String Email { get { return _Email; } set { if (OnPropertyChanging(__.Email, value)) { _Email = value; OnPropertyChanged(__.Email); } } }

        private String _Tel;
        /// <summary>电话</summary>
        [DisplayName("电话")]
        [Description("电话")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Tel", "电话", "")]
        public String Tel { get { return _Tel; } set { if (OnPropertyChanging(__.Tel, value)) { _Tel = value; OnPropertyChanged(__.Tel); } } }

        private String _Pwd;
        /// <summary>密码</summary>
        [DisplayName("密码")]
        [Description("密码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Pwd", "密码", "")]
        public String Pwd { get { return _Pwd; } set { if (OnPropertyChanging(__.Pwd, value)) { _Pwd = value; OnPropertyChanged(__.Pwd); } } }

        private Boolean _Detped;
        /// <summary>部门控制</summary>
        [DisplayName("部门控制")]
        [Description("部门控制")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Detped", "部门控制", "")]
        public Boolean Detped { get { return _Detped; } set { if (OnPropertyChanging(__.Detped, value)) { _Detped = value; OnPropertyChanged(__.Detped); } } }

        private Int32 _isStop;
        /// <summary>停用</summary>
        [DisplayName("停用")]
        [Description("停用")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("isStop", "停用", "")]
        public Int32 isStop { get { return _isStop; } set { if (OnPropertyChanging(__.isStop, value)) { _isStop = value; OnPropertyChanged(__.isStop); } } }
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
                    case __.UserID : return _UserID;
                    case __.UserName : return _UserName;
                    case __.Detp : return _Detp;
                    case __.Summary : return _Summary;
                    case __.State : return _State;
                    case __.Email : return _Email;
                    case __.Tel : return _Tel;
                    case __.Pwd : return _Pwd;
                    case __.Detped : return _Detped;
                    case __.isStop : return _isStop;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.id : _id = value.ToInt(); break;
                    case __.UserID : _UserID = Convert.ToString(value); break;
                    case __.UserName : _UserName = Convert.ToString(value); break;
                    case __.Detp : _Detp = Convert.ToString(value); break;
                    case __.Summary : _Summary = Convert.ToString(value); break;
                    case __.State : _State = value.ToBoolean(); break;
                    case __.Email : _Email = Convert.ToString(value); break;
                    case __.Tel : _Tel = Convert.ToString(value); break;
                    case __.Pwd : _Pwd = Convert.ToString(value); break;
                    case __.Detped : _Detped = value.ToBoolean(); break;
                    case __.isStop : _isStop = value.ToInt(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得用户字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field id = FindByName(__.id);

            /// <summary>登录用户名编号</summary>
            public static readonly Field UserID = FindByName(__.UserID);

            /// <summary>名称。登录用户名</summary>
            public static readonly Field UserName = FindByName(__.UserName);

            /// <summary>部门</summary>
            public static readonly Field Detp = FindByName(__.Detp);

            /// <summary>备注</summary>
            public static readonly Field Summary = FindByName(__.Summary);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>邮件</summary>
            public static readonly Field Email = FindByName(__.Email);

            /// <summary>电话</summary>
            public static readonly Field Tel = FindByName(__.Tel);

            /// <summary>密码</summary>
            public static readonly Field Pwd = FindByName(__.Pwd);

            /// <summary>部门控制</summary>
            public static readonly Field Detped = FindByName(__.Detped);

            /// <summary>停用</summary>
            public static readonly Field isStop = FindByName(__.isStop);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得用户字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String id = "id";

            /// <summary>登录用户名编号</summary>
            public const String UserID = "UserID";

            /// <summary>名称。登录用户名</summary>
            public const String UserName = "UserName";

            /// <summary>部门</summary>
            public const String Detp = "Detp";

            /// <summary>备注</summary>
            public const String Summary = "Summary";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>邮件</summary>
            public const String Email = "Email";

            /// <summary>电话</summary>
            public const String Tel = "Tel";

            /// <summary>密码</summary>
            public const String Pwd = "Pwd";

            /// <summary>部门控制</summary>
            public const String Detped = "Detped";

            /// <summary>停用</summary>
            public const String isStop = "isStop";
        }
        #endregion
    }

    /// <summary>用户接口</summary>
    public partial interface IActUser
    {
        #region 属性
        /// <summary></summary>
        Int32 id { get; set; }

        /// <summary>登录用户名编号</summary>
        String UserID { get; set; }

        /// <summary>名称。登录用户名</summary>
        String UserName { get; set; }

        /// <summary>部门</summary>
        String Detp { get; set; }

        /// <summary>备注</summary>
        String Summary { get; set; }

        /// <summary>状态</summary>
        Boolean State { get; set; }

        /// <summary>邮件</summary>
        String Email { get; set; }

        /// <summary>电话</summary>
        String Tel { get; set; }

        /// <summary>密码</summary>
        String Pwd { get; set; }

        /// <summary>部门控制</summary>
        Boolean Detped { get; set; }

        /// <summary>停用</summary>
        Int32 isStop { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}