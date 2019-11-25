using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using NewLife;
using NewLife.Data;
using NewLife.Log;
using NewLife.Model;
using NewLife.Reflection;
using NewLife.Threading;
using NewLife.Web;
using XCode;
using XCode.Cache;
using XCode.Configuration;
using XCode.DataAccessLayer;
using XCode.Membership;
using Hhz.SysDF.SysModule;

namespace Hhz.SysDF.SysModule
{
    /// <summary>部门档案</summary>
    public partial class Dept : Entity<Dept>
    {
        #region 对象操作
        static Dept()
        {

            // 过滤器 UserModule、TimeModule、IPModule
            Meta.Modules.Add<UserModule>();
            Meta.Modules.Add<TimeModule>();
            Meta.Modules.Add<IPModule>();
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 这里验证参数范围，建议抛出参数异常，指定参数名，前端用户界面可以捕获参数异常并聚焦到对应的参数输入框
            if (DeptID.IsNullOrEmpty()) throw new ArgumentNullException(nameof(DeptID), "部门编号不能为空！");

            // 在新插入数据或者修改了指定字段时进行修正
            //if (isNew && !Dirtys[nameof(CreateTime)]) CreateTime = DateTime.Now;
            //if (!Dirtys[nameof(UpdateTime)]) UpdateTime = DateTime.Now;
            //if (isNew && !Dirtys[nameof(CreateIP)]) CreateIP = ManageProvider.UserHost;
            //if (!Dirtys[nameof(UpdateIP)]) UpdateIP = ManageProvider.UserHost;

            // 检查唯一索引
            // CheckExist(isNew, __.id, __.DeptID);
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化Dept[部门档案]数据……");

        //    var entity = new Dept();
        //    entity.id = 0;
        //    entity.DeptID = "abc";
        //    entity.DeptName = "abc";
        //    entity.Depter = "abc";
        //    entity.BZ = "abc";
        //    entity.CreateUserID = "abc";
        //    entity.CreateIP = "abc";
        //    entity.CreateTime = DateTime.Now;
        //    entity.UpdateUserID = "abc";
        //    entity.UpdateIP = "abc";
        //    entity.UpdateTime = DateTime.Now;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化Dept[部门档案]数据！");
        //}

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnDelete()
        //{
        //    return base.OnDelete();
        //}
        #endregion

        #region 扩展属性
        

        #endregion

        #region 扩展查询
        /// <summary>根据No查找</summary>
        /// <param name="id">No</param>
        /// <returns>实体对象</returns>
        public static Dept FindByid(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.id == id);

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.id == id);
        }

        /// <summary>根据No、部门编号查找</summary>
        /// <param name="id">No</param>
        /// <param name="deptid">部门编号</param>
        /// <returns>实体对象</returns>
        public static Dept FindByidAndDeptID(Int32 id, String deptid)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.id == id && e.DeptID == deptid);

            return Find(_.id == id & _.DeptID == deptid);
        }
        public static Dept FindByDeptID( String deptid)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e =>  e.DeptID == deptid);

            return Find( _.DeptID == deptid);
        }

        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}