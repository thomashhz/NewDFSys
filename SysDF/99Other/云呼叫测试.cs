using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SysDF._99Other
{
    public partial class 云呼叫测试 : SysDF.BaseForm.BaseForm
    {
        public 云呼叫测试()
        {
            InitializeComponent();
        }

        private void 云呼叫测试_Load(object sender, EventArgs e)
        {
            textBox11.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Url = textBox1.Text.ToString().Trim();
            string StrParJson = textBox7.Text.ToString().Trim();
            string StrParAuth = textBox13.Text.ToString().Trim();
            
            textBox6.Text = Post(Url, StrParJson, StrParAuth);
        }

        public string Post(string Url, string jsonParas, string authParas)
        {
            string strURL = Url;
            //创建一个HTTP请求  
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            //Post请求方式  
            request.Method = "POST";

            //设置文件头
            SetHeaderValue(request.Headers, "Accept", "application/json");
            SetHeaderValue(request.Headers, "Content-Type", "application/json;charset=utf-8");
            SetHeaderValue(request.Headers, "Authorization", authParas);

            //内容类型
            request.ContentType = "application/json";

            //设置参数，并进行URL编码 ,json格式参数
            string paraUrlCoded = jsonParas; //System.Web.HttpUtility.UrlEncode(jsonParas);   
            byte[] payload;
            //将Json字符串转化为字节  
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的ContentLength   
            request.ContentLength = payload.Length;
            //发送请求，获得请求流 

            Stream writer;
            try
            {
                writer = request.GetRequestStream();//获取用于写入请求数据的Stream对象
            }
            catch (Exception)
            {
                writer = null;
                Console.Write("连接服务器失败!");
            }
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            writer.Close();//关闭请求流
                           // String strValue = "";//strValue为http响应所返回的字符流
            HttpWebResponse response;
            try
            {
                //获得响应流
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = ex.Response as HttpWebResponse;
            }
            Stream s = response.GetResponseStream();
            //  Stream postData = Request.InputStream;
            StreamReader sRead = new StreamReader(s);
            string postContent = sRead.ReadToEnd();
            sRead.Close();
            return postContent;//返回Json数据
        }
        /// <summary>
        /// 这个方法设置HttpHeader头
        /// </summary>
        /// <param name="header"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetHeaderValue(WebHeaderCollection header, string name, string value)
        {
            var property = typeof(WebHeaderCollection).GetProperty("InnerCollection", BindingFlags.Instance | BindingFlags.NonPublic);
            if (property != null)
            {
                var collection = property.GetValue(header, null) as NameValueCollection;
                collection[name] = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ulr = "http://apis.tycc100.com/v20160818/webCall/webCall/";
            ulr += textBox9.Text.ToString().Trim();
            ulr += "?sig=";  //不能有空格
            ulr += textBox12.Text.ToString();
            textBox1.Text = ulr.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //  " http://apis.tycc100.com/v20160818/call/dialout/ACCOUNTID?sig=SIG"

            string ulr = "http://apis.tycc100.com/v20160818/call/dialout/";
            ulr += textBox9.Text.ToString().Trim();
            ulr += "?sig=";  //不能有空格
            ulr += textBox12.Text.ToString().Trim();
            //ulr += "$";
            textBox1.Text = ulr.ToString();
        }
        static string UserMd5(string str)
        {
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 

                pwd = pwd + s[i].ToString("X").PadLeft(2,'0');

            }
            return pwd;

            //byte[] b = System.Text.Encoding.Default.GetBytes(str);
            //b = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(b);
            //string ret = "";
            //for (int i = 0; i < b.Length; i++)
            //{
            //    ret += b[i].ToString("X").PadLeft(2, '0');
            //}
            //// 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                       

            //return ret;

        }
        ///编码base64
        ////// <summary>
        /// 编码base64
                /// </summary>
                /// <param name="code_type"></param>  编码类型
        /// <param name="code"></param>  编码内容
                /// <returns></returns>
        public static string EncodeBase64(string code_type, string code)
        {
            string encode = "";
            byte[] bytes = Encoding.GetEncoding(code_type).GetBytes(code);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = code;
            }
            return encode;
        }
        ///解码base64
         /// </summary>
        /// <param name="code_type"></param>  解码类型
        /// <param name="code"></param>  解码内容
        /// <returns></returns>
        public static string DecodeBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //刷新时间戳 
            textBox11.Text = DateTime.Now.ToString("yyyyMMddHHmmss");

            //生成SIG(32位MD5加密)
            string strmd = textBox9.Text.ToString().Trim() + textBox10.Text.ToString().Trim() + textBox11.Text.ToString().Trim();
            textBox12.Text = UserMd5(strmd);

            textBox14.Text = textBox12.Text.Length.ToString();

            //生成auth(base64编码)

            strmd = textBox9.Text.ToString().Trim() + ":" + textBox11.Text.ToString().Trim();

            textBox13.Text = EncodeBase64("utf-8", strmd);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //生成auth(base64编码)

            //调用方法：base64 编码


            string strmd = textBox9.Text.ToString().Trim() + ":" + textBox11.Text.ToString().Trim();

            textBox13.Text = EncodeBase64("utf-8", strmd);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //webcall接口参数
            
           string StrParas = "{\"Action\": \"Webcall\",";
            //主叫号码
            StrParas += "\"ServiceNo\":\"" + textBox4.Text.ToString().Trim() + "\",";
            //被叫号码  
            StrParas += "\"Exten\":\"" + textBox5.Text.ToString().Trim() + "\",";
            
            StrParas += "\"CallBackType\":\"post\"";
            StrParas += "}";

            textBox7.Text = StrParas;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                }
            string StrParas = "{";
            //座席号
            StrParas += "\"FromExten\": \"" + textBox8.Text.ToString().Trim() + "\",";
            //被叫号码  
            StrParas += "\"Exten\":\"" + textBox5.Text.ToString().Trim() + "\",";

            StrParas += "\"ExtenType\":\"gateway\"";
            StrParas += "}";

            textBox7.Text = StrParas;

        }
    }
}
