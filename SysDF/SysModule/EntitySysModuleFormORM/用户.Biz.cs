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

namespace Hhz.SysDF.SysModule
{
    /// <summary>用户</summary>
    public partial class ActUser : Entity<ActUser>
    {
        #region 对象操作
        static ActUser()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.isStop);

            // 过滤器 UserModule、TimeModule、IPModule
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 这里验证参数范围，建议抛出参数异常，指定参数名，前端用户界面可以捕获参数异常并聚焦到对应的参数输入框
            if (UserID.IsNullOrEmpty()) throw new ArgumentNullException(nameof(UserID), "登录用户名编号不能为空！");
            if (UserName.IsNullOrEmpty()) throw new ArgumentNullException(nameof(UserName), "名称不能为空！");

            // 在新插入数据或者修改了指定字段时进行修正

            // 检查唯一索引
            // CheckExist(isNew, __.UserName);
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化ActUser[用户]数据……");

        //    var entity = new ActUser();
        //    entity.id = 0;
        //    entity.UserID = "abc";
        //    entity.UserName = "abc";
        //    entity.Detp = "abc";
        //    entity.Summary = "abc";
        //    entity.State = true;
        //    entity.Email = "abc";
        //    entity.Tel = "abc";
        //    entity.Pwd = "abc";
        //    entity.Detped = true;
        //    entity.isStop = 0;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化ActUser[用户]数据！");
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
        /// <summary>根据id查找</summary>
        /// <param name="id">id</param>
        /// <returns>实体对象</returns>
        public static ActUser FindByid(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.id == id);

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.id == id);
        }

        /// <summary>根据名称查找</summary>
        /// <param name="username">名称</param>
        /// <returns>实体对象</returns>
        public static ActUser FindByUserName(String username)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.UserName == username);

            return Find(_.UserName == username);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}