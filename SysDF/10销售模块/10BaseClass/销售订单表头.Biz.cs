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

namespace XCode.Membership
{
    /// <summary>销售订单表头</summary>
    public partial class Inv_Evi : Entity<Inv_Evi>
    {
        #region 对象操作
        static Inv_Evi()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.Lsbh);

            // 过滤器 UserModule、TimeModule、IPModule
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 这里验证参数范围，建议抛出参数异常，指定参数名，前端用户界面可以捕获参数异常并聚焦到对应的参数输入框
            if (EviNO.IsNullOrEmpty()) throw new ArgumentNullException(nameof(EviNO), "单据编号不能为空！");

            // 在新插入数据或者修改了指定字段时进行修正
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化Inv_Evi[销售订单表头]数据……");

        //    var entity = new Inv_Evi();
        //    entity.ID = 0;
        //    entity.Lsbh = 0;
        //    entity.EviNO = "abc";
        //    entity.EviDate = DateTime.Now;
        //    entity.PlanPayDate = DateTime.Now;
        //    entity.SumQty = 0.0;
        //    entity.SumNQty = 0.0;
        //    entity.SumWeight = 0.0;
        //    entity.SumAmount = 0.0;
        //    entity.Verifier = "abc";
        //    entity.Verified = 0;
        //    entity.Verifierdate = DateTime.Now;
        //    entity.CustID = "abc";
        //    entity.Person = "abc";
        //    entity.Driver = "abc";
        //    entity.Poster = "abc";
        //    entity.Payed = 0;
        //    entity.PayNO = "abc";
        //    entity.CreatDate = DateTime.Now;
        //    entity.Creater = "abc";
        //    entity.LastDate = DateTime.Now;
        //    entity.Laster = "abc";
        //    entity.PayType = true;
        //    entity.Summary = "abc";
        //    entity.Payer = "abc";
        //    entity.Invoiced = 0;
        //    entity.Invoicer = "abc";
        //    entity.InvoiceNo = "abc";
        //    entity.AreaID = "abc";
        //    entity.PrevArea = "abc";
        //    entity.EviType = true;
        //    entity.FreightWay = 0;
        //    entity.Helper = "abc";
        //    entity.Verifiertime = DateTime.Now;
        //    entity.blnOutStock = 0;
        //    entity.StockNo = "abc";
        //    entity.Stocker = "abc";
        //    entity.EviBSC = "abc";
        //    entity.Shrq = DateTime.Now;
        //    entity.Shbz = 0;
        //    entity.Shsm = "abc";
        //    entity.Shqrsj = DateTime.Now;
        //    entity.Shqrrq = DateTime.Now;
        //    entity.Shqrer = "abc";
        //    entity.iMonth = 0;
        //    entity.DrvName = "abc";
        //    entity.YFKid = 0;
        //    entity.Xdr = "abc";
        //    entity.Ddsx = "abc";
        //    entity.Fhqrbz = 0;
        //    entity.Fhqrer = "abc";
        //    entity.Fhqrdate = DateTime.Now;
        //    entity.Skqrbz = 0;
        //    entity.Skqrer = "abc";
        //    entity.Skqrdate = DateTime.Now;
        //    entity.Sjskr = "abc";
        //    entity.Ygbz = 0;
        //    entity.Ygrq = DateTime.Now;
        //    entity.Ygr = "abc";
        //    entity.Pcbz = 0;
        //    entity.Pcrq = DateTime.Now;
        //    entity.Pcr = "abc";
        //    entity.Jhxsbz = 0;
        //    entity.Sjshqrbz = 0;
        //    entity.Sjshqrrq = DateTime.Now;
        //    entity.Sjshqrer = "abc";
        //    entity.Kpqrbz = 0;
        //    entity.CarNo = "abc";
        //    entity.Fhqrdateys = DateTime.Now;
        //    entity.KCblnOutStock = 0;
        //    entity.KcBlnoutstock = 0;
        //    entity.KcStocker = "abc";
        //    entity.KcStockno = "abc";
        //    entity.Custname = "abc";
        //    entity.Tel = "abc";
        //    entity.Caddress = "abc";
        //    entity.Apid = 0;
        //    entity.Pcid = 0;
        //    entity.Rlid = 0;
        //    entity.SHType = 0;
        //    entity.PcdScno = "abc";
        //    entity.Pdsdr = "abc";
        //    entity.Pdsdrq = DateTime.Now;
        //    entity.Pdsdzdr = "abc";
        //    entity.Pdsdrqtime = DateTime.Now;
        //    entity.iYear = 0;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化Inv_Evi[销售订单表头]数据！");
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
        /// <summary>根据自增ID查找</summary>
        /// <param name="id">自增ID</param>
        /// <returns>实体对象</returns>
        public static Inv_Evi FindByID(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.ID == id);

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.ID == id);
        }

        /// <summary>根据客户编号查找</summary>
        /// <param name="custid">客户编号</param>
        /// <returns>实体列表</returns>
        public static IList<Inv_Evi> FindAllByCustID(String custid)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.FindAll(e => e.CustID == custid);

            return FindAll(_.CustID == custid);
        }

        /// <summary>根据可编辑流失编号查找</summary>
        /// <param name="lsbh">可编辑流失编号</param>
        /// <returns>实体列表</returns>
        public static IList<Inv_Evi> FindAllByLsbh(Int32 lsbh)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.FindAll(e => e.Lsbh == lsbh);

            return FindAll(_.Lsbh == lsbh);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}