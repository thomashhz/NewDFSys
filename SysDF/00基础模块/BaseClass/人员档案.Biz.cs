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
    /// <summary>人员档案</summary>
    public partial class Person : Entity<Person>
    {
        #region 对象操作
        static Person()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.Zzjs);

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
            if (Pname.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Pname), "人员姓名不能为空！");

            // 在新插入数据或者修改了指定字段时进行修正
            // 货币保留6位小数
            Zzbl = Math.Round(Zzbl, 6);
            Psbz = Math.Round(Psbz, 6);
            Psdzbz = Math.Round(Psdzbz, 6);
            //if (isNew && !Dirtys[nameof(CreateTime)]) CreateTime = DateTime.Now;
            //if (!Dirtys[nameof(UpdateTime)]) UpdateTime = DateTime.Now;
            //if (isNew && !Dirtys[nameof(CreateIP)]) CreateIP = ManageProvider.UserHost;
            //if (!Dirtys[nameof(UpdateIP)]) UpdateIP = ManageProvider.UserHost;

            // 检查唯一索引
            // CheckExist(isNew, __.ID, __.Pname);
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化Person[人员档案]数据……");

        //    var entity = new Person();
        //    entity.ID = 0;
        //    entity.Pname = "abc";
        //    entity.Sex = "abc";
        //    entity.Job = "abc";
        //    entity.Paper = "abc";
        //    entity.PaperNum = "abc";
        //    entity.InDate = DateTime.Now;
        //    entity.OutDate = DateTime.Now;
        //    entity.AreaID = "abc";
        //    entity.Status = "abc";
        //    entity.DeptID = "abc";
        //    entity.Qsrq = DateTime.Now;
        //    entity.Zzjs = 0;
        //    entity.Zzbl = 0.0;
        //    entity.Psbz = 0.0;
        //    entity.Psdzbz = 0.0;
        //    entity.Zwpdbh = "abc";
        //    entity.Zwpdmc = "abc";
        //    entity.Pdpxbh = "abc";
        //    entity.Driverfz = "abc";
        //    entity.CreateUserID = "abc";
        //    entity.CreateIP = "abc";
        //    entity.CreateTime = DateTime.Now;
        //    entity.UpdateUserID = "abc";
        //    entity.UpdateIP = "abc";
        //    entity.UpdateTime = DateTime.Now;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化Person[人员档案]数据！");
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

        /// <summary>根据ID、人员姓名查找</summary>
        /// <param name="id">ID</param>
        /// <param name="pname">人员姓名</param>
        /// <returns>实体对象</returns>
        public static Person FindByIDAndPname(Int32 id, String pname)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.ID == id && e.Pname == pname);

            return Find(_.ID == id & _.Pname == pname);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}