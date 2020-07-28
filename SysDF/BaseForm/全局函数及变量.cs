using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hhz.dbdata //可以修改成实际项目的命名空间名称
{
   

    public partial class PubFunVar
    {
        public static Int32 LoginID = 0;
        public static string LoginUserID = "";  //用户编号
        public static string LoginUserName = "";    //用户名称
        public static Boolean LoginTrue = false;  //是否登录成功

    }
    public partial class PubFun
    {
        /// <summary>
        /// 空字符判断：nullZore
        /// </summary>
        /// <param name="str1"></param>
        /// <returns></returns>
        /// 
        public static string Nz(object str1,object str2)
        {
            
            string retstring = str2.ToString();
            if(str1==null)
            {
                return retstring;
            
            }else
            {
                retstring = str1.ToString().Trim();
                return retstring;
            }
        }

        public static string GetSplit(object str1,int i)
        {
            string StrRet = "";
            if(str1==null)
            {
                return StrRet;
            }
            else
            {
                string[] sArray = str1.ToString().Split("|");
                try
                {
                    StrRet= sArray[i].ToString();
                }
                finally
                {
                    StrRet= "";
                }
                return StrRet.ToString();
            }
            
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class DESHelper
    {
        //密钥
        public static byte[] _KEY = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
        //向量
        public static byte[] _IV = new byte[] { 0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01 };

        /// <summary>
        /// DES加密操作
        /// </summary>
        /// <param name="normalTxt"></param>
        /// <returns></returns>
        public static string DesEncrypt(string normalTxt)
        {
            //byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(_KEY);
            //byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(_IV);

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            int i = cryptoProvider.KeySize;
            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(_KEY, _IV), CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cst);
            sw.Write(normalTxt);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();

            string strRet = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            return strRet;
        }

        /// <summary>
        /// DES解密操作
        /// </summary>
        /// <param name="securityTxt">加密字符串</param>
        /// <returns></returns>
        public static string DesDecrypt(string securityTxt)//解密  
        {
            //byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(_KEY);
            //byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(_IV);
            if(securityTxt.ToString().Trim()=="")
            {
                return null;
            }
            else
            {
                byte[] byEnc;
                try
                {
                    securityTxt.Replace("_%_", "/");
                    securityTxt.Replace("-%-", "#");
                    byEnc = Convert.FromBase64String(securityTxt);
                }
                catch
                {
                    return null;
                }
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(byEnc);
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(_KEY, _IV), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cst);
                return sr.ReadToEnd();
            }
            
        }



    }

//--------------------- 
//作者：gx_up
//来源：CSDN
//原文：https://blog.csdn.net/qq_32688731/article/details/80657826 
//版权声明：本文为博主原创文章，转载请附上博文链接！


}
